using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace VkLib.Converters
{
    /// <summary>
    /// JSON converter used to ignore strange VK API behaviour
    /// (returning arrays instead of objects, etc.)
    /// </summary>
    public class InvalidTypeJsonConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return objectType != null;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            try
            {
                JToken token = JToken.Load(reader);
                return token.ToObject(objectType, serializer);
            }
            catch (JsonSerializationException)
            {
                return Activator.CreateInstance(objectType);
            }
        }

        public override bool CanWrite { get => false; }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
