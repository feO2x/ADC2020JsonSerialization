``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-FJAVLD : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|             Method |     Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|----------:|----------:|-------:|-------:|------:|----------:|
|   JsonNetSerialize | 1.638 μs | 0.0266 μs | 0.0249 μs | 0.5760 | 0.0019 |     - |   2.65 KB |
| JsonNetDeserialize | 2.055 μs | 0.0101 μs | 0.0090 μs | 0.6409 | 0.0038 |     - |   2.95 KB |
