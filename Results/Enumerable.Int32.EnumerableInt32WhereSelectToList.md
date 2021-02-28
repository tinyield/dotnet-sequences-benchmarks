## Enumerable.Int32.EnumerableInt32WhereSelectToList

### Source
[EnumerableInt32WhereSelectToList.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelectToList.cs)

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
|                                Method | Count |        Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |------------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                    **ValueLinq_Standard** |    **10** |    **325.7 ns** |  **3.48 ns** |  **3.08 ns** |  **2.35** |    **0.02** | **0.0529** |     **-** |     **-** |     **168 B** |
|                       ValueLinq_Stack |    10 |    337.5 ns |  4.03 ns |  3.57 ns |  2.43 |    0.04 | 0.0377 |     - |     - |     120 B |
|             ValueLinq_SharedPool_Push |    10 |    649.9 ns |  1.43 ns |  1.27 ns |  4.68 |    0.03 | 0.0381 |     - |     - |     120 B |
|             ValueLinq_SharedPool_Pull |    10 |    539.1 ns |  2.62 ns |  2.33 ns |  3.88 |    0.02 | 0.0381 |     - |     - |     120 B |
|        ValueLinq_ValueLambda_Standard |    10 |    301.6 ns |  2.45 ns |  2.17 ns |  2.17 |    0.02 | 0.0529 |     - |     - |     168 B |
|           ValueLinq_ValueLambda_Stack |    10 |    285.6 ns |  3.27 ns |  3.06 ns |  2.06 |    0.02 | 0.0377 |     - |     - |     120 B |
| ValueLinq_ValueLambda_SharedPool_Push |    10 |    523.3 ns |  3.31 ns |  2.76 ns |  3.77 |    0.03 | 0.0381 |     - |     - |     120 B |
| ValueLinq_ValueLambda_SharedPool_Pull |    10 |    464.1 ns |  1.66 ns |  1.47 ns |  3.34 |    0.02 | 0.0381 |     - |     - |     120 B |
|                           ForeachLoop |    10 |    138.9 ns |  0.82 ns |  0.68 ns |  1.00 |    0.00 | 0.0534 |     - |     - |     168 B |
|                                  Linq |    10 |    254.2 ns |  2.40 ns |  2.12 ns |  1.83 |    0.02 | 0.0916 |     - |     - |     288 B |
|                                LinqAF |    10 |    283.6 ns |  1.26 ns |  1.17 ns |  2.04 |    0.01 | 0.0534 |     - |     - |     168 B |
|                            StructLinq |    10 |    311.0 ns |  3.08 ns |  2.73 ns |  2.24 |    0.03 | 0.0663 |     - |     - |     208 B |
|                  StructLinq_IFunction |    10 |    220.1 ns |  0.70 ns |  0.62 ns |  1.59 |    0.01 | 0.0381 |     - |     - |     120 B |
|                             Hyperlinq |    10 |    256.2 ns |  2.34 ns |  2.19 ns |  1.85 |    0.02 | 0.0381 |     - |     - |     120 B |
|                   Hyperlinq_IFunction |    10 |    206.0 ns |  1.49 ns |  1.32 ns |  1.48 |    0.01 | 0.0381 |     - |     - |     120 B |
|                              Tinyield |    10 |    414.1 ns |  2.63 ns |  2.46 ns |  2.98 |    0.03 | 0.3157 |     - |     - |     992 B |
|                                       |       |             |          |          |       |         |        |       |       |           |
|                    **ValueLinq_Standard** |  **1000** | **11,504.6 ns** | **86.11 ns** | **80.54 ns** |  **1.42** |    **0.01** | **1.3733** |     **-** |     **-** |   **4,344 B** |
|                       ValueLinq_Stack |  1000 | 10,970.0 ns | 56.50 ns | 52.85 ns |  1.35 |    0.01 | 1.3275 |     - |     - |   4,200 B |
|             ValueLinq_SharedPool_Push |  1000 | 11,757.5 ns | 53.06 ns | 49.63 ns |  1.45 |    0.01 | 0.6561 |     - |     - |   2,096 B |
|             ValueLinq_SharedPool_Pull |  1000 | 11,164.4 ns | 44.59 ns | 39.53 ns |  1.38 |    0.01 | 0.6561 |     - |     - |   2,096 B |
|        ValueLinq_ValueLambda_Standard |  1000 |  7,336.1 ns | 36.80 ns | 32.62 ns |  0.90 |    0.01 | 1.3809 |     - |     - |   4,344 B |
|           ValueLinq_ValueLambda_Stack |  1000 |  8,845.7 ns | 43.66 ns | 38.71 ns |  1.09 |    0.01 | 1.3275 |     - |     - |   4,200 B |
| ValueLinq_ValueLambda_SharedPool_Push |  1000 |  8,508.4 ns | 31.63 ns | 26.41 ns |  1.05 |    0.00 | 0.6561 |     - |     - |   2,096 B |
| ValueLinq_ValueLambda_SharedPool_Pull |  1000 |  8,424.8 ns | 24.63 ns | 20.57 ns |  1.04 |    0.00 | 0.6561 |     - |     - |   2,096 B |
|                           ForeachLoop |  1000 |  8,111.3 ns | 28.70 ns | 26.84 ns |  1.00 |    0.00 | 1.3733 |     - |     - |   4,344 B |
|                                  Linq |  1000 | 10,572.9 ns | 43.56 ns | 40.74 ns |  1.30 |    0.01 | 1.4191 |     - |     - |   4,464 B |
|                                LinqAF |  1000 | 13,026.5 ns | 43.93 ns | 41.10 ns |  1.61 |    0.01 | 1.3733 |     - |     - |   4,344 B |
|                            StructLinq |  1000 | 11,511.0 ns | 43.48 ns | 36.31 ns |  1.42 |    0.01 | 0.6866 |     - |     - |   2,184 B |
|                  StructLinq_IFunction |  1000 |  7,623.0 ns | 52.44 ns | 49.05 ns |  0.94 |    0.01 | 0.6561 |     - |     - |   2,096 B |
|                             Hyperlinq |  1000 | 10,991.6 ns | 89.74 ns | 83.94 ns |  1.36 |    0.01 | 0.6561 |     - |     - |   2,096 B |
|                   Hyperlinq_IFunction |  1000 |  7,875.7 ns | 55.80 ns | 52.19 ns |  0.97 |    0.01 | 0.6561 |     - |     - |   2,096 B |
|                              Tinyield |  1000 | 14,407.9 ns | 56.44 ns | 50.03 ns |  1.78 |    0.01 | 1.6327 |     - |     - |   5,168 B |
