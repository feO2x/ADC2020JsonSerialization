``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
  Job-UCZCDJ : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT

Runtime=.NET Core 5.0  

```
|         Method |       Mean |   Error |  StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|--------------- |-----------:|--------:|--------:|------:|-------:|-------:|------:|----------:|
|        JsonNet | 1,612.9 ns | 7.90 ns | 7.39 ns |  1.00 | 0.6771 | 0.0019 |     - |    3192 B |
| SystemTextJson |   786.8 ns | 4.30 ns | 4.02 ns |  0.49 | 0.0830 |      - |     - |     392 B |
|       Utf8Json |   442.3 ns | 7.55 ns | 6.70 ns |  0.27 | 0.0644 |      - |     - |     304 B |
