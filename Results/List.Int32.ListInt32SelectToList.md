## List.Int32.ListInt32SelectToList

### Source
[ListInt32SelectToList.cs](../LinqBenchmarks/List/Int32/ListInt32SelectToList.cs)

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
|                   Method | Count |         Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |------ |-------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                  **ForLoop** |    **10** |     **94.55 ns** |  **0.783 ns** |  **0.733 ns** |  **1.00** |    **0.00** | **0.0688** |     **-** |     **-** |     **216 B** |
|              ForeachLoop |    10 |    114.70 ns |  0.925 ns |  0.866 ns |  1.21 |    0.01 | 0.0688 |     - |     - |     216 B |
|                     Linq |    10 |    106.40 ns |  0.899 ns |  0.797 ns |  1.13 |    0.01 | 0.0534 |     - |     - |     168 B |
|               LinqFaster |    10 |     81.61 ns |  0.780 ns |  0.692 ns |  0.86 |    0.01 | 0.0612 |     - |     - |     192 B |
|                   LinqAF |    10 |    269.76 ns |  1.406 ns |  1.174 ns |  2.85 |    0.03 | 0.0687 |     - |     - |     216 B |
|               StructLinq |    10 |     87.49 ns |  0.448 ns |  0.397 ns |  0.93 |    0.01 | 0.0509 |     - |     - |     160 B |
|     StructLinq_IFunction |    10 |     63.91 ns |  0.471 ns |  0.394 ns |  0.68 |    0.01 | 0.0433 |     - |     - |     136 B |
|                Hyperlinq |    10 |     65.73 ns |  0.601 ns |  0.562 ns |  0.70 |    0.01 | 0.0305 |     - |     - |      96 B |
|      Hyperlinq_IFunction |    10 |     51.38 ns |  0.318 ns |  0.298 ns |  0.54 |    0.01 | 0.0306 |     - |     - |      96 B |
|           Hyperlinq_SIMD |    10 |     92.51 ns |  0.617 ns |  0.577 ns |  0.98 |    0.01 | 0.0305 |     - |     - |      96 B |
| Hyperlinq_IFunction_SIMD |    10 |     65.73 ns |  0.560 ns |  0.524 ns |  0.70 |    0.01 | 0.0305 |     - |     - |      96 B |
|                          |       |              |           |           |       |         |        |       |       |           |
|                  **ForLoop** |  **1000** |  **3,326.07 ns** | **26.159 ns** | **24.469 ns** |  **1.00** |    **0.00** | **2.6817** |     **-** |     **-** |   **8,424 B** |
|              ForeachLoop |  1000 |  4,846.62 ns | 44.697 ns | 41.809 ns |  1.46 |    0.02 | 2.6779 |     - |     - |   8,424 B |
|                     Linq |  1000 |  3,669.28 ns | 18.229 ns | 15.222 ns |  1.10 |    0.01 | 1.3123 |     - |     - |   4,128 B |
|               LinqFaster |  1000 |  4,269.93 ns | 42.230 ns | 39.502 ns |  1.28 |    0.02 | 2.5787 |     - |     - |   8,112 B |
|                   LinqAF |  1000 | 10,898.56 ns | 31.825 ns | 29.770 ns |  3.28 |    0.02 | 2.6703 |     - |     - |   8,424 B |
|               StructLinq |  1000 |  3,407.54 ns | 22.845 ns | 21.369 ns |  1.02 |    0.01 | 1.3123 |     - |     - |   4,120 B |
|     StructLinq_IFunction |  1000 |  1,436.45 ns |  8.496 ns |  7.531 ns |  0.43 |    0.00 | 1.3046 |     - |     - |   4,096 B |
|                Hyperlinq |  1000 |  2,625.32 ns | 12.133 ns | 10.756 ns |  0.79 |    0.01 | 1.2894 |     - |     - |   4,056 B |
|      Hyperlinq_IFunction |  1000 |  1,254.39 ns |  9.055 ns |  8.027 ns |  0.38 |    0.00 | 1.2894 |     - |     - |   4,056 B |
|           Hyperlinq_SIMD |  1000 |    882.77 ns |  4.385 ns |  3.887 ns |  0.27 |    0.00 | 1.2903 |     - |     - |   4,056 B |
| Hyperlinq_IFunction_SIMD |  1000 |    554.10 ns |  3.230 ns |  2.697 ns |  0.17 |    0.00 | 1.2903 |     - |     - |   4,056 B |
