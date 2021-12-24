using RecklessBoon.MacroDeck.Discord.Actions;
using RecklessBoon.MacroDeck.Discord.RPC;
using RecklessBoon.MacroDeck.Discord.RPC.Model;
using RecklessBoon.MacroDeck.Discord.RPC.Model.Responses;
using SuchByte.MacroDeck.Plugins;
using SuchByte.MacroDeck.Variables;
using System;
using System.Collections.Generic;

namespace RecklessBoon.MacroDeck.Discord
{

    public static class PluginInstance
    {
        public static DiscordPlugin Plugin;
        public static StateCache cache = new StateCache()
        {
            VoiceState = new VoiceState()
        };
    }

    public class DiscordPlugin : MacroDeckPlugin
    {
        public Configuration configuration;

        // A short description what the plugin can do
        public override string Description => "Discord Integration plugin";

        // You can add a image from your resources here
        public override System.Drawing.Image Icon => Properties.Resources.DiscordIcon;

        // Optional; If your plugin can be configured, set to "true". It'll make the "Configure" button appear in the package manager.
        public override bool CanConfigure => true;

        protected RPCClient _RPCClient;
        public RPCClient RPCClient { get { return _RPCClient; } }

        public class VariableState
        {
            public string Name { get; set; }
            protected VariableType _type = VariableType.Bool;
            public VariableType Type { get { return _type; } set { _type = value; } }
            protected object _value = false;
            public object Value { get { return _value; } set { _value = value; } }
            protected bool _save = true;
            public bool Save { get { return _save; } set { _save = value; } }

        }

        public void SetVariable(VariableState variableState)
        {
            VariableManager.SetValue(string.Format("discord_{0}", variableState.Name), variableState.Value, variableState.Type, this, variableState.Save);
        }

        public string GetVariable(string key)
        {
            var name = String.Format("discord_{0}", key);
            return VariableManager.Variables.Find(x => x.Name == name).Value;
        }

        public void SetVariable(VariableState[] variableStates)
        {
            foreach (VariableState state in variableStates)
            {
                SetVariable(state);
            }
        }

        public void UpdateVoiceStateVariables(VoiceState voiceState)
        {
            if (voiceState == null)
                voiceState = new VoiceState();

            PluginInstance.cache.VoiceState = voiceState;
            SetVariable(new[] {
                new VariableState { Name = "is_self_muted", Value = voiceState.SelfMute },
                new VariableState { Name = "is_self_deafened", Value = voiceState.SelfDeaf },
                new VariableState { Name = "is_server_muted", Value = voiceState.Mute },
                new VariableState { Name = "is_server_deafened", Value = voiceState.Deaf },
                new VariableState { Name = "is_any_muted", Value = voiceState.Mute || voiceState.SelfMute },
                new VariableState { Name = "is_any_deafened", Value = voiceState.Deaf || voiceState.SelfDeaf },
            });
        }

        public DiscordPlugin()
        {
            PluginInstance.Plugin ??= this;
        }

        // Gets called when the plugin is loaded
        public override void Enable()
        {
            configuration ??= new Configuration(PluginInstance.Plugin);
            ResetVariables();
            InitClient();

            Actions = new List<PluginAction>
            {
                // add the instances of your actions here
                new ExecuteWebhookAction(),
                new SetMuteOnAction(),
                new SetMuteOffAction(),
                new ToggleMuteAction(),
                new SetDeafenOnAction(),
                new SetDeafenOffAction(),
                new ToggleDeafenAction(),
            };
        }

        protected void InitClient()
        {
            if ((RPCClient == null || RPCClient.IsDisposed) && !String.IsNullOrEmpty(PluginInstance.Plugin.configuration.ClientId))
            {
                _RPCClient = new RPCClient(PluginInstance.Plugin.configuration.ClientId);
                ConnectClients();
                RPCClient.Start();
            }
        }

        protected void ConnectClients()
        {
            RPCClient.OnVoiceStateUpdate += Client_OnVoiceStateUpdate;
            RPCClient.OnVoiceSettingsUpdate += Client_OnVoiceSettingsUpdate;
        }

        protected void ResetVariables()
        {
            SetVariable(new[] {
                new VariableState { Name = "is_self_muted" },
                new VariableState { Name = "is_self_deafened" },
                new VariableState { Name = "is_server_muted" },
                new VariableState { Name = "is_server_deafened" },
                new VariableState { Name = "is_any_muted" },
                new VariableState { Name = "is_any_deafened" }
            });
        }

        private void Client_OnVoiceSettingsUpdate(object sender, VoiceSettingsResponse payload)
        {
            if (PluginInstance.cache.CurrentVoiceChannelID == null)
            {
                var currentVoiceState = PluginInstance.cache.VoiceState;
                currentVoiceState.SelfMute = payload.IsMute || payload.IsDeaf;
                currentVoiceState.SelfDeaf = payload.IsDeaf;
                UpdateVoiceStateVariables(currentVoiceState);
            }
        }

        protected void Client_OnVoiceStateUpdate(object sender, VoiceStateResponse payload)
        {
            UpdateVoiceStateVariables(payload.VoiceState);
        }

        // Optional; Gets called when the user clicks on the "Configure" button in the package manager; If CanConfigure is not set to true, you don't need to add this
        public override void OpenConfigurator()
        {
            // Open your configuration form here
            using var configurator = new ConfigurationForm(configuration);
            configurator.OnSecretChanged += (object form, EventArgs e) =>
            {
                if (RPCClient != null) RPCClient.Dispose();
                InitClient();
            };
            configurator.ShowDialog();
        }
    }
}