using AspNetCoreWebApi.SignUp;
using BenchmarkDotNet.Attributes;
using JsonSerializationTests;
using Newtonsoft.Json;
#if NET5_0
using SystemTextJsonSerializer = System.Text.Json.JsonSerializer;
#endif
using Utf8JsonSerializer = Utf8Json.JsonSerializer;

namespace Benchmarks.ImmutableObjects
{
    public class DeserializeImmutableObjectBenchmark
    {
        [Benchmark(Baseline = true)]
        public ImmutableSignUpDto JsonNet() => JsonConvert.DeserializeObject<ImmutableSignUpDto>(SignUpScenario.Json, JsonSettings.NewtonsoftJsonSettings)!;

#if NET5_0
        [Benchmark]
        public ImmutableSignUpDto SystemTextJson() => SystemTextJsonSerializer.Deserialize<ImmutableSignUpDto>(SignUpScenario.Json, JsonSettings.SystemTextJsonOptions)!;
#endif

        [Benchmark]
        public ImmutableSignUpDto Utf8Json() => Utf8JsonSerializer.Deserialize<ImmutableSignUpDto>(SignUpScenario.Json, JsonSettings.Utf8JsonResolver);
    }
}