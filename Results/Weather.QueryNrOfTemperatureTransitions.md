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
|      Method | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|     **ForLoop** |    **10** |  **4.014 μs** | **0.0276 μs** | **0.0244 μs** |  **1.00** |    **0.00** | **1.6479** |     **-** |     **-** |      **5 KB** |
| ForeachLoop |    10 |  4.129 μs | 0.0349 μs | 0.0310 μs |  1.03 |    0.01 | 1.6479 |     - |     - |      5 KB |
|        Linq |    10 |  7.349 μs | 0.0371 μs | 0.0310 μs |  1.83 |    0.01 | 1.7166 |     - |     - |      5 KB |
|      LinqAF |    10 | 10.632 μs | 0.0434 μs | 0.0406 μs |  2.65 |    0.02 | 1.7242 |     - |     - |      5 KB |
|   Hyperlinq |    10 |  9.275 μs | 0.0463 μs | 0.0411 μs |  2.31 |    0.02 | 1.7090 |     - |     - |      5 KB |
|    Tinyield |    10 |  5.827 μs | 0.0407 μs | 0.0381 μs |  1.45 |    0.01 | 2.1667 |     - |     - |      7 KB |
|             |       |           |           |           |       |         |        |       |       |           |
|     **ForLoop** |  **1000** |  **4.009 μs** | **0.0504 μs** | **0.0447 μs** |  **1.00** |    **0.00** | **1.6479** |     **-** |     **-** |      **5 KB** |
| ForeachLoop |  1000 |  4.289 μs | 0.0166 μs | 0.0147 μs |  1.07 |    0.01 | 1.6479 |     - |     - |      5 KB |
|        Linq |  1000 |  7.288 μs | 0.0787 μs | 0.0736 μs |  1.82 |    0.02 | 1.7166 |     - |     - |      5 KB |
|      LinqAF |  1000 | 10.623 μs | 0.0872 μs | 0.0728 μs |  2.65 |    0.03 | 1.7242 |     - |     - |      5 KB |
|   Hyperlinq |  1000 |  9.286 μs | 0.0454 μs | 0.0403 μs |  2.32 |    0.03 | 1.7090 |     - |     - |      5 KB |
|    Tinyield |  1000 |  5.775 μs | 0.0388 μs | 0.0363 μs |  1.44 |    0.02 | 2.1667 |     - |     - |      7 KB |
