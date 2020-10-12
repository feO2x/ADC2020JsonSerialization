using System.Text.Json;
using FluentAssertions;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;
using SystemTextJsonSerializer = System.Text.Json.JsonSerializer;
using Utf8JsonSerializer = Utf8Json.JsonSerializer;

namespace JsonSerializationTests.ObjectReferences
{
    public sealed class PreserveObjectReferencesTests
    {
        private readonly ITestOutputHelper _output;

        public PreserveObjectReferencesTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void JsonNet()
        {
            var json = JsonConvert.SerializeObject(PreserveReferencesScenario.ObjectGraphRoot, JsonSettings.NewtonsoftJsonPreserveReferencesSettings);

            _output.WriteLine(json);

            var deserializedGraph = JsonConvert.DeserializeObject<A>(json, JsonSettings.NewtonsoftJsonPreserveReferencesSettings);

            deserializedGraph!.C.Should().BeSameAs(deserializedGraph.B.C);
        }

        [Fact]
        public void SystemTextJson()
        {
            var options = new JsonSerializerOptions{ PropertyNamingPolicy = JsonNamingPolicy.CamelCase, WriteIndented = true};
            var json = SystemTextJsonSerializer.Serialize(PreserveReferencesScenario.ObjectGraphRoot, options);

            _output.WriteLine(json);

            var deserializedGraph = SystemTextJsonSerializer.Deserialize<A>(json, options);

            deserializedGraph!.C.Should().BeSameAs(deserializedGraph.B.C);
        }

        [Fact]
        public void Utf8Json()
        {
            var json = Utf8JsonSerializer.ToJsonString(PreserveReferencesScenario.ObjectGraphRoot, JsonSettings.Utf8JsonResolver);

            _output.WriteLine(json);

            var deserializedGraph = Utf8JsonSerializer.Deserialize<A>(json, JsonSettings.Utf8JsonResolver);

            deserializedGraph.C.Should().BeSameAs(deserializedGraph.B.C);
        }
    }
}