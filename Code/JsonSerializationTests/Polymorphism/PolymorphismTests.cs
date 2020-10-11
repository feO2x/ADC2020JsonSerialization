using System.Text.Json;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;
using SystemTextJsonSerializer = System.Text.Json.JsonSerializer;
using Utf8JsonSerializer = Utf8Json.JsonSerializer;

namespace JsonSerializationTests.Polymorphism
{
    public sealed class PolymorphismTests
    {
        private readonly ITestOutputHelper _output;

        public PolymorphismTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void JsonNet()
        {
            var json = JsonConvert.SerializeObject(PolymorphismScenario.Instance2, JsonSettings.NewtonsoftJsonPolymorphicSettings);

            _output.WriteLine(json);

            var deserializedObject = JsonConvert.DeserializeObject<BaseClass>(json, JsonSettings.NewtonsoftJsonPolymorphicSettings);

            deserializedObject.Should().BeOfType<Subclass2>();
        }

        [Fact]
        public void SystemTextJson()
        {
            var options = new JsonSerializerOptions{ PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true};
            var json = SystemTextJsonSerializer.Serialize(PolymorphismScenario.Instance2, options);

            _output.WriteLine(json);

            var deserializedObject = SystemTextJsonSerializer.Deserialize<BaseClass>(json, options);

            deserializedObject.Should().BeOfType<Subclass2>();
        }

        [Fact]
        public void Utf8Json()
        {
            var json = Utf8JsonSerializer.ToJsonString(PolymorphismScenario.Instance2, JsonSettings.Utf8JsonResolver);

            _output.WriteLine(json);

            var deserializedObject = Utf8JsonSerializer.Deserialize<BaseClass>(json, JsonSettings.Utf8JsonResolver);

            deserializedObject.Should().BeOfType<Subclass2>();
        }
    }
}