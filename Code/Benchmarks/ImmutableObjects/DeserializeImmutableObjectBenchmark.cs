using AspNetCoreWebApi.SignUp;
using BenchmarkDotNet.Attributes;
using JsonSerializationTests;
using Newtonsoft.Json;
using Utf8JsonSerializer = Utf8Json.JsonSerializer;

namespace Benchmarks.ImmutableObjects
{
    public class DeserializeImmutableObjectBenchmark
    {
        [Benchmark(Baseline = true)]
        public ImmutableSignUpDto JsonNet() => JsonConvert.DeserializeObject<ImmutableSignUpDto>(SignUpScenario.Json, JsonSettings.NewtonsoftJsonSettings);

        [Benchmark]
        public ImmutableSignUpDto Utf8Json() => Utf8JsonSerializer.Deserialize<ImmutableSignUpDto>(SignUpScenario.Json, JsonSettings.Utf8JsonResolver);
    }
}