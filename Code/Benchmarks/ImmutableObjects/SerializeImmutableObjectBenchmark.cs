using BenchmarkDotNet.Attributes;
using JsonSerializationTests;
using Newtonsoft.Json;
using SystemTextJsonSerializer = System.Text.Json.JsonSerializer;
using Utf8JsonSerializer = Utf8Json.JsonSerializer;

namespace Benchmarks.ImmutableObjects
{
    public class SerializeImmutableObjectBenchmark
    {
        [Benchmark(Baseline = true)]
        public string JsonNet() => JsonConvert.SerializeObject(SignUpScenario.ImmutableObject, JsonSettings.NewtonsoftJsonSettings);

        [Benchmark]
        public string SystemTextJson() => SystemTextJsonSerializer.Serialize(SignUpScenario.ImmutableObject, JsonSettings.SystemTextJsonOptions);

        [Benchmark]
        public string Utf8Json() => Utf8JsonSerializer.ToJsonString(SignUpScenario.ImmutableObject, JsonSettings.Utf8JsonResolver);
    }
}