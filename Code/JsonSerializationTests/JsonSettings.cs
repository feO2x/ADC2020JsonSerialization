using System.Text.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Utf8Json;
using Utf8Json.Resolvers;

namespace JsonSerializationTests
{
    public static class JsonSettings
    {
        public static readonly JsonSerializerSettings NewtonsoftJsonSettings =
            new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

        public static readonly JsonSerializerOptions SystemTextJsonOptions =
            new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

        public static readonly IJsonFormatterResolver Utf8JsonResolver = StandardResolver.CamelCase;
    }
}