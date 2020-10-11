using BenchmarkDotNet.Attributes;
using JsonSerializationTests;
using Newtonsoft.Json;

namespace Benchmarks.Polymorphism
{
    public class PolymorphicSerializationBenchmark
    {
        private const string Json = @"
{
  ""$type"": ""JsonSerializationTests.Subclass2, JsonSerializationTests"",
  ""subValue2"": true,
  ""subValue1"": 815,
  ""baseValue"": ""Bar""
}";

        [Benchmark]
        public string JsonNetSerialize() =>
            JsonConvert.SerializeObject(PolymorphismScenario.Instance2, JsonSettings.NewtonsoftJsonPolymorphicSettings);

        [Benchmark]
        public Subclass2 JsonNetDeserialize() =>
            JsonConvert.DeserializeObject<Subclass2>(Json, JsonSettings.NewtonsoftJsonPolymorphicSettings)!;
    }
}