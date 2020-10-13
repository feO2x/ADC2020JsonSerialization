``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
  Job-ZMHRXU : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT

Runtime=.NET Core 5.0  

```
|             Method |     Mean |     Error |    StdDev |   Median |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|------------------- |---------:|----------:|----------:|---------:|-------:|-------:|------:|----------:|
|   JsonNetSerialize | 1.505 μs | 0.0042 μs | 0.0039 μs | 1.505 μs | 0.5760 | 0.0019 |     - |   2.65 KB |
| JsonNetDeserialize | 1.871 μs | 0.0372 μs | 0.0631 μs | 1.839 μs | 0.6409 | 0.0057 |     - |   2.95 KB |
