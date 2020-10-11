using BenchmarkDotNet.Attributes;
using JsonSerializationTests;
using Newtonsoft.Json;
using SystemTextJsonSerializer = System.Text.Json.JsonSerializer;
using Utf8JsonSerializer = Utf8Json.JsonSerializer;

namespace Benchmarks
{
    public class SerializeMutableObjectBenchmark
    {
        [Benchmark(Baseline = true)]
        public string JsonNet() => JsonConvert.SerializeObject(SignUpScenario.MutableObject, JsonSettings.NewtonsoftJsonSettings);

        [Benchmark]
        public string SystemTextJson() => SystemTextJsonSerializer.Serialize(SignUpScenario.MutableObject, JsonSettings.SystemTextJsonOptions);

        [Benchmark]
        public string Utf8Json() => Utf8JsonSerializer.ToJsonString(SignUpScenario.MutableObject, JsonSettings.Utf8JsonResolver);
    }
}