``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.508 (2004/?/20H1)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET Core SDK=3.1.402
  [Host]     : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT
  Job-XMRQJV : .NET Core 3.1.8 (CoreCLR 4.700.20.41105, CoreFX 4.700.20.41903), X64 RyuJIT

Runtime=.NET Core 3.1  

```
|   Method |       Mean |    Error |  StdDev | Ratio |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|--------- |-----------:|---------:|--------:|------:|-------:|-------:|------:|----------:|
|  JsonNet | 1,838.2 ns | 11.05 ns | 9.80 ns |  1.00 | 0.6771 | 0.0019 |     - |    3192 B |
| Utf8Json |   469.1 ns |  1.36 ns | 1.27 ns |  0.26 | 0.0644 |      - |     - |     304 B |
