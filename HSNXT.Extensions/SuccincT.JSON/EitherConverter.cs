﻿using Newtonsoft.Json;
using HSNXT.SuccincT.Unions;
using System;
using Newtonsoft.Json.Linq;
using NJsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace HSNXT.SuccincT.JSON
{
    public class EitherConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) =>
            objectType.IsGenericType() && objectType.GetGenericTypeDefinition() == typeof(Either<,>);

        public override object ReadJson(JsonReader reader,
            Type objectType,
            object existingValue,
            NJsonSerializer serializer)
        {
            var type1 = objectType.GenericTypeArguments[0];
            var type2 = objectType.GenericTypeArguments[1];
            var rawEitherType = typeof(Either<,>);
            var eitherType = rawEitherType.MakeGenericType(type1, type2);

            var jsonObject = JObject.Load(reader);
            var isLeft = jsonObject["isLeft"].ToObject<bool>(serializer);
            var valueJson = jsonObject["value"];
            var value = isLeft
                ? valueJson.ToObject(type1, serializer)
                : valueJson.ToObject(type2, serializer);

            return Activator.CreateInstance(eitherType, value);
        }

        public override void WriteJson(JsonWriter writer, object value, NJsonSerializer serializer)
        {
            var eitherType = value.GetType();
            var leftProperty = eitherType.GetProperty("IsLeft");
            var isLeft = (bool) leftProperty.GetValue(value, null);
            var variantValue = isLeft
                ? eitherType.GetProperty("Left").GetValue(value, null)
                : eitherType.GetProperty("Right").GetValue(value, null);

            writer.WriteStartObject();
            writer.WritePropertyName("isLeft");
            serializer.Serialize(writer, isLeft);
            writer.WritePropertyName("value");
            serializer.Serialize(writer, variantValue);
            writer.WriteEndObject();
        }
    }
}