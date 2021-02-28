## Array.Int32.ArrayInt32WhereSelectToList

### Source
[ArrayInt32WhereSelectToList.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelectToList.cs)

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
|                                Method | Count |         Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |-------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                    **ValueLinq_Standard** |    **10** |    **267.70 ns** |  **1.533 ns** |  **1.359 ns** |  **7.56** |    **0.12** | **0.0200** |     **-** |     **-** |      **64 B** |
|                       ValueLinq_Stack |    10 |    218.29 ns |  1.469 ns |  1.374 ns |  6.16 |    0.11 | 0.0203 |     - |     - |      64 B |
|             ValueLinq_SharedPool_Push |    10 |    496.61 ns |  3.374 ns |  3.156 ns | 14.03 |    0.22 | 0.0200 |     - |     - |      64 B |
|             ValueLinq_SharedPool_Pull |    10 |    365.17 ns |  3.963 ns |  3.309 ns | 10.30 |    0.18 | 0.0200 |     - |     - |      64 B |
|        ValueLinq_ValueLambda_Standard |    10 |    237.17 ns |  1.639 ns |  1.368 ns |  6.69 |    0.13 | 0.0200 |     - |     - |      64 B |
|           ValueLinq_ValueLambda_Stack |    10 |    186.74 ns |  1.188 ns |  1.111 ns |  5.27 |    0.08 | 0.0203 |     - |     - |      64 B |
| ValueLinq_ValueLambda_SharedPool_Push |    10 |    398.62 ns |  2.273 ns |  2.015 ns | 11.25 |    0.18 | 0.0200 |     - |     - |      64 B |
| ValueLinq_ValueLambda_SharedPool_Pull |    10 |    365.36 ns |  1.665 ns |  1.390 ns | 10.30 |    0.16 | 0.0200 |     - |     - |      64 B |
|                               ForLoop |    10 |     35.43 ns |  0.630 ns |  0.559 ns |  1.00 |    0.00 | 0.0229 |     - |     - |      72 B |
|                           ForeachLoop |    10 |     32.89 ns |  0.345 ns |  0.323 ns |  0.93 |    0.01 | 0.0229 |     - |     - |      72 B |
|                                  Linq |    10 |    129.03 ns |  1.244 ns |  1.163 ns |  3.64 |    0.07 | 0.0560 |     - |     - |     176 B |
|                            LinqFaster |    10 |    102.13 ns |  0.508 ns |  0.451 ns |  2.88 |    0.05 | 0.0509 |     - |     - |     160 B |
|                                LinqAF |    10 |    141.74 ns |  1.298 ns |  1.150 ns |  4.00 |    0.07 | 0.0226 |     - |     - |      72 B |
|                            StructLinq |    10 |    198.90 ns |  0.909 ns |  0.850 ns |  5.62 |    0.08 | 0.0508 |     - |     - |     160 B |
|                  StructLinq_IFunction |    10 |    137.73 ns |  0.487 ns |  0.432 ns |  3.89 |    0.07 | 0.0203 |     - |     - |      64 B |
|                             Hyperlinq |    10 |    158.38 ns |  0.760 ns |  0.674 ns |  4.47 |    0.07 | 0.0203 |     - |     - |      64 B |
|                   Hyperlinq_IFunction |    10 |    130.76 ns |  0.735 ns |  0.687 ns |  3.69 |    0.06 | 0.0203 |     - |     - |      64 B |
|                              Tinyield |    10 |    275.70 ns |  3.141 ns |  2.938 ns |  7.79 |    0.13 | 0.2880 |     - |     - |     904 B |
|                                       |       |              |           |           |       |         |        |       |       |           |
|                    **ValueLinq_Standard** |  **1000** |  **6,921.75 ns** | **64.195 ns** | **60.048 ns** |  **2.18** |    **0.02** | **1.3657** |     **-** |     **-** |   **4,304 B** |
|                       ValueLinq_Stack |  1000 |  8,902.15 ns | 44.892 ns | 39.796 ns |  2.80 |    0.02 | 1.3275 |     - |     - |   4,176 B |
|             ValueLinq_SharedPool_Push |  1000 |  8,261.22 ns | 39.091 ns | 34.653 ns |  2.60 |    0.02 | 0.6561 |     - |     - |   2,072 B |
|             ValueLinq_SharedPool_Pull |  1000 |  9,797.21 ns | 51.910 ns | 48.556 ns |  3.09 |    0.03 | 0.6561 |     - |     - |   2,072 B |
|        ValueLinq_ValueLambda_Standard |  1000 |  3,685.66 ns | 14.499 ns | 12.853 ns |  1.16 |    0.01 | 1.3695 |     - |     - |   4,304 B |
|           ValueLinq_ValueLambda_Stack |  1000 |  3,773.26 ns | 19.768 ns | 18.491 ns |  1.19 |    0.01 | 1.3275 |     - |     - |   4,176 B |
| ValueLinq_ValueLambda_SharedPool_Push |  1000 |  5,426.68 ns | 23.484 ns | 21.967 ns |  1.71 |    0.01 | 0.6561 |     - |     - |   2,072 B |
| ValueLinq_ValueLambda_SharedPool_Pull |  1000 |  3,838.01 ns | 32.298 ns | 30.212 ns |  1.21 |    0.01 | 0.6561 |     - |     - |   2,072 B |
|                               ForLoop |  1000 |  3,173.58 ns | 20.567 ns | 19.239 ns |  1.00 |    0.00 | 1.3695 |     - |     - |   4,304 B |
|                           ForeachLoop |  1000 |  3,379.51 ns | 16.131 ns | 14.300 ns |  1.06 |    0.01 | 1.3695 |     - |     - |   4,304 B |
|                                  Linq |  1000 |  6,674.46 ns | 32.979 ns | 30.848 ns |  2.10 |    0.02 | 1.4038 |     - |     - |   4,408 B |
|                            LinqFaster |  1000 |  6,442.45 ns | 23.452 ns | 20.790 ns |  2.03 |    0.01 | 2.5864 |     - |     - |   8,136 B |
|                                LinqAF |  1000 | 10,908.63 ns | 38.147 ns | 33.816 ns |  3.44 |    0.02 | 1.3580 |     - |     - |   4,304 B |
|                            StructLinq |  1000 |  7,607.16 ns | 49.918 ns | 46.694 ns |  2.40 |    0.02 | 0.6866 |     - |     - |   2,168 B |
|                  StructLinq_IFunction |  1000 |  3,859.30 ns | 29.305 ns | 25.978 ns |  1.22 |    0.01 | 0.6561 |     - |     - |   2,072 B |
|                             Hyperlinq |  1000 |  7,020.82 ns | 20.506 ns | 16.009 ns |  2.21 |    0.02 | 0.6561 |     - |     - |   2,072 B |
|                   Hyperlinq_IFunction |  1000 |  5,060.86 ns | 30.168 ns | 28.219 ns |  1.59 |    0.01 | 0.6561 |     - |     - |   2,072 B |
|                              Tinyield |  1000 | 13,171.34 ns | 43.930 ns | 41.092 ns |  4.15 |    0.03 | 1.6327 |     - |     - |   5,136 B |
