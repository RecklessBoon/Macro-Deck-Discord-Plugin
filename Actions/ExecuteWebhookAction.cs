using Discord;
using Discord.Webhook;
using RecklessBoon.MacroDeck.Discord.UI;
using SuchByte.MacroDeck.ActionButton;
using SuchByte.MacroDeck.GUI;
using SuchByte.MacroDeck.GUI.CustomControls;
using SuchByte.MacroDeck.Plugins;
using System;
using System.Collections.Generic;

namespace RecklessBoon.MacroDeck.Discord.Actions
{
    public class ExecuteWebhookAction : PluginAction
    {
        // The name of the action
        public override string Name => "Execute Webhook";

        // A short description what the action can do
        public override string Description => "Execute a Webhook";

        // Optional; Add if this action can be configured. This will make the ActionConfigurator calling GetActionConfigurator();
        public override bool CanConfigure => true;

        // Optional; Add if you added CanConfigure; Gets called when the action can be configured and the action got selected in the ActionSelector. You need to return a user control with the "ActionConfigControl" class as base class
        public override ActionConfigControl GetActionConfigControl(ActionConfigurator actionConfigurator)
        {
            return new ExecuteWebhookSelect(this, actionConfigurator);
        }

        // Gets called when the action is triggered by a button press or an event
        public override void Trigger(string clientId, ActionButton actionButton)
        {
            try
            {
                var config = ExecuteWebhookSelect.LoadWebhook(Configuration);
                if (!String.IsNullOrEmpty(config.Url) && (!String.IsNullOrEmpty(config.Message) || config.Embeds.Length > 0))
                {
                    var _client = new DiscordWebhookClient(config.Url);
                    var embeds = new List<Embed>(config.Embeds);
                    _client.SendMessageAsync(config.Message, false, embeds, config.Name, config.AvatarUrl?.ToString());
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
