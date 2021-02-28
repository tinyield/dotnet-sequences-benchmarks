## Last.FM.ArtistsInTopTenWithTopTenTracksByCountryBenchmark

### Source
[ArtistsInTopTenWithTopTenTracksByCountryBenchmark.cs](../LinqBenchmarks/Last/FM/ArtistsInTopTenWithTopTenTracksByCountryBenchmark.cs)

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
|      Method | Count |     Mean |    Error |   StdDev | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |---------:|---------:|---------:|------:|--------:|---------:|------:|------:|----------:|
| **ForeachLoop** |    **10** | **223.0 μs** |  **1.24 μs** |  **1.16 μs** |  **1.00** |    **0.00** |  **25.6348** |     **-** |     **-** |     **79 KB** |
|        Linq |    10 | 330.3 μs |  1.82 μs |  1.42 μs |  1.48 |    0.01 |  35.1563 |     - |     - |    109 KB |
|      LinqAF |    10 | 559.1 μs |  5.57 μs |  5.21 μs |  2.51 |    0.02 |  85.9375 |     - |     - |    264 KB |
|   Hyperlinq |    10 | 295.7 μs |  3.92 μs |  3.67 μs |  1.33 |    0.02 |  19.5313 |     - |     - |     61 KB |
|    Tinyield |    10 | 510.5 μs |  7.56 μs |  7.07 μs |  2.29 |    0.03 | 247.0703 |     - |     - |    758 KB |
|             |       |          |          |          |       |         |          |       |       |           |
| **ForeachLoop** |  **1000** | **218.4 μs** |  **1.96 μs** |  **1.83 μs** |  **1.00** |    **0.00** |  **25.6348** |     **-** |     **-** |     **79 KB** |
|        Linq |  1000 | 330.4 μs |  2.27 μs |  2.01 μs |  1.51 |    0.01 |  35.1563 |     - |     - |    109 KB |
|      LinqAF |  1000 | 558.4 μs |  5.81 μs |  5.44 μs |  2.56 |    0.03 |  85.9375 |     - |     - |    264 KB |
|   Hyperlinq |  1000 | 303.4 μs |  3.83 μs |  3.59 μs |  1.39 |    0.01 |  19.5313 |     - |     - |     61 KB |
|    Tinyield |  1000 | 516.2 μs | 10.29 μs | 10.57 μs |  2.37 |    0.06 | 247.0703 |     - |     - |    758 KB |
