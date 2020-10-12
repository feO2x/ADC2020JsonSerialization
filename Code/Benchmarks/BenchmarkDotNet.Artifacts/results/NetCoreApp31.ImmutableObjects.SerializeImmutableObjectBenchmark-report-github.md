``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-XMRQJV : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|         Method |     Mean |   Error |  StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|--------------- |---------:|--------:|--------:|------:|-------:|-------:|------:|----------:|
|        JsonNet | 943.2 ns | 4.85 ns | 4.30 ns |  1.00 | 0.3242 | 0.0010 |     - |    1528 B |
| SystemTextJson | 518.1 ns | 5.08 ns | 4.50 ns |  0.55 | 0.0782 |      - |     - |     368 B |
|       Utf8Json | 203.8 ns | 0.71 ns | 0.63 ns |  0.22 | 0.0458 |      - |     - |     216 B |
