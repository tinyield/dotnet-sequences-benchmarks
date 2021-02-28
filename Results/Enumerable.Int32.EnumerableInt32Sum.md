## Enumerable.Int32.EnumerableInt32Sum

### Source
[EnumerableInt32Sum.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Sum.cs)

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
|               Method | Count |        Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |------------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|          **ForeachLoop** |    **10** |    **85.02 ns** |  **0.681 ns** |  **0.604 ns** |  **1.00** | **0.0126** |     **-** |     **-** |      **40 B** |
|                 Linq |    10 |    85.78 ns |  0.527 ns |  0.467 ns |  1.01 | 0.0126 |     - |     - |      40 B |
|               LinqAF |    10 |   105.64 ns |  0.427 ns |  0.379 ns |  1.24 | 0.0126 |     - |     - |      40 B |
|           StructLinq |    10 |   105.40 ns |  0.486 ns |  0.455 ns |  1.24 | 0.0204 |     - |     - |      64 B |
| StructLinq_IFunction |    10 |    83.66 ns |  0.594 ns |  0.556 ns |  0.98 | 0.0126 |     - |     - |      40 B |
|            Hyperlinq |    10 |    80.07 ns |  1.170 ns |  1.037 ns |  0.94 | 0.0126 |     - |     - |      40 B |
|                      |       |             |           |           |       |        |       |       |           |
|          **ForeachLoop** |  **1000** | **5,510.08 ns** | **22.653 ns** | **18.916 ns** |  **1.00** | **0.0076** |     **-** |     **-** |      **40 B** |
|                 Linq |  1000 | 5,875.12 ns | 30.752 ns | 28.766 ns |  1.07 | 0.0076 |     - |     - |      40 B |
|               LinqAF |  1000 | 6,623.20 ns | 41.898 ns | 39.192 ns |  1.20 | 0.0076 |     - |     - |      40 B |
|           StructLinq |  1000 | 6,599.95 ns | 10.668 ns |  8.329 ns |  1.20 | 0.0153 |     - |     - |      64 B |
| StructLinq_IFunction |  1000 | 5,869.44 ns | 24.035 ns | 21.306 ns |  1.07 | 0.0076 |     - |     - |      40 B |
|            Hyperlinq |  1000 | 5,864.49 ns | 14.812 ns | 13.131 ns |  1.06 | 0.0076 |     - |     - |      40 B |
