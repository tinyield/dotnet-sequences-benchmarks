## List.ValueType.ListValueTypeWhereSelectToArray

### Source
[ListValueTypeWhereSelectToArray.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelectToArray.cs)

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
|                                        Method | Count |        Mean |     Error |      StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------------------- |------ |------------:|----------:|------------:|------:|--------:|--------:|------:|------:|----------:|
|                            **ValueLinq_Standard** |    **10** |    **321.2 ns** |   **4.27 ns** |     **4.00 ns** |  **2.66** |    **0.06** |  **0.0482** |     **-** |     **-** |     **152 B** |
|                               ValueLinq_Stack |    10 |    291.6 ns |   5.59 ns |     5.23 ns |  2.42 |    0.06 |  0.0482 |     - |     - |     152 B |
|                     ValueLinq_SharedPool_Push |    10 |    620.2 ns |   4.36 ns |     3.86 ns |  5.14 |    0.08 |  0.0477 |     - |     - |     152 B |
|                     ValueLinq_SharedPool_Pull |    10 |    495.8 ns |   3.81 ns |     3.38 ns |  4.11 |    0.08 |  0.0477 |     - |     - |     152 B |
|                        ValueLinq_Ref_Standard |    10 |    361.1 ns |   2.54 ns |     2.38 ns |  2.99 |    0.05 |  0.0482 |     - |     - |     152 B |
|                           ValueLinq_Ref_Stack |    10 |    295.5 ns |   1.18 ns |     0.99 ns |  2.45 |    0.04 |  0.0482 |     - |     - |     152 B |
|                 ValueLinq_Ref_SharedPool_Push |    10 |    487.9 ns |   3.36 ns |     3.14 ns |  4.05 |    0.07 |  0.0477 |     - |     - |     152 B |
|                 ValueLinq_Ref_SharedPool_Pull |    10 |    523.4 ns |   3.72 ns |     3.48 ns |  4.34 |    0.08 |  0.0477 |     - |     - |     152 B |
|                ValueLinq_ValueLambda_Standard |    10 |    373.5 ns |   5.14 ns |     4.81 ns |  3.10 |    0.06 |  0.0482 |     - |     - |     152 B |
|                   ValueLinq_ValueLambda_Stack |    10 |    331.7 ns |   5.36 ns |     5.01 ns |  2.75 |    0.06 |  0.0482 |     - |     - |     152 B |
|         ValueLinq_ValueLambda_SharedPool_Push |    10 |    498.8 ns |   3.88 ns |     3.44 ns |  4.14 |    0.06 |  0.0477 |     - |     - |     152 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |    10 |    547.2 ns |   4.79 ns |     4.48 ns |  4.54 |    0.09 |  0.0477 |     - |     - |     152 B |
|                    ValueLinq_Standard_ByIndex |    10 |    292.2 ns |   2.61 ns |     2.44 ns |  2.42 |    0.05 |  0.0482 |     - |     - |     152 B |
|                       ValueLinq_Stack_ByIndex |    10 |    240.4 ns |   4.23 ns |     3.95 ns |  1.99 |    0.06 |  0.0482 |     - |     - |     152 B |
|             ValueLinq_SharedPool_Push_ByIndex |    10 |    627.2 ns |   2.65 ns |     2.35 ns |  5.20 |    0.08 |  0.0477 |     - |     - |     152 B |
|             ValueLinq_SharedPool_Pull_ByIndex |    10 |    463.0 ns |   2.28 ns |     2.13 ns |  3.84 |    0.05 |  0.0482 |     - |     - |     152 B |
|                ValueLinq_Ref_Standard_ByIndex |    10 |    260.9 ns |   2.48 ns |     2.20 ns |  2.16 |    0.04 |  0.0482 |     - |     - |     152 B |
|                   ValueLinq_Ref_Stack_ByIndex |    10 |    210.4 ns |   1.45 ns |     1.35 ns |  1.75 |    0.03 |  0.0484 |     - |     - |     152 B |
|         ValueLinq_Ref_SharedPool_Push_ByIndex |    10 |    514.1 ns |   4.12 ns |     3.85 ns |  4.26 |    0.07 |  0.0477 |     - |     - |     152 B |
|         ValueLinq_Ref_SharedPool_Pull_ByIndex |    10 |    434.6 ns |   3.11 ns |     2.76 ns |  3.60 |    0.06 |  0.0482 |     - |     - |     152 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |    10 |    280.2 ns |   2.23 ns |     2.08 ns |  2.32 |    0.03 |  0.0482 |     - |     - |     152 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |    10 |    235.3 ns |   3.27 ns |     3.06 ns |  1.95 |    0.03 |  0.0482 |     - |     - |     152 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |    10 |    515.6 ns |   2.56 ns |     2.27 ns |  4.28 |    0.07 |  0.0477 |     - |     - |     152 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |    10 |    457.0 ns |   2.22 ns |     2.07 ns |  3.79 |    0.06 |  0.0482 |     - |     - |     152 B |
|                                       ForLoop |    10 |    120.6 ns |   1.91 ns |     1.79 ns |  1.00 |    0.00 |  0.1478 |     - |     - |     464 B |
|                                   ForeachLoop |    10 |    165.8 ns |   0.89 ns |     0.83 ns |  1.37 |    0.02 |  0.1478 |     - |     - |     464 B |
|                                          Linq |    10 |    279.6 ns |   4.48 ns |     4.19 ns |  2.32 |    0.05 |  0.2575 |     - |     - |     808 B |
|                                    LinqFaster |    10 |    174.6 ns |   3.51 ns |     3.75 ns |  1.45 |    0.04 |  0.1478 |     - |     - |     464 B |
|                                        LinqAF |    10 |    451.3 ns |   8.87 ns |     9.50 ns |  3.74 |    0.10 |  0.1373 |     - |     - |     432 B |
|                                    StructLinq |    10 |    234.8 ns |   1.78 ns |     1.66 ns |  1.95 |    0.03 |  0.0815 |     - |     - |     256 B |
|                          StructLinq_IFunction |    10 |    172.3 ns |   1.12 ns |     0.94 ns |  1.43 |    0.03 |  0.0484 |     - |     - |     152 B |
|                                     Hyperlinq |    10 |    218.0 ns |   1.63 ns |     1.52 ns |  1.81 |    0.03 |  0.0484 |     - |     - |     152 B |
|                           Hyperlinq_IFunction |    10 |    184.7 ns |   1.91 ns |     1.69 ns |  1.53 |    0.03 |  0.0484 |     - |     - |     152 B |
|                                      Tinyield |    10 |    526.6 ns |   5.91 ns |     5.24 ns |  4.37 |    0.09 |  0.4406 |     - |     - |   1,384 B |
|                                               |       |             |           |             |       |         |         |       |       |           |
|                            **ValueLinq_Standard** |  **1000** | **26,203.4 ns** | **287.42 ns** |   **268.85 ns** |  **1.25** |    **0.01** | **20.3857** |     **-** |     **-** |  **64,080 B** |
|                               ValueLinq_Stack |  1000 | 26,753.3 ns | 227.71 ns |   213.00 ns |  1.28 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|                     ValueLinq_SharedPool_Push |  1000 | 24,811.3 ns | 191.81 ns |   179.42 ns |  1.19 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                     ValueLinq_SharedPool_Pull |  1000 | 23,855.8 ns | 275.11 ns |   257.34 ns |  1.14 |    0.02 | 10.1929 |     - |     - |  32,216 B |
|                        ValueLinq_Ref_Standard |  1000 | 25,134.5 ns | 159.33 ns |   149.04 ns |  1.20 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|                           ValueLinq_Ref_Stack |  1000 | 25,309.2 ns | 155.08 ns |   145.06 ns |  1.21 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|                 ValueLinq_Ref_SharedPool_Push |  1000 | 21,811.3 ns | 261.83 ns |   244.92 ns |  1.04 |    0.02 | 10.1929 |     - |     - |  32,216 B |
|                 ValueLinq_Ref_SharedPool_Pull |  1000 | 23,210.0 ns | 222.42 ns |   197.17 ns |  1.11 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                ValueLinq_ValueLambda_Standard |  1000 | 24,179.6 ns | 240.18 ns |   224.66 ns |  1.16 |    0.02 | 20.3857 |     - |     - |  64,080 B |
|                   ValueLinq_ValueLambda_Stack |  1000 | 24,459.2 ns | 270.37 ns |   252.90 ns |  1.17 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|         ValueLinq_ValueLambda_SharedPool_Push |  1000 | 20,113.3 ns | 179.47 ns |   167.87 ns |  0.96 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |  1000 | 23,005.9 ns | 306.26 ns |   271.49 ns |  1.10 |    0.02 | 10.1929 |     - |     - |  32,216 B |
|                    ValueLinq_Standard_ByIndex |  1000 | 24,257.9 ns | 202.41 ns |   169.02 ns |  1.16 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|                       ValueLinq_Stack_ByIndex |  1000 | 23,859.0 ns | 228.56 ns |   213.79 ns |  1.14 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|             ValueLinq_SharedPool_Push_ByIndex |  1000 | 24,302.5 ns | 370.64 ns |   346.70 ns |  1.16 |    0.02 | 10.1929 |     - |     - |  32,216 B |
|             ValueLinq_SharedPool_Pull_ByIndex |  1000 | 21,996.1 ns | 181.67 ns |   169.94 ns |  1.05 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                ValueLinq_Ref_Standard_ByIndex |  1000 | 20,118.7 ns | 170.73 ns |   151.35 ns |  0.96 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|                   ValueLinq_Ref_Stack_ByIndex |  1000 | 20,637.9 ns | 250.17 ns |   234.01 ns |  0.99 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|         ValueLinq_Ref_SharedPool_Push_ByIndex |  1000 | 21,184.0 ns | 226.79 ns |   212.14 ns |  1.01 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|         ValueLinq_Ref_SharedPool_Pull_ByIndex |  1000 | 17,957.4 ns | 144.48 ns |   135.15 ns |  0.86 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |  1000 | 21,817.9 ns | 354.33 ns |   331.44 ns |  1.04 |    0.02 | 20.3857 |     - |     - |  64,080 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |  1000 | 21,348.9 ns | 242.42 ns |   226.76 ns |  1.02 |    0.02 | 20.3857 |     - |     - |  64,080 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |  1000 | 20,080.6 ns | 166.42 ns |   155.67 ns |  0.96 |    0.01 | 10.1929 |     - |     - |  32,216 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |  1000 | 19,031.6 ns | 275.70 ns |   257.89 ns |  0.91 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                                       ForLoop |  1000 | 20,925.4 ns | 209.53 ns |   195.99 ns |  1.00 |    0.00 | 31.0059 |     - |     - |  97,720 B |
|                                   ForeachLoop |  1000 | 26,320.1 ns | 218.11 ns |   193.35 ns |  1.26 |    0.01 | 31.0059 |     - |     - |  97,720 B |
|                                          Linq |  1000 | 24,880.4 ns | 460.30 ns |   430.57 ns |  1.19 |    0.02 | 20.8130 |     - |     - |  65,952 B |
|                                    LinqFaster |  1000 | 28,701.7 ns | 439.08 ns |   410.72 ns |  1.37 |    0.02 | 31.0059 |     - |     - |  97,720 B |
|                                        LinqAF |  1000 | 48,170.5 ns | 692.61 ns | 1,194.72 ns |  2.32 |    0.08 | 31.0059 |     - |     - |  97,688 B |
|                                    StructLinq |  1000 | 21,372.2 ns | 272.63 ns |   255.02 ns |  1.02 |    0.01 | 10.1929 |     - |     - |  32,320 B |
|                          StructLinq_IFunction |  1000 | 15,187.5 ns | 119.38 ns |   111.67 ns |  0.73 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                                     Hyperlinq |  1000 | 23,102.6 ns | 455.83 ns |   487.73 ns |  1.11 |    0.02 | 10.1929 |     - |     - |  32,216 B |
|                           Hyperlinq_IFunction |  1000 | 16,806.4 ns | 129.64 ns |   121.26 ns |  0.80 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                                      Tinyield |  1000 | 42,224.4 ns | 680.66 ns |   636.69 ns |  2.02 |    0.04 | 31.1890 |     - |     - |  98,640 B |
