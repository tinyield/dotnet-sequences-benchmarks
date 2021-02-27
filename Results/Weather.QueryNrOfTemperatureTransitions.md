## Weather.QueryNrOfTemperatureTransitions

### Source
[QueryNrOfTemperatureTransitions.cs](../LinqBenchmarks/Weather/QueryNrOfTemperatureTransitions.cs)

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
|      Method | Count |      Mean |     Error |     StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |----------:|----------:|-----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|     **ForLoop** |    **10** |  **3.899 μs** | **0.0665 μs** |  **0.0766 μs** |  **3.897 μs** |  **1.00** |    **0.00** | **1.6518** |     **-** |     **-** |      **5 KB** |
| ForeachLoop |    10 |  3.699 μs | 0.0700 μs |  0.0655 μs |  3.701 μs |  0.94 |    0.02 | 1.6518 |     - |     - |      5 KB |
|        Linq |    10 |  6.865 μs | 0.1296 μs |  0.1212 μs |  6.877 μs |  1.75 |    0.05 | 1.7166 |     - |     - |      5 KB |
|      LinqAF |    10 | 30.102 μs | 4.3529 μs | 12.6977 μs | 24.300 μs |  7.59 |    3.06 |      - |     - |     - |      5 KB |
|   Hyperlinq |    10 |  7.021 μs | 0.1358 μs |  0.1509 μs |  7.070 μs |  1.80 |    0.05 | 1.7090 |     - |     - |      5 KB |
|    Tinyield |    10 |  5.307 μs | 0.0862 μs |  0.0764 μs |  5.309 μs |  1.35 |    0.03 | 2.1667 |     - |     - |      7 KB |
|             |       |           |           |            |           |       |         |        |       |       |           |
|     **ForLoop** |  **1000** |  **3.633 μs** | **0.0406 μs** |  **0.0360 μs** |  **3.643 μs** |  **1.00** |    **0.00** | **1.6518** |     **-** |     **-** |      **5 KB** |
| ForeachLoop |  1000 |  3.702 μs | 0.0736 μs |  0.0788 μs |  3.709 μs |  1.02 |    0.03 | 1.6518 |     - |     - |      5 KB |
|        Linq |  1000 |  6.923 μs | 0.1355 μs |  0.1268 μs |  6.962 μs |  1.91 |    0.04 | 1.7166 |     - |     - |      5 KB |
|      LinqAF |  1000 |  9.679 μs | 0.1411 μs |  0.1320 μs |  9.665 μs |  2.66 |    0.04 | 1.7242 |     - |     - |      5 KB |
|   Hyperlinq |  1000 |  7.015 μs | 0.1377 μs |  0.1639 μs |  6.995 μs |  1.93 |    0.04 | 1.7090 |     - |     - |      5 KB |
|    Tinyield |  1000 |  5.363 μs | 0.0966 μs |  0.1791 μs |  5.339 μs |  1.47 |    0.06 | 2.1667 |     - |     - |      7 KB |
