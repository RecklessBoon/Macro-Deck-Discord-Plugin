# Macro Deck Discord Plugin

![GitHub](https://img.shields.io/github/license/RecklessBoon/Macro-Deck-Discord-Plugin)

A plugin for Macro Deck 2 to interact with a local Discord client.

> **NOTE:** This plugin uses the official RPC API from Discord, however it is 
currently in "private beta". Expect things to break at some point in the future 
if they modify the API after coming out of beta, whenever that may be.

If you like my work and want to support/encourage me in making more plugins, you certainly can do so on Ko-Fi.

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/Z8Z37FRBM)

## Features

### Variables
This plugin updates the following variables for use anywhere variables are
allowed in Macro Deck 2

| Variable Name              | Description                                                   |
| -------------------------- | :------------------------------------------------------------ |
| discord_is_self_deafened   | True if you are deafened from the client end                  |
| discord_is_server_deafened | True if you are deafened from the server end                  |
| discord_is_any_deafened    | True if you are deafened from either the client or server end |
| discord_is_self_muted      | True if you are muted from the client end                     |
| discord_is_server_muted    | True if you are muted from the server end                     |
| discord_is_any_muted       | True if you are muted from either the client or server end    |

### Actions
This plugin adds the following actions

#### Mute Actions

| Action       | Description                               |
| ------------ | :---------------------------------------- |
| Set Mute On  | Set your self mute status to muted        |
| Set Mute Off | Set your self mute status to unmuted      |
| Toggle Mute  | Toggle your self mute status              |

#### Deafen Actions

| Action       | Description                               |
| ------------ | :---------------------------------------- |
| Set Deaf On  | Set your self deafen status to deafened   |
| Set Deaf Off | Set your self deafen status to undefeaned |
| Toggle Deaf  | Toggle your self deafen status            |

#### Webhook Actions
| Action       | Description                               |
| ------------ | :---------------------------------------- |
| Execute Webhook | Use a webhook to send a message to a particular channel. <br/>Allows setting:<br/>&nbsp;&nbsp;-&nbsp;Bot name<br/>&nbsp;&nbsp;-&nbsp;Message<br/>&nbsp;&nbsp;-&nbsp;Embedded media (image, vide, etc.) |

#### Rich Presence Actions
| Action       | Description                               |
| ------------ | :---------------------------------------- |
| Set Rich Presence | Set a custom rich presence on your profile <br/><br/> <small><b>NOTE:</b> Image keys can only be asset names in your app Rich Presence -> Art Assets page</smalll> |
| Clear Rich Presence | Erase current custom rich presence (only removes presence set by this plugin) |

<small><i>*Custom rich presence shows up in "Activity" on your profile and in your status if not disallowed</i></small>

<br/>

> **NOTE:** There are currently no actions that can be performed on the server
> side as there is no bot integration with this. If there is a large demand for
> bot integration to handle those kinds of actions, that may come at a later date.

## Installation
Download/Install it directly in Macro Deck from the package manager.

## Configuration

### Discord Application

> **NOTE:** Due to the nature of OAuth2.0 requiring a client secret to stay, well 
secret, it is impossible for Macro Deck contributors to set up a single 
application as all of the source is shared which would include the secret. This 
means you will need to create your own application to use with this plugin. Don't 
worry, it's not hard to do.

To create your own Discord application:
1. Go to [Discord Developer Portal](https://discord.com/developers/applications)
2. Click the "New Application" button in the top right corner
3. Name the application (You can just use "Macro Deck Plugin" or anything really, 
it's yours)
4. On the OAuth2 page, add a Redirect of "https://127.0.0.1"
   - Note the Client Id and the Client Secret on this page
   - You will enter these in the Macro Deck plugin configuration screen shortly
   - The Public Key **IS NOT** the same as the Client Secret. Make sure you copy 
     the right one.
5. BE SURE TO CLICK SAVE!
   - It is very easy to miss the green button at the bottom of the screen


### Macro Deck 2
1. Open Macro Deck 2 application on your computer
2. Switch to the plugin manager view and locate the discord plugin (install if 
   necessary)
3. Click the "Configure" button
4. Enter the Client Id and Client Secret noted before
5. If your Discord application hasn't already popped up, switch to it
6. It should be asking if your Discord Application can connect and do certain 
   things on your client. Here you should allow it to.
   - If it doesn't pop up, make sure you copied the correct Client Id and 
     Client Secret. Clear out the configuration and re-enter them.

After that, you should be able to watch the `discord_*` variables change when
you change your mute/deafen state **while in a voice channel**

## Addendum

### Not a Standalone App
<img align="right" height="96px" src="https://macrodeck.org/images/macro_deck_2_community_plugin.png" />

This is a plugin for [Macro Deck 2](https://github.com/SuchByte/Macro-Deck), it does **NOT** function as a standalone app

### Third Party Licenses / Thank you

This plugin is built upon the shoulders of giants. Here are their licenses:

- [Newtonsoft.Json](https://www.newtonsoft.com/json)
- [Discord.Net](https://discordnet.dev/)
- [Discord Rich Presence](https://github.com/Lachee/discord-rpc-csharp)

The icons used are not mine:
- (Eye icons) [Material Design Icons](https://materialdesignicons.com/)
- (Plugin icons) Discord user MakeTrue#0776
