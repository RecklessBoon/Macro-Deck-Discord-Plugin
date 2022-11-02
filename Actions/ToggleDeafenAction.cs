using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;
using System;

namespace RecklessBoon.MacroDeck.Discord.Actions
{
    public class ToggleDeafenAction : PluginAction
    {
        public override string BindableVariable => "discord_is_self_deafened";

        // The name of the action
        public override string Name => "Toggle Deafen";

        // A short description what the action can do
        public override string Description => "Toggle voice server deafen state";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => false;

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            try
            {
                var plugin = PluginInstance.Plugin;
                var state = PluginInstance.cache.VoiceState;

                if (state != null && plugin.RPCClient != null && plugin.RPCClient.IsConnected)
                {
                    var newValue = !state.SelfDeaf;
                    _ = plugin.RPCClient.Command("SET_VOICE_SETTINGS", new { deaf = newValue });
                    state.SelfDeaf = newValue;
                    plugin.UpdateVoiceStateVariables(state);
                }
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
            return;
        }
    }
}
