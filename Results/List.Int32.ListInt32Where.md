## List.Int32.ListInt32Where

### Source
[ListInt32Where.cs](../LinqBenchmarks/List/Int32/ListInt32Where.cs)

### References:
- Cistern.ValueLinq: [0.1.14](https://www.nuget.org/packages/Cistern.ValueLinq/0.1.14)
- JM.LinqFaster: [1.1.2](https://www.nuget.org/packages/JM.LinqFaster/1.1.2)
- LinqFaster.SIMD: [1.1.2](https://www.nuget.org/packages/LinqFaster.SIMD/1.0.3)
- LinqAF: [3.0.0.0](https://www.nuget.org/packages/LinqAF/3.0.0.0)
- StructLinq.BCL: [0.25.3](https://www.nuget.org/packages/StructLinq.BCL/0.25.3)
- NetFabric.Hyperlinq: [3.0.0-beta41](https://www.nuget.org/packages/NetFabric.Hyperlinq/3.0.0-beta41)

### Results:
``` ini

BenchmarkDotNet=v0.12.1.1516-nightly, OS=Windows 10.0.19042.844 (20H2/October2020Update)
Intel Core i7-7700HQ CPU 2.80GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK=5.0.103
  [Host]   : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT  [AttachedDebugger]
  .NET 5.0 : .NET 5.0.3 (5.0.321.7212), X64 RyuJIT

Job=.NET 5.0  Runtime=.NET 5.0  

```
|               Method | Count |         Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** |    **10** |     **14.68 ns** |  **0.099 ns** |  **0.083 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     44.84 ns |  0.227 ns |  0.213 ns |  3.06 |    0.02 |      - |     - |     - |         - |
|                 Linq |    10 |    126.10 ns |  0.583 ns |  0.517 ns |  8.59 |    0.07 | 0.0229 |     - |     - |      72 B |
|           LinqFaster |    10 |     57.09 ns |  0.502 ns |  0.470 ns |  3.89 |    0.04 | 0.0229 |     - |     - |      72 B |
|               LinqAF |    10 |    130.97 ns |  0.997 ns |  0.832 ns |  8.92 |    0.08 |      - |     - |     - |         - |
|           StructLinq |    10 |     56.68 ns |  0.243 ns |  0.227 ns |  3.86 |    0.03 | 0.0102 |     - |     - |      32 B |
| StructLinq_IFunction |    10 |     52.14 ns |  0.101 ns |  0.089 ns |  3.55 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq |    10 |     58.88 ns |  0.262 ns |  0.245 ns |  4.01 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |     53.07 ns |  0.113 ns |  0.100 ns |  3.62 |    0.02 |      - |     - |     - |         - |
|             Tinyield |    10 |    276.66 ns |  1.975 ns |  1.848 ns | 18.85 |    0.15 | 0.1912 |     - |     - |     600 B |
|                      |       |              |           |           |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |  **1,410.92 ns** | **15.164 ns** | **14.185 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 |  4,946.34 ns | 42.112 ns | 39.392 ns |  3.51 |    0.05 |      - |     - |     - |         - |
|                 Linq |  1000 | 13,184.85 ns | 33.583 ns | 31.414 ns |  9.35 |    0.09 | 0.0153 |     - |     - |      72 B |
|           LinqFaster |  1000 |  5,721.19 ns | 41.307 ns | 38.639 ns |  4.06 |    0.04 | 1.3657 |     - |     - |   4,304 B |
|               LinqAF |  1000 | 15,155.05 ns | 43.264 ns | 40.469 ns | 10.74 |    0.10 |      - |     - |     - |         - |
|           StructLinq |  1000 |  8,757.23 ns | 40.809 ns | 38.173 ns |  6.21 |    0.08 |      - |     - |     - |      32 B |
| StructLinq_IFunction |  1000 |  2,084.35 ns | 16.425 ns | 14.560 ns |  1.48 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |  8,031.72 ns | 46.541 ns | 43.534 ns |  5.69 |    0.05 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 |  2,696.36 ns | 20.650 ns | 19.316 ns |  1.91 |    0.02 |      - |     - |     - |         - |
|             Tinyield |  1000 | 17,921.61 ns | 95.625 ns | 84.769 ns | 12.71 |    0.17 | 0.1831 |     - |     - |     600 B |
