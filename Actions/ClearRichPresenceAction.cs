using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Diagnostics;

namespace RecklessBoon.MacroDeck.Discord.Actions
{
    public class ClearRichPresenceAction : PluginAction
    {
        // The name of the action
        public override string Name => "Clear Rich Presence";

        // A short description what the action can do
        public override string Description => "Clear Rich Presence in Discord";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => false;

        // Optional; Add if you added CanConfigure; Gets called when the action can be configured and the action got selected in the ActionSelector. You need to return a user control with the "ActionConfigControl" class as base class
        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return null;
        }

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            try
            {
                var _client = PluginInstance.Plugin.RPCClient;
                if (_client != null)
                {
                    _ = _client.Command("SET_ACTIVITY", new
                    {
                        pid = Process.GetCurrentProcess().Id
                    });
                }
            }
            catch (Exception ex)
            {
                PluginInstance.Logger.Error("Unexpected Exception:\n{0}", ex);
            }
            return;
        }

        // Optional; Gets called when the action button gets deleted
        public override void OnActionButtonDelete()
        {

        }

        // Optional; Gets called when the action button is loaded
        public override void OnActionButtonLoaded()
        {

        }
    }
}
