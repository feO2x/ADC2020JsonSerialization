using FluentAssertions;
using Newtonsoft.Json;
using Xunit;
using SystemTextJsonSerializer = System.Text.Json.JsonSerializer;
using Utf8JsonSerializer = Utf8Json.JsonSerializer;

namespace JsonSerializationTests.ImmutableObjects
{
    public static class ImmutableObjectSerializationTests
    {
        [Fact]
        public static void JsonNet()
        {
            var json = JsonConvert.SerializeObject(SignUpScenario.ImmutableObject, JsonSettings.NewtonsoftJsonSettings);

            json.Should().Be(SignUpScenario.Json);
        }

        [Fact]
        public static void SystemTextJson()
        {
            var json = SystemTextJsonSerializer.Serialize(SignUpScenario.ImmutableObject, JsonSettings.SystemTextJsonOptions);

            json.Should().Be(SignUpScenario.Json);
        }

        [Fact]
        public static void Utf8Json()
        {
            var json = Utf8JsonSerializer.ToJsonString(SignUpScenario.ImmutableObject, JsonSettings.Utf8JsonResolver);

            json.Should().Be(SignUpScenario.Json);
        }
    }
}