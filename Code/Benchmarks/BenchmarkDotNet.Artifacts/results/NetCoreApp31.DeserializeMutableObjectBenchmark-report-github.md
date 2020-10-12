``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-SJIGTA : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|         Method |       Mean |    Error |   StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------- |-----------:|---------:|---------:|------:|-------:|------:|------:|----------:|
|        JsonNet | 1,620.8 ns | 31.85 ns | 37.91 ns |  1.00 | 0.5932 |     - |     - |    2792 B |
| SystemTextJson |   750.6 ns |  4.71 ns |  4.41 ns |  0.46 | 0.0391 |     - |     - |     184 B |
|       Utf8Json |   463.5 ns |  1.91 ns |  1.70 ns |  0.28 | 0.0644 |     - |     - |     304 B |
