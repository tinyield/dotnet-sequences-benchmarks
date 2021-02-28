## Array.ValueType.ArrayValueTypeSelectSum

### Source
[ArrayValueTypeSelectSum.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSelectSum.cs)

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
|               Method | Count |          Mean |       Error |      StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |--------------:|------------:|------------:|------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** |    **10** |      **6.195 ns** |   **0.0246 ns** |   **0.0205 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     21.117 ns |   0.0740 ns |   0.0656 ns |  3.41 |    0.02 |      - |     - |     - |         - |
|                 Linq |    10 |    114.943 ns |   0.4821 ns |   0.4274 ns | 18.56 |    0.10 | 0.0100 |     - |     - |      32 B |
|           LinqFaster |    10 |     47.533 ns |   0.3788 ns |   0.3544 ns |  7.68 |    0.07 |      - |     - |     - |         - |
|               LinqAF |    10 |    122.893 ns |   2.4522 ns |   4.4219 ns | 20.27 |    0.60 |      - |     - |     - |         - |
|           StructLinq |    10 |     41.706 ns |   0.3178 ns |   0.2817 ns |  6.73 |    0.06 | 0.0102 |     - |     - |      32 B |
| StructLinq_IFunction |    10 |      9.185 ns |   0.0478 ns |   0.0447 ns |  1.48 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |    10 |    103.261 ns |   0.2623 ns |   0.2325 ns | 16.66 |    0.06 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |     70.857 ns |   0.1806 ns |   0.1601 ns | 11.44 |    0.05 |      - |     - |     - |         - |
|                      |       |               |             |             |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |    **937.823 ns** |   **2.2327 ns** |   **2.0885 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 |  2,827.734 ns |  11.2092 ns |  10.4851 ns |  3.02 |    0.01 |      - |     - |     - |         - |
|                 Linq |  1000 |  8,560.725 ns |  40.8550 ns |  36.2169 ns |  9.13 |    0.04 |      - |     - |     - |      32 B |
|           LinqFaster |  1000 |  5,174.701 ns |  17.1954 ns |  16.0846 ns |  5.52 |    0.02 |      - |     - |     - |         - |
|               LinqAF |  1000 | 10,602.503 ns | 211.7778 ns | 519.4946 ns | 11.17 |    0.43 |      - |     - |     - |         - |
|           StructLinq |  1000 |  2,742.120 ns |   8.0532 ns |   7.5329 ns |  2.92 |    0.01 | 0.0076 |     - |     - |      32 B |
| StructLinq_IFunction |  1000 |  1,012.692 ns |   5.3870 ns |   5.0390 ns |  1.08 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |  6,910.728 ns |  22.8090 ns |  21.3356 ns |  7.37 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 |  5,226.811 ns |  24.7010 ns |  23.1054 ns |  5.57 |    0.02 |      - |     - |     - |         - |
