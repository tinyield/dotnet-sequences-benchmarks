## Weather.QueryNrOfDistinctTemperatures

### Source
[QueryNrOfDistinctTemperatures.cs](../LinqBenchmarks/Weather/QueryNrOfDistinctTemperatures.cs)

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
|     **ForLoop** |    **10** |  **4.832 μs** | **0.0593 μs** | **0.0555 μs** |  **1.00** |    **0.00** | **1.5564** |     **-** |     **-** |      **5 KB** |
| ForeachLoop |    10 |  4.740 μs | 0.0303 μs | 0.0268 μs |  0.98 |    0.01 | 1.5564 |     - |     - |      5 KB |
|        Linq |    10 |  7.504 μs | 0.0329 μs | 0.0274 μs |  1.55 |    0.02 | 1.4038 |     - |     - |      4 KB |
|      LinqAF |    10 | 10.771 μs | 0.0511 μs | 0.0478 μs |  2.23 |    0.03 | 1.4038 |     - |     - |      4 KB |
|   Hyperlinq |    10 |  7.835 μs | 0.0751 μs | 0.0702 μs |  1.62 |    0.02 | 1.4038 |     - |     - |      4 KB |
|    Tinyield |    10 |  6.024 μs | 0.0474 μs | 0.0443 μs |  1.25 |    0.02 | 1.9073 |     - |     - |      6 KB |
|             |       |           |           |           |       |         |        |       |       |           |
|     **ForLoop** |  **1000** |  **4.814 μs** | **0.0375 μs** | **0.0351 μs** |  **1.00** |    **0.00** | **1.5564** |     **-** |     **-** |      **5 KB** |
| ForeachLoop |  1000 |  4.740 μs | 0.0433 μs | 0.0384 μs |  0.99 |    0.01 | 1.5564 |     - |     - |      5 KB |
|        Linq |  1000 |  7.412 μs | 0.0390 μs | 0.0364 μs |  1.54 |    0.02 | 1.4038 |     - |     - |      4 KB |
|      LinqAF |  1000 | 10.614 μs | 0.0537 μs | 0.0476 μs |  2.21 |    0.01 | 1.4038 |     - |     - |      4 KB |
|   Hyperlinq |  1000 |  7.808 μs | 0.0427 μs | 0.0357 μs |  1.62 |    0.01 | 1.4038 |     - |     - |      4 KB |
|    Tinyield |  1000 |  6.030 μs | 0.0474 μs | 0.0443 μs |  1.25 |    0.02 | 1.9073 |     - |     - |      6 KB |
