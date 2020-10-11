using AspNetCoreWebApi.SignUp;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;
using SystemTextJsonSerializer = System.Text.Json.JsonSerializer;
using Utf8JsonSerializer = Utf8Json.JsonSerializer;

namespace JsonSerializationTests.ImmutableObjects
{
    public static class ImmutableObjectDeserializationTests
    {
        [Fact]
        public static void JsonNet()
        {
            var deserializedObject = JsonConvert.DeserializeObject<ImmutableSignUpDto>(SignUpScenario.Json, JsonSettings.NewtonsoftJsonSettings);

            deserializedObject.Should().BeEquivalentTo(SignUpScenario.MutableObject);
        }

        [Fact]
        public static void SystemTextJson()
        {
            var deserializedObject = SystemTextJsonSerializer.Deserialize<ImmutableSignUpDto>(SignUpScenario.Json, JsonSettings.SystemTextJsonOptions);

            deserializedObject.Should().BeEquivalentTo(SignUpScenario.MutableObject);
        }

        [Fact]
        public static void Utf8Json()
        {
            var deserializedObject = Utf8JsonSerializer.Deserialize<ImmutableSignUpDto>(SignUpScenario.Json, JsonSettings.Utf8JsonResolver);

            deserializedObject.Should().BeEquivalentTo(SignUpScenario.MutableObject);
        }
    }
}