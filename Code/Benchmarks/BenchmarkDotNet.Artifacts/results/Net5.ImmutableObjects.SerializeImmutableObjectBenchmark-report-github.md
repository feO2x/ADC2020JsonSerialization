``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=5.0.100-rc.1.20452.10
  [Host]     : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT
  Job-ZMHRXU : .NET Core 5.0.0 (CoreCLR 5.0.20.45114, CoreFX 5.0.20.45114), X64 RyuJIT

Runtime=.NET Core 5.0  

```
|         Method |     Mean |   Error |  StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|--------------- |---------:|--------:|--------:|------:|-------:|-------:|------:|----------:|
|        JsonNet | 821.4 ns | 9.37 ns | 7.82 ns |  1.00 | 0.3242 | 0.0010 |     - |    1528 B |
| SystemTextJson | 420.5 ns | 3.63 ns | 3.40 ns |  0.51 | 0.0782 |      - |     - |     368 B |
|       Utf8Json | 200.0 ns | 1.83 ns | 1.62 ns |  0.24 | 0.0458 |      - |     - |     216 B |
