## Array.ValueType.ArrayValueTypeWhereSelectToList

### Source
[ArrayValueTypeWhereSelectToList.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelectToList.cs)

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
|                                Method | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |   Gen 0 |   Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |-------------:|-----------:|-----------:|------:|--------:|--------:|--------:|------:|----------:|
|                    **ValueLinq_Standard** |    **10** |    **300.67 ns** |   **1.554 ns** |   **1.377 ns** |  **3.80** |    **0.04** |  **0.0587** |       **-** |     **-** |     **184 B** |
|                       ValueLinq_Stack |    10 |    252.44 ns |   2.851 ns |   2.667 ns |  3.19 |    0.05 |  0.0587 |       - |     - |     184 B |
|             ValueLinq_SharedPool_Push |    10 |    591.89 ns |   3.318 ns |   3.103 ns |  7.49 |    0.10 |  0.0582 |       - |     - |     184 B |
|             ValueLinq_SharedPool_Pull |    10 |    454.62 ns |   2.074 ns |   1.839 ns |  5.74 |    0.06 |  0.0587 |       - |     - |     184 B |
|                ValueLinq_Ref_Standard |    10 |    286.93 ns |   1.183 ns |   1.049 ns |  3.63 |    0.04 |  0.0587 |       - |     - |     184 B |
|                   ValueLinq_Ref_Stack |    10 |    231.35 ns |   1.250 ns |   1.169 ns |  2.93 |    0.03 |  0.0587 |       - |     - |     184 B |
|         ValueLinq_Ref_SharedPool_Push |    10 |    477.03 ns |   3.537 ns |   3.309 ns |  6.03 |    0.06 |  0.0587 |       - |     - |     184 B |
|         ValueLinq_Ref_SharedPool_Pull |    10 |    452.45 ns |   1.917 ns |   1.793 ns |  5.72 |    0.06 |  0.0587 |       - |     - |     184 B |
|        ValueLinq_ValueLambda_Standard |    10 |    314.27 ns |   4.053 ns |   3.791 ns |  3.97 |    0.07 |  0.0587 |       - |     - |     184 B |
|           ValueLinq_ValueLambda_Stack |    10 |    266.96 ns |   2.702 ns |   2.257 ns |  3.38 |    0.04 |  0.0587 |       - |     - |     184 B |
| ValueLinq_ValueLambda_SharedPool_Push |    10 |    499.58 ns |   2.324 ns |   2.174 ns |  6.32 |    0.07 |  0.0582 |       - |     - |     184 B |
| ValueLinq_ValueLambda_SharedPool_Pull |    10 |    470.19 ns |   4.292 ns |   4.015 ns |  5.95 |    0.07 |  0.0582 |       - |     - |     184 B |
|                               ForLoop |    10 |     79.08 ns |   0.829 ns |   0.775 ns |  1.00 |    0.00 |  0.0994 |       - |     - |     312 B |
|                           ForeachLoop |    10 |     95.88 ns |   1.814 ns |   1.697 ns |  1.21 |    0.03 |  0.0994 |       - |     - |     312 B |
|                                  Linq |    10 |    200.61 ns |   2.536 ns |   2.372 ns |  2.54 |    0.04 |  0.1683 |       - |     - |     528 B |
|                            LinqFaster |    10 |    191.55 ns |   1.788 ns |   1.585 ns |  2.42 |    0.03 |  0.3188 |       - |     - |   1,000 B |
|                                LinqAF |    10 |    330.06 ns |   6.283 ns |   6.723 ns |  4.17 |    0.09 |  0.0992 |       - |     - |     312 B |
|                            StructLinq |    10 |    238.61 ns |   2.550 ns |   2.261 ns |  3.01 |    0.03 |  0.0892 |       - |     - |     280 B |
|                  StructLinq_IFunction |    10 |    175.84 ns |   1.518 ns |   1.420 ns |  2.22 |    0.02 |  0.0587 |       - |     - |     184 B |
|                             Hyperlinq |    10 |    228.68 ns |   2.707 ns |   2.532 ns |  2.89 |    0.04 |  0.0587 |       - |     - |     184 B |
|                   Hyperlinq_IFunction |    10 |    200.23 ns |   1.746 ns |   1.548 ns |  2.53 |    0.03 |  0.0587 |       - |     - |     184 B |
|                              Tinyield |    10 |    335.58 ns |   3.367 ns |   3.149 ns |  4.24 |    0.05 |  0.3643 |       - |     - |   1,144 B |
|                                       |       |              |            |            |       |         |         |         |       |           |
|                    **ValueLinq_Standard** |  **1000** | **25,156.14 ns** | **257.118 ns** | **227.928 ns** |  **1.55** |    **0.01** | **20.8130** |       **-** |     **-** |  **65,504 B** |
|                       ValueLinq_Stack |  1000 | 21,211.39 ns | 132.960 ns | 124.371 ns |  1.31 |    0.02 | 20.3857 |       - |     - |  64,112 B |
|             ValueLinq_SharedPool_Push |  1000 | 24,640.17 ns | 262.151 ns | 245.216 ns |  1.52 |    0.02 | 10.1929 |       - |     - |  32,248 B |
|             ValueLinq_SharedPool_Pull |  1000 | 19,944.53 ns | 103.140 ns |  96.477 ns |  1.23 |    0.02 | 10.1929 |       - |     - |  32,248 B |
|                ValueLinq_Ref_Standard |  1000 | 22,720.61 ns | 167.150 ns | 148.174 ns |  1.40 |    0.02 | 20.8130 |       - |     - |  65,504 B |
|                   ValueLinq_Ref_Stack |  1000 | 22,070.53 ns | 185.080 ns | 173.124 ns |  1.36 |    0.02 | 20.3857 |       - |     - |  64,112 B |
|         ValueLinq_Ref_SharedPool_Push |  1000 | 21,413.18 ns | 226.116 ns | 211.509 ns |  1.32 |    0.02 | 10.1929 |       - |     - |  32,248 B |
|         ValueLinq_Ref_SharedPool_Pull |  1000 | 20,135.64 ns | 156.532 ns | 146.420 ns |  1.24 |    0.02 | 10.1929 |       - |     - |  32,248 B |
|        ValueLinq_ValueLambda_Standard |  1000 | 24,625.69 ns | 260.264 ns | 243.451 ns |  1.52 |    0.02 | 20.8130 |       - |     - |  65,504 B |
|           ValueLinq_ValueLambda_Stack |  1000 | 21,671.65 ns | 218.219 ns | 204.122 ns |  1.33 |    0.02 | 20.3857 |       - |     - |  64,112 B |
| ValueLinq_ValueLambda_SharedPool_Push |  1000 | 20,406.05 ns | 265.719 ns | 248.553 ns |  1.26 |    0.02 | 10.1929 |       - |     - |  32,248 B |
| ValueLinq_ValueLambda_SharedPool_Pull |  1000 | 19,493.94 ns | 199.659 ns | 186.761 ns |  1.20 |    0.01 | 10.1929 |       - |     - |  32,248 B |
|                               ForLoop |  1000 | 16,249.06 ns | 211.183 ns | 197.541 ns |  1.00 |    0.00 | 20.8130 |       - |     - |  65,504 B |
|                           ForeachLoop |  1000 | 18,311.57 ns | 157.600 ns | 131.603 ns |  1.13 |    0.02 | 20.8130 |       - |     - |  65,504 B |
|                                  Linq |  1000 | 22,688.51 ns | 218.143 ns | 204.051 ns |  1.40 |    0.02 | 20.8130 |       - |     - |  65,720 B |
|                            LinqFaster |  1000 | 25,416.18 ns | 242.545 ns | 226.876 ns |  1.56 |    0.02 | 40.8020 | 10.1929 |     - | 128,488 B |
|                                LinqAF |  1000 | 37,654.24 ns | 742.262 ns | 825.022 ns |  2.32 |    0.06 | 20.8130 |       - |     - |  65,504 B |
|                            StructLinq |  1000 | 20,754.28 ns | 213.179 ns | 188.977 ns |  1.28 |    0.02 | 10.1929 |       - |     - |  32,344 B |
|                  StructLinq_IFunction |  1000 | 16,293.78 ns | 179.094 ns | 167.525 ns |  1.00 |    0.02 | 10.1929 |       - |     - |  32,248 B |
|                             Hyperlinq |  1000 | 23,032.83 ns | 291.258 ns | 258.193 ns |  1.42 |    0.02 | 10.1929 |       - |     - |  32,248 B |
|                   Hyperlinq_IFunction |  1000 | 16,770.09 ns | 137.365 ns | 128.491 ns |  1.03 |    0.01 | 10.1929 |       - |     - |  32,248 B |
|                              Tinyield |  1000 | 28,302.45 ns | 260.003 ns | 243.207 ns |  1.74 |    0.02 | 21.0266 |       - |     - |  66,336 B |
