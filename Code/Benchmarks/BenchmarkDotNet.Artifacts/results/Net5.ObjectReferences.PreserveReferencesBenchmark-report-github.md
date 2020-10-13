``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
  Job-ZMHRXU : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT

Runtime=.NET Core 5.0  

```
|             Method |     Mean |     Error |    StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|----------:|----------:|-------:|-------:|------:|----------:|
|   JsonNetSerialize | 1.976 μs | 0.0159 μs | 0.0141 μs | 0.5074 |      - |     - |   2.34 KB |
| JsonNetDeserialize | 2.431 μs | 0.0121 μs | 0.0107 μs | 0.8507 | 0.0076 |     - |   3.91 KB |
