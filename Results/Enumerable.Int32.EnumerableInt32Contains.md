## Enumerable.Int32.EnumerableInt32Contains

### Source
[EnumerableInt32Contains.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Contains.cs)

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
|          **ForeachLoop** |    **10** |    **83.90 ns** |  **0.449 ns** |  **0.398 ns** |  **1.00** | **0.0126** |     **-** |     **-** |      **40 B** |
|                 Linq |    10 |    92.39 ns |  0.414 ns |  0.367 ns |  1.10 | 0.0126 |     - |     - |      40 B |
|               LinqAF |    10 |   130.99 ns |  0.871 ns |  0.815 ns |  1.56 | 0.0126 |     - |     - |      40 B |
|           StructLinq |    10 |   101.51 ns |  0.406 ns |  0.339 ns |  1.21 | 0.0204 |     - |     - |      64 B |
| StructLinq_IFunction |    10 |    85.66 ns |  0.268 ns |  0.250 ns |  1.02 | 0.0126 |     - |     - |      40 B |
|            Hyperlinq |    10 |   112.76 ns |  0.642 ns |  0.601 ns |  1.34 | 0.0126 |     - |     - |      40 B |
|                      |       |             |           |           |       |        |       |       |           |
|          **ForeachLoop** |  **1000** | **6,216.76 ns** | **15.609 ns** | **14.601 ns** |  **1.00** | **0.0076** |     **-** |     **-** |      **40 B** |
|                 Linq |  1000 | 5,896.83 ns | 24.665 ns | 21.865 ns |  0.95 | 0.0076 |     - |     - |      40 B |
|               LinqAF |  1000 | 7,726.59 ns | 51.237 ns | 47.928 ns |  1.24 |      - |     - |     - |      40 B |
|           StructLinq |  1000 | 5,891.63 ns | 20.955 ns | 19.602 ns |  0.95 | 0.0153 |     - |     - |      64 B |
| StructLinq_IFunction |  1000 | 5,873.15 ns | 22.886 ns | 21.407 ns |  0.94 | 0.0076 |     - |     - |      40 B |
|            Hyperlinq |  1000 | 7,340.93 ns | 36.995 ns | 34.605 ns |  1.18 | 0.0076 |     - |     - |      40 B |
