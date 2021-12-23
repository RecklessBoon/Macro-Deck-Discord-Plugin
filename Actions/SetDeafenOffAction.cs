using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;

namespace RecklessBoon.MacroDeck.Discord.Actions
{
    public class SetDeafenOffAction : PluginAction
    {
        // The name of the action
        public override string Name => "Set Deafen Off";

        // A short description what the action can do
        public override string Description => "Set voice server deafen state to not deafened";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => false;

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            var plugin = PluginInstance.Plugin;
            var voiceState = PluginInstance.cache.VoiceState;

            if (plugin.RPCClient != null && plugin.RPCClient.IsConnected)
            {
                voiceState.SelfDeaf = false;

                var client = plugin.RPCClient;
                _ = client.Command("SET_VOICE_SETTINGS", new { deaf = voiceState.SelfDeaf });

                plugin.UpdateVoiceStateVariables(voiceState);
            }
            return;
        }
    }
}
