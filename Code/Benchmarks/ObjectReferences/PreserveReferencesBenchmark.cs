using BenchmarkDotNet.Attributes;
using JsonSerializationTests;
using Newtonsoft.Json;

namespace Benchmarks.ObjectReferences
{
    public class PreserveReferencesBenchmark
    {
        [Benchmark]
        public string JsonNetSerialize() =>
            JsonConvert.SerializeObject(PreserveReferencesScenario.ObjectGraphRoot, JsonSettings.NewtonsoftJsonPreserveReferencesSettings);

        [Benchmark]
        public A JsonNetDeserialize() =>
            JsonConvert.DeserializeObject<A>("{\"$id\":\"1\",\"b\":{\"$id\":\"2\",\"c\":{\"$id\":\"3\"}},\"c\":{\"$ref\":\"3\"}}", JsonSettings.NewtonsoftJsonPreserveReferencesSettings)!;
    }
}