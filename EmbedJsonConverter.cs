using Discord;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace RecklessBoon.MacroDeck.Discord
{
    class EmbedJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(Embed));
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // Load the JSON for the Result into a JObject
            JObject jo = JObject.Load(reader);

            // Read the properties which will be used as constructor parameters
            EmbedAuthorBuilder authorBuilder = null;
            if (jo.ContainsKey("Author") && !String.IsNullOrEmpty(jo["Author"].ToString()))
            {
                authorBuilder = new EmbedAuthorBuilder()
                {
                    Name = jo["Author"]["Name"].ToString(),
                    Url = jo["Author"]["Url"].ToString(),
                    IconUrl = jo["Author"]["IconUrl"].ToString()
                };
            }
            string title = (string)jo["Title"];
            string url = (string)jo["Url"];
            string description = (string)jo["Description"];
            string thumbnailUrl = jo.ContainsKey("Thumbnail") ? (string)jo["Thumbnail"]["Url"] : null;
            string imageUrl = jo.ContainsKey("Image") ? (string)jo["Image"]["Url"] : null;
            Color? color = null;
            if (jo.ContainsKey("Color") && !String.IsNullOrEmpty(jo["Color"].ToString()))
            {
                color = new Color(int.Parse(jo["Color"]["R"].ToString()), int.Parse(jo["Color"]["G"].ToString()), int.Parse(jo["Color"]["B"].ToString()));
            }
            EmbedFooterBuilder footerBuilder = null;
            if (jo.ContainsKey("Footer") && !String.IsNullOrEmpty(jo["Footer"].ToString()))
            {
                footerBuilder = new EmbedFooterBuilder()
                {
                    Text = jo["Footer"]["Text"].ToString(),
                    IconUrl = jo["Footer"]["IconUrl"].ToString()
                };
            }

            var builder = new EmbedBuilder()
            {
                Author = authorBuilder,
                Title = title,
                Url = url,
                Description = description,
                ThumbnailUrl = thumbnailUrl,
                ImageUrl = imageUrl,
                Color = color,
                Footer = footerBuilder,
            };

            // Construct the Result object using the non-default constructor


            // (If anything else needs to be populated on the result object, do that here)

            // Return the result
            return builder.Build();
        }

        public override bool CanWrite
        {
            get { return false; }
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
