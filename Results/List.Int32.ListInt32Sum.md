## List.Int32.ListInt32Sum

### Source
[ListInt32Sum.cs](../LinqBenchmarks/List/Int32/ListInt32Sum.cs)

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
|               Method | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** |    **10** |    **14.781 ns** |  **0.1708 ns** |  **0.1598 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |    30.383 ns |  0.2016 ns |  0.1788 ns |  2.06 |    0.03 |      - |     - |     - |         - |
|                 Linq |    10 |   118.818 ns |  1.1524 ns |  1.0780 ns |  8.04 |    0.10 | 0.0126 |     - |     - |      40 B |
|           LinqFaster |    10 |    11.700 ns |  0.0657 ns |  0.0614 ns |  0.79 |    0.01 |      - |     - |     - |         - |
|               LinqAF |    10 |    83.433 ns |  0.4256 ns |  0.3981 ns |  5.65 |    0.06 |      - |     - |     - |         - |
|           StructLinq |    10 |    27.431 ns |  0.1780 ns |  0.1578 ns |  1.86 |    0.03 | 0.0102 |     - |     - |      32 B |
| StructLinq_IFunction |    10 |     7.175 ns |  0.0368 ns |  0.0307 ns |  0.49 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |    10 |    22.181 ns |  0.0722 ns |  0.0603 ns |  1.50 |    0.02 |      - |     - |     - |         - |
|                      |       |              |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** | **1,365.845 ns** |  **5.8409 ns** |  **4.8774 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 | 2,612.976 ns | 19.6108 ns | 17.3845 ns |  1.91 |    0.01 |      - |     - |     - |         - |
|                 Linq |  1000 | 8,426.542 ns | 58.5380 ns | 51.8924 ns |  6.17 |    0.05 |      - |     - |     - |      40 B |
|           LinqFaster |  1000 | 1,098.326 ns |  4.1844 ns |  3.7093 ns |  0.80 |    0.00 |      - |     - |     - |         - |
|               LinqAF |  1000 | 5,162.619 ns | 27.1262 ns | 25.3738 ns |  3.78 |    0.03 |      - |     - |     - |         - |
|           StructLinq |  1000 |   952.241 ns |  4.8412 ns |  4.0426 ns |  0.70 |    0.00 | 0.0095 |     - |     - |      32 B |
| StructLinq_IFunction |  1000 |   772.153 ns |  3.3166 ns |  2.9401 ns |  0.56 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |   115.147 ns |  0.4558 ns |  0.4264 ns |  0.08 |    0.00 |      - |     - |     - |         - |
