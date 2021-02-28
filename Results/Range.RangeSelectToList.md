## Range.RangeSelectToList

### Source
[RangeSelectToList.cs](../LinqBenchmarks/Range/RangeSelectToList.cs)

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
|                                Method | Start | Count |         Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |------ |-------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                    **ValueLinq_Standard** |     **0** |    **10** |    **164.69 ns** |  **3.332 ns** |  **5.286 ns** |  **1.86** |    **0.06** | **0.0305** |     **-** |     **-** |      **96 B** |
|                       ValueLinq_Stack |     0 |    10 |    172.22 ns |  3.526 ns |  3.621 ns |  1.91 |    0.05 | 0.0305 |     - |     - |      96 B |
|             ValueLinq_SharedPool_Push |     0 |    10 |    459.57 ns |  3.928 ns |  3.674 ns |  5.09 |    0.04 | 0.0305 |     - |     - |      96 B |
|             ValueLinq_SharedPool_Pull |     0 |    10 |    335.81 ns |  6.128 ns | 11.951 ns |  3.79 |    0.09 | 0.0305 |     - |     - |      96 B |
|        ValueLinq_ValueLambda_Standard |     0 |    10 |    144.55 ns |  0.617 ns |  0.547 ns |  1.60 |    0.01 | 0.0305 |     - |     - |      96 B |
|           ValueLinq_ValueLambda_Stack |     0 |    10 |    146.69 ns |  0.538 ns |  0.477 ns |  1.62 |    0.01 | 0.0305 |     - |     - |      96 B |
| ValueLinq_ValueLambda_SharedPool_Push |     0 |    10 |    342.37 ns |  1.474 ns |  1.151 ns |  3.79 |    0.02 | 0.0305 |     - |     - |      96 B |
| ValueLinq_ValueLambda_SharedPool_Pull |     0 |    10 |    297.11 ns |  1.811 ns |  1.694 ns |  3.29 |    0.02 | 0.0305 |     - |     - |      96 B |
|                               ForLoop |     0 |    10 |     90.32 ns |  0.416 ns |  0.369 ns |  1.00 |    0.00 | 0.0688 |     - |     - |     216 B |
|                           ForeachLoop |     0 |    10 |    182.52 ns |  0.952 ns |  0.891 ns |  2.02 |    0.01 | 0.0865 |     - |     - |     272 B |
|                                  Linq |     0 |    10 |    114.24 ns |  0.651 ns |  0.609 ns |  1.27 |    0.01 | 0.0587 |     - |     - |     184 B |
|                            LinqFaster |     0 |    10 |     88.43 ns |  0.506 ns |  0.449 ns |  0.98 |    0.01 | 0.0713 |     - |     - |     224 B |
|                                LinqAF |     0 |    10 |    206.92 ns |  0.783 ns |  0.694 ns |  2.29 |    0.01 | 0.0687 |     - |     - |     216 B |
|                            StructLinq |     0 |    10 |     86.44 ns |  0.930 ns |  0.869 ns |  0.96 |    0.01 | 0.0484 |     - |     - |     152 B |
|                  StructLinq_IFunction |     0 |    10 |     53.60 ns |  0.247 ns |  0.219 ns |  0.59 |    0.00 | 0.0306 |     - |     - |      96 B |
|                             Hyperlinq |     0 |    10 |     83.15 ns |  0.366 ns |  0.343 ns |  0.92 |    0.00 | 0.0305 |     - |     - |      96 B |
|                   Hyperlinq_IFunction |     0 |    10 |     66.04 ns |  0.511 ns |  0.427 ns |  0.73 |    0.01 | 0.0305 |     - |     - |      96 B |
|                        Hyperlinq_SIMD |     0 |    10 |     73.01 ns |  0.812 ns |  0.760 ns |  0.81 |    0.01 | 0.0305 |     - |     - |      96 B |
|              Hyperlinq_IFunction_SIMD |     0 |    10 |     51.11 ns |  0.351 ns |  0.328 ns |  0.57 |    0.00 | 0.0306 |     - |     - |      96 B |
|                              Tinyield |     0 |    10 |    356.61 ns |  3.736 ns |  3.495 ns |  3.95 |    0.05 | 0.3033 |     - |     - |     952 B |
|                                       |       |       |              |           |           |       |         |        |       |       |           |
|                    **ValueLinq_Standard** |     **0** |  **1000** |  **4,250.20 ns** | **32.565 ns** | **28.868 ns** |  **1.31** |    **0.02** | **1.2894** |     **-** |     **-** |   **4,056 B** |
|                       ValueLinq_Stack |     0 |  1000 |  5,103.67 ns | 52.963 ns | 49.542 ns |  1.58 |    0.02 | 2.6169 |     - |     - |   8,232 B |
|             ValueLinq_SharedPool_Push |     0 |  1000 |  4,992.99 ns | 14.826 ns | 11.575 ns |  1.54 |    0.02 | 1.2894 |     - |     - |   4,056 B |
|             ValueLinq_SharedPool_Pull |     0 |  1000 |  4,721.18 ns | 37.200 ns | 34.797 ns |  1.46 |    0.01 | 1.2894 |     - |     - |   4,056 B |
|        ValueLinq_ValueLambda_Standard |     0 |  1000 |  3,211.13 ns | 19.931 ns | 18.643 ns |  0.99 |    0.01 | 1.2894 |     - |     - |   4,056 B |
|           ValueLinq_ValueLambda_Stack |     0 |  1000 |  3,670.28 ns | 37.282 ns | 33.050 ns |  1.13 |    0.01 | 2.6207 |     - |     - |   8,232 B |
| ValueLinq_ValueLambda_SharedPool_Push |     0 |  1000 |  3,532.80 ns | 23.278 ns | 20.635 ns |  1.09 |    0.01 | 1.2894 |     - |     - |   4,056 B |
| ValueLinq_ValueLambda_SharedPool_Pull |     0 |  1000 |  3,318.20 ns | 27.884 ns | 26.083 ns |  1.03 |    0.01 | 1.2894 |     - |     - |   4,056 B |
|                               ForLoop |     0 |  1000 |  3,236.73 ns | 33.768 ns | 31.587 ns |  1.00 |    0.00 | 2.6817 |     - |     - |   8,424 B |
|                           ForeachLoop |     0 |  1000 |  8,537.42 ns | 70.852 ns | 66.275 ns |  2.64 |    0.04 | 2.7008 |     - |     - |   8,480 B |
|                                  Linq |     0 |  1000 |  4,366.90 ns | 30.000 ns | 28.062 ns |  1.35 |    0.02 | 1.3199 |     - |     - |   4,144 B |
|                            LinqFaster |     0 |  1000 |  4,368.77 ns | 32.445 ns | 30.349 ns |  1.35 |    0.02 | 3.8528 |     - |     - |  12,104 B |
|                                LinqAF |     0 |  1000 |  7,816.16 ns | 46.759 ns | 43.738 ns |  2.42 |    0.02 | 2.6703 |     - |     - |   8,424 B |
|                            StructLinq |     0 |  1000 |  2,996.33 ns | 11.140 ns | 10.421 ns |  0.93 |    0.01 | 1.3084 |     - |     - |   4,112 B |
|                  StructLinq_IFunction |     0 |  1000 |  1,128.23 ns | 15.638 ns | 13.862 ns |  0.35 |    0.01 | 1.2913 |     - |     - |   4,056 B |
|                             Hyperlinq |     0 |  1000 |  3,257.97 ns | 12.036 ns | 11.258 ns |  1.01 |    0.01 | 1.2894 |     - |     - |   4,056 B |
|                   Hyperlinq_IFunction |     0 |  1000 |  1,382.50 ns | 12.319 ns | 11.523 ns |  0.43 |    0.00 | 1.2913 |     - |     - |   4,056 B |
|                        Hyperlinq_SIMD |     0 |  1000 |    823.76 ns |  4.669 ns |  4.139 ns |  0.25 |    0.00 | 1.2903 |     - |     - |   4,056 B |
|              Hyperlinq_IFunction_SIMD |     0 |  1000 |    541.05 ns |  4.992 ns |  4.670 ns |  0.17 |    0.00 | 1.2903 |     - |     - |   4,056 B |
|                              Tinyield |     0 |  1000 | 11,964.13 ns | 67.920 ns | 63.533 ns |  3.70 |    0.03 | 2.9144 |     - |     - |   9,160 B |
