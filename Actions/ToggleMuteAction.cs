using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;

namespace RecklessBoon.MacroDeck.Discord.Actions
{
    public class ToggleMuteAction : PluginAction
    {
        // The name of the action
        public override string Name => "Toggle Mute";

        // A short description what the action can do
        public override string Description => "Toggle voice server mute state";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => false;

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            var plugin = PluginInstance.Plugin;
            var state = PluginInstance.cache.VoiceState;

            if (state != null && plugin.RPCClient != null && plugin.RPCClient.IsConnected)
            {
                state.SelfMute = !state.SelfMute;
                _ = plugin.RPCClient.Command("SET_VOICE_SETTINGS", new { mute = state.SelfMute });
                plugin.UpdateVoiceStateVariables(state);
            }
            return;
        }
    }
}
