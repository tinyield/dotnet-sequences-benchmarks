## Weather.QueryMaxTemp

### Source
[QueryMaxTemp.cs](../LinqBenchmarks/Weather/QueryMaxTemp.cs)

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
|      Method | Count |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|     **ForLoop** |    **10** |  **3.600 μs** | **0.0238 μs** | **0.0223 μs** |  **3.597 μs** |  **1.00** |    **0.00** | **1.1406** |     **-** |     **-** |      **4 KB** |
| ForeachLoop |    10 |  3.708 μs | 0.0279 μs | 0.0261 μs |  3.708 μs |  1.03 |    0.01 | 1.1406 |     - |     - |      4 KB |
|        Linq |    10 |  6.728 μs | 0.0449 μs | 0.0420 μs |  6.725 μs |  1.87 |    0.01 | 1.2207 |     - |     - |      4 KB |
|      LinqAF |    10 | 24.547 μs | 2.5762 μs | 7.2239 μs | 20.900 μs |  6.56 |    1.65 |      - |     - |     - |      4 KB |
|   Hyperlinq |    10 |  6.843 μs | 0.0460 μs | 0.0431 μs |  6.829 μs |  1.90 |    0.02 | 1.2207 |     - |     - |      4 KB |
|    Tinyield |    10 |  5.065 μs | 0.0253 μs | 0.0211 μs |  5.062 μs |  1.41 |    0.01 | 1.6022 |     - |     - |      5 KB |
|             |       |           |           |           |           |       |         |        |       |       |           |
|     **ForLoop** |  **1000** |  **3.587 μs** | **0.0171 μs** | **0.0143 μs** |  **3.589 μs** |  **1.00** |    **0.00** | **1.1406** |     **-** |     **-** |      **4 KB** |
| ForeachLoop |  1000 |  3.702 μs | 0.0267 μs | 0.0250 μs |  3.700 μs |  1.03 |    0.01 | 1.1406 |     - |     - |      4 KB |
|        Linq |  1000 |  6.757 μs | 0.0567 μs | 0.0531 μs |  6.749 μs |  1.88 |    0.02 | 1.2207 |     - |     - |      4 KB |
|      LinqAF |  1000 |  9.784 μs | 0.1017 μs | 0.0849 μs |  9.762 μs |  2.73 |    0.03 | 1.2207 |     - |     - |      4 KB |
|   Hyperlinq |  1000 |  6.989 μs | 0.0431 μs | 0.0403 μs |  6.975 μs |  1.95 |    0.02 | 1.2207 |     - |     - |      4 KB |
|    Tinyield |  1000 |  5.092 μs | 0.0380 μs | 0.0337 μs |  5.101 μs |  1.42 |    0.01 | 1.6022 |     - |     - |      5 KB |
