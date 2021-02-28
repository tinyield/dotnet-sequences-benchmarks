## List.Int32.ListInt32WhereSelectToList

### Source
[ListInt32WhereSelectToList.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelectToList.cs)

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
|                                        Method | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------------------- |------ |-------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|                            **ValueLinq_Standard** |    **10** |    **294.81 ns** |   **1.857 ns** |   **1.646 ns** |  **7.78** |    **0.10** | **0.0200** |     **-** |     **-** |      **64 B** |
|                               ValueLinq_Stack |    10 |    244.57 ns |   0.738 ns |   0.654 ns |  6.46 |    0.07 | 0.0200 |     - |     - |      64 B |
|                     ValueLinq_SharedPool_Push |    10 |    497.38 ns |   1.982 ns |   1.655 ns | 13.12 |    0.16 | 0.0200 |     - |     - |      64 B |
|                     ValueLinq_SharedPool_Pull |    10 |    393.81 ns |   2.053 ns |   1.715 ns | 10.39 |    0.10 | 0.0200 |     - |     - |      64 B |
|                ValueLinq_ValueLambda_Standard |    10 |    273.81 ns |   1.308 ns |   1.092 ns |  7.22 |    0.07 | 0.0200 |     - |     - |      64 B |
|                   ValueLinq_ValueLambda_Stack |    10 |    208.82 ns |   0.866 ns |   0.810 ns |  5.51 |    0.07 | 0.0203 |     - |     - |      64 B |
|         ValueLinq_ValueLambda_SharedPool_Push |    10 |    405.00 ns |   3.277 ns |   3.065 ns | 10.68 |    0.12 | 0.0200 |     - |     - |      64 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |    10 |    382.94 ns |   3.375 ns |   3.157 ns | 10.10 |    0.12 | 0.0200 |     - |     - |      64 B |
|                    ValueLinq_Standard_ByIndex |    10 |    259.82 ns |   1.522 ns |   1.349 ns |  6.86 |    0.07 | 0.0200 |     - |     - |      64 B |
|                       ValueLinq_Stack_ByIndex |    10 |    205.46 ns |   0.925 ns |   0.772 ns |  5.42 |    0.05 | 0.0203 |     - |     - |      64 B |
|             ValueLinq_SharedPool_Push_ByIndex |    10 |    524.77 ns |   2.032 ns |   1.801 ns | 13.86 |    0.13 | 0.0200 |     - |     - |      64 B |
|             ValueLinq_SharedPool_Pull_ByIndex |    10 |    368.77 ns |   1.378 ns |   1.222 ns |  9.74 |    0.11 | 0.0200 |     - |     - |      64 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |    10 |    242.11 ns |   2.682 ns |   2.509 ns |  6.39 |    0.09 | 0.0200 |     - |     - |      64 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |    10 |    189.21 ns |   1.106 ns |   0.981 ns |  5.00 |    0.06 | 0.0203 |     - |     - |      64 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |    10 |    415.00 ns |   1.877 ns |   1.664 ns | 10.96 |    0.11 | 0.0200 |     - |     - |      64 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |    10 |    360.13 ns |   1.021 ns |   0.955 ns |  9.50 |    0.09 | 0.0200 |     - |     - |      64 B |
|                                       ForLoop |    10 |     37.91 ns |   0.419 ns |   0.392 ns |  1.00 |    0.00 | 0.0229 |     - |     - |      72 B |
|                                   ForeachLoop |    10 |     63.30 ns |   0.654 ns |   0.611 ns |  1.67 |    0.03 | 0.0229 |     - |     - |      72 B |
|                                          Linq |    10 |    146.47 ns |   0.646 ns |   0.573 ns |  3.87 |    0.04 | 0.0713 |     - |     - |     224 B |
|                                    LinqFaster |    10 |    102.31 ns |   0.786 ns |   0.735 ns |  2.70 |    0.03 | 0.0433 |     - |     - |     136 B |
|                                        LinqAF |    10 |    219.23 ns |   1.073 ns |   0.951 ns |  5.79 |    0.06 | 0.0229 |     - |     - |      72 B |
|                                    StructLinq |    10 |    198.21 ns |   2.982 ns |   2.789 ns |  5.23 |    0.07 | 0.0508 |     - |     - |     160 B |
|                          StructLinq_IFunction |    10 |    136.42 ns |   0.758 ns |   0.672 ns |  3.60 |    0.04 | 0.0203 |     - |     - |      64 B |
|                                     Hyperlinq |    10 |    161.46 ns |   0.707 ns |   0.661 ns |  4.26 |    0.05 | 0.0203 |     - |     - |      64 B |
|                           Hyperlinq_IFunction |    10 |    126.00 ns |   0.950 ns |   0.842 ns |  3.33 |    0.04 | 0.0203 |     - |     - |      64 B |
|                                      Tinyield |    10 |    383.54 ns |   2.970 ns |   2.779 ns | 10.12 |    0.15 | 0.2980 |     - |     - |     936 B |
|                                               |       |              |            |            |       |         |        |       |       |           |
|                            **ValueLinq_Standard** |  **1000** |  **7,115.05 ns** |  **47.720 ns** |  **44.637 ns** |  **1.42** |    **0.01** | **1.3657** |     **-** |     **-** |   **4,304 B** |
|                               ValueLinq_Stack |  1000 | 10,546.75 ns |  50.875 ns |  47.588 ns |  2.11 |    0.02 | 1.3275 |     - |     - |   4,176 B |
|                     ValueLinq_SharedPool_Push |  1000 |  7,702.78 ns |  88.529 ns |  82.810 ns |  1.54 |    0.02 | 0.6561 |     - |     - |   2,072 B |
|                     ValueLinq_SharedPool_Pull |  1000 | 10,544.60 ns |  46.391 ns |  36.219 ns |  2.10 |    0.01 | 0.6561 |     - |     - |   2,072 B |
|                ValueLinq_ValueLambda_Standard |  1000 |  3,849.31 ns |  46.515 ns |  43.510 ns |  0.77 |    0.01 | 1.3657 |     - |     - |   4,304 B |
|                   ValueLinq_ValueLambda_Stack |  1000 | 10,647.63 ns |  29.283 ns |  24.453 ns |  2.13 |    0.01 | 1.3275 |     - |     - |   4,176 B |
|         ValueLinq_ValueLambda_SharedPool_Push |  1000 |  4,591.30 ns |  22.655 ns |  20.083 ns |  0.92 |    0.01 | 0.6561 |     - |     - |   2,072 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |  1000 | 11,471.09 ns |  35.922 ns |  31.844 ns |  2.29 |    0.02 | 0.6561 |     - |     - |   2,072 B |
|                    ValueLinq_Standard_ByIndex |  1000 |  6,716.73 ns |  50.151 ns |  44.458 ns |  1.34 |    0.01 | 1.3657 |     - |     - |   4,304 B |
|                       ValueLinq_Stack_ByIndex |  1000 |  8,011.36 ns |  41.889 ns |  32.704 ns |  1.60 |    0.01 | 1.3275 |     - |     - |   4,176 B |
|             ValueLinq_SharedPool_Push_ByIndex |  1000 |  7,791.75 ns |  65.363 ns |  61.141 ns |  1.56 |    0.02 | 0.6561 |     - |     - |   2,072 B |
|             ValueLinq_SharedPool_Pull_ByIndex |  1000 |  8,646.72 ns |  61.345 ns |  54.381 ns |  1.73 |    0.01 | 0.6561 |     - |     - |   2,072 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |  1000 |  5,336.95 ns |  34.801 ns |  32.553 ns |  1.07 |    0.01 | 1.3657 |     - |     - |   4,304 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |  1000 |  4,854.57 ns |  60.764 ns |  53.866 ns |  0.97 |    0.01 | 1.3275 |     - |     - |   4,176 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |  1000 |  5,498.13 ns |  24.519 ns |  21.735 ns |  1.10 |    0.01 | 0.6561 |     - |     - |   2,072 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |  1000 |  3,600.91 ns |  36.414 ns |  34.061 ns |  0.72 |    0.01 | 0.6599 |     - |     - |   2,072 B |
|                                       ForLoop |  1000 |  5,007.82 ns |  29.684 ns |  27.766 ns |  1.00 |    0.00 | 1.3657 |     - |     - |   4,304 B |
|                                   ForeachLoop |  1000 |  5,482.30 ns |  66.945 ns |  62.621 ns |  1.09 |    0.01 | 1.3657 |     - |     - |   4,304 B |
|                                          Linq |  1000 |  7,977.01 ns |  56.620 ns |  52.962 ns |  1.59 |    0.02 | 1.4191 |     - |     - |   4,456 B |
|                                    LinqFaster |  1000 |  8,178.33 ns |  72.331 ns |  67.659 ns |  1.63 |    0.02 | 2.0294 |     - |     - |   6,376 B |
|                                        LinqAF |  1000 | 17,349.68 ns | 180.278 ns | 168.632 ns |  3.46 |    0.04 | 1.3428 |     - |     - |   4,304 B |
|                                    StructLinq |  1000 |  6,901.24 ns |  39.133 ns |  36.605 ns |  1.38 |    0.01 | 0.6866 |     - |     - |   2,168 B |
|                          StructLinq_IFunction |  1000 |  3,856.22 ns |  22.145 ns |  19.631 ns |  0.77 |    0.01 | 0.6561 |     - |     - |   2,072 B |
|                                     Hyperlinq |  1000 |  6,915.36 ns |  57.553 ns |  53.835 ns |  1.38 |    0.01 | 0.6561 |     - |     - |   2,072 B |
|                           Hyperlinq_IFunction |  1000 |  5,072.81 ns |  23.426 ns |  19.562 ns |  1.01 |    0.01 | 0.6561 |     - |     - |   2,072 B |
|                                      Tinyield |  1000 | 21,589.29 ns | 211.434 ns | 197.775 ns |  4.31 |    0.05 | 1.6174 |     - |     - |   5,168 B |
