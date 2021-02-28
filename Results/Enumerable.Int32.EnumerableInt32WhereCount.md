## Enumerable.Int32.EnumerableInt32WhereCount

### Source
[EnumerableInt32WhereCount.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereCount.cs)

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
|          **ForeachLoop** |    **10** |     **87.19 ns** |  **0.607 ns** |  **0.568 ns** |  **1.00** |    **0.00** | **0.0126** |     **-** |     **-** |      **40 B** |
|                 Linq |    10 |    125.23 ns |  0.673 ns |  0.597 ns |  1.44 |    0.01 | 0.0126 |     - |     - |      40 B |
|               LinqAF |    10 |    139.22 ns |  0.635 ns |  0.530 ns |  1.60 |    0.01 | 0.0126 |     - |     - |      40 B |
|           StructLinq |    10 |    165.34 ns |  1.358 ns |  1.271 ns |  1.90 |    0.02 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction |    10 |     98.97 ns |  0.337 ns |  0.299 ns |  1.13 |    0.01 | 0.0126 |     - |     - |      40 B |
|            Hyperlinq |    10 |    121.38 ns |  0.970 ns |  0.907 ns |  1.39 |    0.01 | 0.0126 |     - |     - |      40 B |
|  Hyperlinq_IFunction |    10 |     85.69 ns |  0.537 ns |  0.502 ns |  0.98 |    0.01 | 0.0126 |     - |     - |      40 B |
|             Tinyield |    10 |    262.41 ns |  1.168 ns |  0.912 ns |  3.01 |    0.02 | 0.1912 |     - |     - |     600 B |
|                      |       |              |           |           |       |         |        |       |       |           |
|          **ForeachLoop** |  **1000** |  **6,712.56 ns** | **17.033 ns** | **15.100 ns** |  **1.00** |    **0.00** | **0.0076** |     **-** |     **-** |      **40 B** |
|                 Linq |  1000 |  8,158.32 ns | 50.073 ns | 44.388 ns |  1.22 |    0.01 |      - |     - |     - |      40 B |
|               LinqAF |  1000 |  9,158.66 ns | 37.770 ns | 31.540 ns |  1.36 |    0.01 |      - |     - |     - |      40 B |
|           StructLinq |  1000 |  8,612.79 ns | 92.621 ns | 86.637 ns |  1.28 |    0.01 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction |  1000 |  6,335.33 ns | 32.904 ns | 30.779 ns |  0.94 |    0.01 | 0.0076 |     - |     - |      40 B |
|            Hyperlinq |  1000 |  8,651.76 ns | 84.021 ns | 78.594 ns |  1.29 |    0.01 |      - |     - |     - |      40 B |
|  Hyperlinq_IFunction |  1000 |  6,225.02 ns | 15.692 ns | 12.251 ns |  0.93 |    0.00 | 0.0076 |     - |     - |      40 B |
|             Tinyield |  1000 | 12,009.06 ns | 55.806 ns | 52.201 ns |  1.79 |    0.01 | 0.1831 |     - |     - |     600 B |
