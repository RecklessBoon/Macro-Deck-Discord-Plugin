using RecklessBoon.MacroDeck.Discord.RPC.Model.Responses;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.Plugins;
using System.Threading.Tasks;

namespace RecklessBoon.MacroDeck.Discord.Actions
{
    public class ToggleDeafenAction : PluginAction
    {
        // The name of the action
        public override string Name => "Toggle Deafen";

        // A short description what the action can do
        public override string Description => "Toggle voice server deafen state";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => false;

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            var plugin = PluginInstance.Plugin;
            var state = PluginInstance.cache.VoiceState;

            if (state != null && plugin.RPCClient != null && plugin.RPCClient.IsConnected)
            {
                state.SelfDeaf = !state.SelfDeaf;
                state.SelfMute = state.SelfDeaf == true || state.SelfMute;
                _ = plugin.RPCClient.Command("SET_VOICE_SETTINGS", new { deaf = state.SelfDeaf });
            }
            return;
        }
    }
}
