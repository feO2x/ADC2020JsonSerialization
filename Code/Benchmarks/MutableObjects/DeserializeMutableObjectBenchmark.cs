using AspNetCoreWebApi.SignUp;
using BenchmarkDotNet.Attributes;
using JsonSerializationTests;
using Newtonsoft.Json;
using SystemTextJsonSerializer = System.Text.Json.JsonSerializer;
using Utf8JsonSerializer = Utf8Json.JsonSerializer;

namespace Benchmarks.MutableObjects
{
    public class DeserializeMutableObjectBenchmark
    {
        [Benchmark(Baseline = true)]
        public SignUpDto JsonNet() => JsonConvert.DeserializeObject<SignUpDto>(SignUpScenario.Json, JsonSettings.NewtonsoftJsonSettings)!;

        [Benchmark]
        public SignUpDto SystemTextJson() => SystemTextJsonSerializer.Deserialize<SignUpDto>(SignUpScenario.Json, JsonSettings.SystemTextJsonOptions);

        [Benchmark]
        public SignUpDto Utf8Json() => Utf8JsonSerializer.Deserialize<SignUpDto>(SignUpScenario.Json, JsonSettings.Utf8JsonResolver);
    }
}