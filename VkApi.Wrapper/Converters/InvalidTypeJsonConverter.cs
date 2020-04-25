using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace VkApi.Wrapper.Converters
{
    /// <summary>
    /// JSON converter used to ignore strange VK API behaviour
    /// (returning arrays instead of objects, etc.)
    /// </summary>
    internal class InvalidTypeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType != null;

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            try
            {
                var token = JToken.Load(reader);
                return token.ToObject(objectType, serializer);
            }
            catch (JsonSerializationException)
            {
                return Activator.CreateInstance(objectType);
            }
        }

        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) => 
            throw new NotImplementedException();
    }
}