## List.ValueType.ListValueTypeWhereSelectToList

### Source
[ListValueTypeWhereSelectToList.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelectToList.cs)

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
|                                        Method | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------------------------- |------ |-------------:|-----------:|-----------:|------:|--------:|--------:|-------:|------:|----------:|
|                            **ValueLinq_Standard** |    **10** |    **363.92 ns** |   **3.191 ns** |   **2.985 ns** |  **3.82** |    **0.05** |  **0.0587** |      **-** |     **-** |     **184 B** |
|                               ValueLinq_Stack |    10 |    312.26 ns |   2.600 ns |   2.432 ns |  3.28 |    0.05 |  0.0587 |      - |     - |     184 B |
|                     ValueLinq_SharedPool_Push |    10 |    618.32 ns |   7.566 ns |   7.077 ns |  6.50 |    0.10 |  0.0582 |      - |     - |     184 B |
|                     ValueLinq_SharedPool_Pull |    10 |    502.91 ns |   3.795 ns |   3.169 ns |  5.29 |    0.05 |  0.0582 |      - |     - |     184 B |
|                        ValueLinq_Ref_Standard |    10 |    377.14 ns |   2.390 ns |   2.119 ns |  3.96 |    0.04 |  0.0587 |      - |     - |     184 B |
|                           ValueLinq_Ref_Stack |    10 |    331.67 ns |   1.313 ns |   1.164 ns |  3.48 |    0.04 |  0.0587 |      - |     - |     184 B |
|                 ValueLinq_Ref_SharedPool_Push |    10 |    501.11 ns |   3.899 ns |   3.456 ns |  5.26 |    0.08 |  0.0582 |      - |     - |     184 B |
|                 ValueLinq_Ref_SharedPool_Pull |    10 |    517.39 ns |   2.867 ns |   2.682 ns |  5.44 |    0.06 |  0.0582 |      - |     - |     184 B |
|                ValueLinq_ValueLambda_Standard |    10 |    403.63 ns |   4.620 ns |   4.321 ns |  4.24 |    0.07 |  0.0587 |      - |     - |     184 B |
|                   ValueLinq_ValueLambda_Stack |    10 |    349.35 ns |   4.138 ns |   3.871 ns |  3.67 |    0.06 |  0.0587 |      - |     - |     184 B |
|         ValueLinq_ValueLambda_SharedPool_Push |    10 |    500.08 ns |   4.134 ns |   3.665 ns |  5.25 |    0.07 |  0.0582 |      - |     - |     184 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |    10 |    549.06 ns |   4.087 ns |   3.623 ns |  5.77 |    0.06 |  0.0582 |      - |     - |     184 B |
|                    ValueLinq_Standard_ByIndex |    10 |    333.04 ns |   1.393 ns |   1.303 ns |  3.50 |    0.04 |  0.0587 |      - |     - |     184 B |
|                       ValueLinq_Stack_ByIndex |    10 |    267.23 ns |   2.539 ns |   2.251 ns |  2.81 |    0.04 |  0.0587 |      - |     - |     184 B |
|             ValueLinq_SharedPool_Push_ByIndex |    10 |    638.36 ns |   8.107 ns |   7.187 ns |  6.71 |    0.08 |  0.0582 |      - |     - |     184 B |
|             ValueLinq_SharedPool_Pull_ByIndex |    10 |    469.34 ns |   2.103 ns |   1.967 ns |  4.93 |    0.06 |  0.0587 |      - |     - |     184 B |
|                ValueLinq_Ref_Standard_ByIndex |    10 |    296.70 ns |   1.898 ns |   1.775 ns |  3.12 |    0.05 |  0.0587 |      - |     - |     184 B |
|                   ValueLinq_Ref_Stack_ByIndex |    10 |    244.34 ns |   1.375 ns |   1.286 ns |  2.57 |    0.03 |  0.0587 |      - |     - |     184 B |
|         ValueLinq_Ref_SharedPool_Push_ByIndex |    10 |    521.55 ns |   4.920 ns |   4.603 ns |  5.48 |    0.06 |  0.0582 |      - |     - |     184 B |
|         ValueLinq_Ref_SharedPool_Pull_ByIndex |    10 |    441.25 ns |   3.378 ns |   3.160 ns |  4.64 |    0.06 |  0.0587 |      - |     - |     184 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |    10 |    320.34 ns |   2.989 ns |   2.796 ns |  3.37 |    0.04 |  0.0587 |      - |     - |     184 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |    10 |    281.42 ns |   3.201 ns |   2.994 ns |  2.96 |    0.04 |  0.0587 |      - |     - |     184 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |    10 |    524.50 ns |   4.617 ns |   4.319 ns |  5.51 |    0.08 |  0.0582 |      - |     - |     184 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |    10 |    455.74 ns |   2.264 ns |   2.117 ns |  4.79 |    0.05 |  0.0587 |      - |     - |     184 B |
|                                       ForLoop |    10 |     95.21 ns |   1.188 ns |   1.053 ns |  1.00 |    0.00 |  0.0994 |      - |     - |     312 B |
|                                   ForeachLoop |    10 |    140.13 ns |   2.239 ns |   2.095 ns |  1.47 |    0.03 |  0.0994 |      - |     - |     312 B |
|                                          Linq |    10 |    235.68 ns |   2.022 ns |   1.793 ns |  2.48 |    0.03 |  0.2193 |      - |     - |     688 B |
|                                    LinqFaster |    10 |    177.60 ns |   3.494 ns |   3.738 ns |  1.87 |    0.05 |  0.1581 |      - |     - |     496 B |
|                                        LinqAF |    10 |    457.25 ns |   9.051 ns |  10.774 ns |  4.81 |    0.13 |  0.0992 |      - |     - |     312 B |
|                                    StructLinq |    10 |    238.16 ns |   2.915 ns |   2.726 ns |  2.50 |    0.04 |  0.0916 |      - |     - |     288 B |
|                          StructLinq_IFunction |    10 |    182.51 ns |   1.103 ns |   1.032 ns |  1.92 |    0.02 |  0.0587 |      - |     - |     184 B |
|                                     Hyperlinq |    10 |    227.73 ns |   3.131 ns |   2.929 ns |  2.39 |    0.05 |  0.0587 |      - |     - |     184 B |
|                           Hyperlinq_IFunction |    10 |    193.87 ns |   1.828 ns |   1.710 ns |  2.04 |    0.03 |  0.0587 |      - |     - |     184 B |
|                                      Tinyield |    10 |    471.97 ns |   2.554 ns |   2.133 ns |  4.96 |    0.06 |  0.3920 |      - |     - |   1,232 B |
|                                               |       |              |            |            |       |         |         |        |       |           |
|                            **ValueLinq_Standard** |  **1000** | **25,353.28 ns** | **184.559 ns** | **172.637 ns** |  **1.46** |    **0.01** | **20.8130** |      **-** |     **-** |  **65,504 B** |
|                               ValueLinq_Stack |  1000 | 25,786.32 ns | 262.270 ns | 245.327 ns |  1.49 |    0.02 | 20.3857 |      - |     - |  64,112 B |
|                     ValueLinq_SharedPool_Push |  1000 | 24,683.31 ns | 307.846 ns | 287.960 ns |  1.43 |    0.02 | 10.1929 |      - |     - |  32,248 B |
|                     ValueLinq_SharedPool_Pull |  1000 | 24,250.12 ns | 255.155 ns | 238.672 ns |  1.40 |    0.02 | 10.1929 |      - |     - |  32,248 B |
|                        ValueLinq_Ref_Standard |  1000 | 22,134.53 ns | 235.458 ns | 220.247 ns |  1.28 |    0.01 | 20.8130 |      - |     - |  65,504 B |
|                           ValueLinq_Ref_Stack |  1000 | 36,649.32 ns | 141.384 ns | 132.250 ns |  2.12 |    0.02 | 20.3857 |      - |     - |  64,112 B |
|                 ValueLinq_Ref_SharedPool_Push |  1000 | 21,377.68 ns | 178.084 ns | 166.580 ns |  1.23 |    0.01 | 10.1929 |      - |     - |  32,248 B |
|                 ValueLinq_Ref_SharedPool_Pull |  1000 | 23,933.76 ns | 167.730 ns | 148.689 ns |  1.38 |    0.01 | 10.1929 |      - |     - |  32,248 B |
|                ValueLinq_ValueLambda_Standard |  1000 | 21,585.91 ns | 251.039 ns | 234.822 ns |  1.25 |    0.01 | 20.8130 |      - |     - |  65,504 B |
|                   ValueLinq_ValueLambda_Stack |  1000 | 27,204.99 ns | 212.489 ns | 198.762 ns |  1.57 |    0.01 | 20.3857 |      - |     - |  64,112 B |
|         ValueLinq_ValueLambda_SharedPool_Push |  1000 | 20,468.60 ns | 171.990 ns | 152.465 ns |  1.18 |    0.01 | 10.1929 |      - |     - |  32,248 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |  1000 | 24,009.30 ns | 334.372 ns | 312.772 ns |  1.39 |    0.02 | 10.1929 |      - |     - |  32,248 B |
|                    ValueLinq_Standard_ByIndex |  1000 | 26,282.54 ns | 317.685 ns | 297.163 ns |  1.52 |    0.02 | 20.8130 |      - |     - |  65,504 B |
|                       ValueLinq_Stack_ByIndex |  1000 | 23,883.84 ns | 234.453 ns | 207.836 ns |  1.38 |    0.01 | 20.3857 |      - |     - |  64,112 B |
|             ValueLinq_SharedPool_Push_ByIndex |  1000 | 24,592.76 ns | 464.066 ns | 434.088 ns |  1.42 |    0.03 | 10.1929 |      - |     - |  32,248 B |
|             ValueLinq_SharedPool_Pull_ByIndex |  1000 | 21,938.55 ns | 225.391 ns | 210.831 ns |  1.27 |    0.02 | 10.1929 |      - |     - |  32,248 B |
|                ValueLinq_Ref_Standard_ByIndex |  1000 | 22,212.69 ns | 209.979 ns | 196.415 ns |  1.28 |    0.01 | 20.8130 |      - |     - |  65,504 B |
|                   ValueLinq_Ref_Stack_ByIndex |  1000 | 20,277.42 ns | 197.583 ns | 184.820 ns |  1.17 |    0.02 | 20.3857 |      - |     - |  64,112 B |
|         ValueLinq_Ref_SharedPool_Push_ByIndex |  1000 | 21,532.49 ns | 220.127 ns | 205.907 ns |  1.24 |    0.02 | 10.1929 |      - |     - |  32,248 B |
|         ValueLinq_Ref_SharedPool_Pull_ByIndex |  1000 | 18,689.72 ns |  96.570 ns |  85.607 ns |  1.08 |    0.01 | 10.1929 |      - |     - |  32,248 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |  1000 | 21,445.45 ns | 252.872 ns | 236.537 ns |  1.24 |    0.02 | 20.8130 |      - |     - |  65,504 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |  1000 | 21,314.57 ns | 208.588 ns | 195.114 ns |  1.23 |    0.01 | 20.3857 |      - |     - |  64,112 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |  1000 | 20,543.71 ns | 196.523 ns | 183.828 ns |  1.19 |    0.01 | 10.1929 |      - |     - |  32,248 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |  1000 | 19,348.22 ns | 186.221 ns | 174.191 ns |  1.12 |    0.01 | 10.1929 |      - |     - |  32,248 B |
|                                       ForLoop |  1000 | 17,316.06 ns | 120.433 ns | 106.761 ns |  1.00 |    0.00 | 20.8130 |      - |     - |  65,504 B |
|                                   ForeachLoop |  1000 | 21,641.23 ns | 136.913 ns | 128.069 ns |  1.25 |    0.01 | 20.8130 |      - |     - |  65,504 B |
|                                          Linq |  1000 | 23,593.77 ns | 254.421 ns | 225.538 ns |  1.36 |    0.02 | 20.8130 |      - |     - |  65,880 B |
|                                    LinqFaster |  1000 | 29,005.94 ns | 550.219 ns | 514.675 ns |  1.67 |    0.03 | 31.0059 | 7.7515 |     - |  97,752 B |
|                                        LinqAF |  1000 | 44,338.03 ns | 844.950 ns | 867.701 ns |  2.56 |    0.05 | 20.8130 |      - |     - |  65,504 B |
|                                    StructLinq |  1000 | 20,579.68 ns | 190.286 ns | 168.683 ns |  1.19 |    0.01 | 10.1929 |      - |     - |  32,352 B |
|                          StructLinq_IFunction |  1000 | 15,045.76 ns | 168.881 ns | 157.972 ns |  0.87 |    0.01 | 10.1929 |      - |     - |  32,248 B |
|                                     Hyperlinq |  1000 | 23,155.73 ns | 336.139 ns | 314.424 ns |  1.34 |    0.02 | 10.1929 |      - |     - |  32,248 B |
|                           Hyperlinq_IFunction |  1000 | 16,632.13 ns | 130.205 ns | 115.424 ns |  0.96 |    0.01 | 10.1929 |      - |     - |  32,248 B |
|                                      Tinyield |  1000 | 38,448.57 ns | 343.348 ns | 321.168 ns |  2.22 |    0.03 | 20.9961 |      - |     - |  66,424 B |
