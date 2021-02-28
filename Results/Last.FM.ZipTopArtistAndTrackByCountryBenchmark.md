## Last.FM.ZipTopArtistAndTrackByCountryBenchmark

### Source
[ZipTopArtistAndTrackByCountryBenchmark.cs](../LinqBenchmarks/Last/FM/ZipTopArtistAndTrackByCountryBenchmark.cs)

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
|      Method | Count |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |    Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |----------:|----------:|----------:|----------:|------:|--------:|---------:|------:|------:|----------:|
| **ForeachLoop** |    **10** |  **82.34 μs** |  **0.485 μs** |  **0.430 μs** |  **82.33 μs** |  **1.00** |    **0.00** |   **7.6904** |     **-** |     **-** |     **24 KB** |
|        Linq |    10 | 131.75 μs |  1.773 μs |  1.658 μs | 131.22 μs |  1.60 |    0.02 |  12.6953 |     - |     - |     39 KB |
|      LinqAF |    10 | 385.78 μs | 20.754 μs | 59.548 μs | 364.70 μs |  5.63 |    0.48 |        - |     - |     - |    197 KB |
|   Hyperlinq |    10 |  99.47 μs |  1.546 μs |  1.371 μs |  98.81 μs |  1.21 |    0.02 |   5.7373 |     - |     - |     18 KB |
|    Tinyield |    10 | 244.38 μs |  1.487 μs |  1.318 μs | 244.15 μs |  2.97 |    0.02 | 187.5000 |     - |     - |    575 KB |
|             |       |           |           |           |           |       |         |          |       |       |           |
| **ForeachLoop** |  **1000** |  **74.53 μs** |  **0.785 μs** |  **0.734 μs** |  **74.36 μs** |  **1.00** |    **0.00** |   **7.6904** |     **-** |     **-** |     **24 KB** |
|        Linq |  1000 | 132.20 μs |  0.868 μs |  0.770 μs | 132.31 μs |  1.78 |    0.02 |  12.6953 |     - |     - |     39 KB |
|      LinqAF |  1000 | 376.51 μs | 15.894 μs | 45.602 μs | 360.00 μs |  5.94 |    0.19 |        - |     - |     - |    197 KB |
|   Hyperlinq |  1000 |  98.94 μs |  1.096 μs |  1.025 μs |  98.59 μs |  1.33 |    0.02 |   5.7373 |     - |     - |     18 KB |
|    Tinyield |  1000 | 244.01 μs |  1.579 μs |  1.319 μs | 244.38 μs |  3.28 |    0.04 | 187.5000 |     - |     - |    575 KB |
