using DiscordRPC;
using RecklessBoon.MacroDeck.Discord.UI;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;

namespace RecklessBoon.MacroDeck.Discord.Actions
{
    public class SetRichPresenceAction : PluginAction
    {
        // The name of the action
        public override string Name => "Set Rich Presence";

        // A short description what the action can do
        public override string Description => "Set Rich Presence in Discord";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => true;

        // Optional; Add if you added CanConfigure; Gets called when the action can be configured and the action got selected in the ActionSelector. You need to return a user control with the "ActionConfigControl" class as base class
        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new SetRichPresenceConfig(this, actionConfigurator);
        }

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            var _client = PluginInstance.Plugin.RPCClient;
            var config = SetRichPresenceConfig.LoadRichPresenceConfig(Configuration);
            if (_client != null && !string.IsNullOrWhiteSpace(config.Details))
            {
                Timestamps timestamps = null;
                if (config.DelayStart != null || config.Duration != null)
                {
                    var start = config.DelayStart != default ? (System.DateTime?)System.DateTime.UtcNow.AddSeconds((double)config.DelayStart) : null;
                    var endStart = start != default ? start : System.DateTime.UtcNow;
                    var end = config.Duration != default ? endStart?.AddSeconds((double)config.Duration) : null;
                    timestamps = new Timestamps
                    {
                        Start = start,
                        End = end
                    };
                }

                var richPresence = new RichPresence
                {
                    Details = config.Details,
                    State = config.State
                };
                if (timestamps != null)
                {
                    richPresence.Timestamps = timestamps;
                }
                if (config.LargeImageKey != null || config.SmallImageKey != null)
                {
                    richPresence.WithAssets(new Assets
                    {
                        LargeImageKey = config.LargeImageKey,
                        LargeImageText = config.LargeImageText,
                        SmallImageKey = config.SmallImageKey,
                        SmallImageText = config.SmallImageText,
                    });
                }

                _client.BaseClient.SetPresence(richPresence);
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
