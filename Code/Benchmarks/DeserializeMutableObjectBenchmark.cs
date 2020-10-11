using AspNetCoreWebApi.SignUp;
using BenchmarkDotNet.Attributes;
using JsonSerializationTests;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace Benchmarks
{
    public class DeserializeMutableObjectBenchmark
    {
        [Benchmark(Baseline = true)]
        public SignUpDto JsonNet() => JsonConvert.DeserializeObject<SignUpDto>(SignUpScenario.Json, JsonSettings.NewtonsoftJsonSettings);

        [Benchmark]
        public SignUpDto SystemTextJson() => JsonSerializer.Deserialize<SignUpDto>(SignUpScenario.Json, JsonSettings.SystemTextJsonOptions);

        [Benchmark]
        public SignUpDto Utf8Json() => global::Utf8Json.JsonSerializer.Deserialize<SignUpDto>(SignUpScenario.Json, JsonSettings.Utf8JsonResolver);
    }
}