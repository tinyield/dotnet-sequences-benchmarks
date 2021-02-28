## Array.ValueType.ArrayValueTypeWhereSelectToArray

### Source
[ArrayValueTypeWhereSelectToArray.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelectToArray.cs)

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
|                                Method | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |------------:|----------:|----------:|------:|--------:|--------:|------:|------:|----------:|
|                    **ValueLinq_Standard** |    **10** |    **271.9 ns** |   **1.52 ns** |   **1.35 ns** |  **2.54** |    **0.02** |  **0.0482** |     **-** |     **-** |     **152 B** |
|                       ValueLinq_Stack |    10 |    220.6 ns |   1.41 ns |   1.32 ns |  2.06 |    0.02 |  0.0484 |     - |     - |     152 B |
|             ValueLinq_SharedPool_Push |    10 |    587.2 ns |   3.67 ns |   3.43 ns |  5.48 |    0.04 |  0.0477 |     - |     - |     152 B |
|             ValueLinq_SharedPool_Pull |    10 |    433.1 ns |   2.37 ns |   2.10 ns |  4.04 |    0.03 |  0.0482 |     - |     - |     152 B |
|                ValueLinq_Ref_Standard |    10 |    250.8 ns |   1.43 ns |   1.27 ns |  2.34 |    0.02 |  0.0482 |     - |     - |     152 B |
|                   ValueLinq_Ref_Stack |    10 |    206.1 ns |   1.32 ns |   1.24 ns |  1.93 |    0.02 |  0.0484 |     - |     - |     152 B |
|         ValueLinq_Ref_SharedPool_Push |    10 |    475.0 ns |   2.19 ns |   1.94 ns |  4.44 |    0.04 |  0.0477 |     - |     - |     152 B |
|         ValueLinq_Ref_SharedPool_Pull |    10 |    426.3 ns |   2.29 ns |   2.03 ns |  3.98 |    0.03 |  0.0482 |     - |     - |     152 B |
|        ValueLinq_ValueLambda_Standard |    10 |    277.3 ns |   4.16 ns |   3.89 ns |  2.59 |    0.05 |  0.0482 |     - |     - |     152 B |
|           ValueLinq_ValueLambda_Stack |    10 |    235.3 ns |   1.26 ns |   1.12 ns |  2.20 |    0.02 |  0.0484 |     - |     - |     152 B |
| ValueLinq_ValueLambda_SharedPool_Push |    10 |    482.9 ns |   2.75 ns |   2.57 ns |  4.51 |    0.04 |  0.0477 |     - |     - |     152 B |
| ValueLinq_ValueLambda_SharedPool_Pull |    10 |    452.3 ns |   3.38 ns |   3.17 ns |  4.22 |    0.05 |  0.0482 |     - |     - |     152 B |
|                               ForLoop |    10 |    107.1 ns |   0.91 ns |   0.81 ns |  1.00 |    0.00 |  0.1478 |     - |     - |     464 B |
|                           ForeachLoop |    10 |    116.8 ns |   1.31 ns |   1.22 ns |  1.09 |    0.01 |  0.1478 |     - |     - |     464 B |
|                                  Linq |    10 |    244.3 ns |   3.84 ns |   3.59 ns |  2.28 |    0.04 |  0.2065 |     - |     - |     648 B |
|                            LinqFaster |    10 |    144.3 ns |   2.07 ns |   1.73 ns |  1.35 |    0.01 |  0.2601 |     - |     - |     816 B |
|                                LinqAF |    10 |    342.7 ns |   6.66 ns |   8.43 ns |  3.19 |    0.09 |  0.1373 |     - |     - |     432 B |
|                            StructLinq |    10 |    217.0 ns |   0.85 ns |   0.75 ns |  2.03 |    0.01 |  0.0789 |     - |     - |     248 B |
|                  StructLinq_IFunction |    10 |    172.6 ns |   1.32 ns |   1.17 ns |  1.61 |    0.02 |  0.0484 |     - |     - |     152 B |
|                             Hyperlinq |    10 |    222.8 ns |   2.30 ns |   2.04 ns |  2.08 |    0.03 |  0.0484 |     - |     - |     152 B |
|                   Hyperlinq_IFunction |    10 |    182.4 ns |   1.64 ns |   1.53 ns |  1.70 |    0.01 |  0.0484 |     - |     - |     152 B |
|                              Tinyield |    10 |    381.3 ns |   3.61 ns |   3.38 ns |  3.56 |    0.04 |  0.4129 |     - |     - |   1,296 B |
|                                       |       |             |           |           |       |         |         |       |       |           |
|                    **ValueLinq_Standard** |  **1000** | **21,467.6 ns** | **145.59 ns** | **136.18 ns** |  **1.11** |    **0.01** | **20.3857** |     **-** |     **-** |  **64,080 B** |
|                       ValueLinq_Stack |  1000 | 20,822.0 ns | 155.86 ns | 145.79 ns |  1.08 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|             ValueLinq_SharedPool_Push |  1000 | 24,222.2 ns | 173.39 ns | 153.70 ns |  1.26 |    0.02 | 10.1929 |     - |     - |  32,216 B |
|             ValueLinq_SharedPool_Pull |  1000 | 19,181.5 ns | 134.08 ns | 125.42 ns |  0.99 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                ValueLinq_Ref_Standard |  1000 | 21,002.2 ns | 242.93 ns | 215.35 ns |  1.09 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|                   ValueLinq_Ref_Stack |  1000 | 20,515.7 ns | 115.11 ns | 107.68 ns |  1.06 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|         ValueLinq_Ref_SharedPool_Push |  1000 | 21,203.6 ns | 136.12 ns | 120.67 ns |  1.10 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|         ValueLinq_Ref_SharedPool_Pull |  1000 | 20,365.6 ns | 134.89 ns | 126.17 ns |  1.06 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|        ValueLinq_ValueLambda_Standard |  1000 | 32,952.6 ns | 224.39 ns | 209.89 ns |  1.71 |    0.01 | 20.3857 |     - |     - |  64,080 B |
|           ValueLinq_ValueLambda_Stack |  1000 | 21,179.1 ns | 191.32 ns | 178.96 ns |  1.10 |    0.01 | 20.3857 |     - |     - |  64,080 B |
| ValueLinq_ValueLambda_SharedPool_Push |  1000 | 19,841.9 ns | 165.69 ns | 154.98 ns |  1.03 |    0.01 | 10.1929 |     - |     - |  32,216 B |
| ValueLinq_ValueLambda_SharedPool_Pull |  1000 | 19,000.2 ns | 199.23 ns | 186.36 ns |  0.99 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                               ForLoop |  1000 | 19,288.0 ns | 165.06 ns | 154.40 ns |  1.00 |    0.00 | 31.0059 |     - |     - |  97,720 B |
|                           ForeachLoop |  1000 | 21,730.9 ns | 252.98 ns | 236.64 ns |  1.13 |    0.02 | 31.0059 |     - |     - |  97,720 B |
|                                  Linq |  1000 | 23,751.4 ns | 293.60 ns | 274.63 ns |  1.23 |    0.02 | 20.8130 |     - |     - |  65,792 B |
|                            LinqFaster |  1000 | 19,635.7 ns | 126.71 ns | 118.52 ns |  1.02 |    0.01 | 30.2734 |     - |     - |  96,240 B |
|                                LinqAF |  1000 | 39,880.0 ns | 734.56 ns | 687.11 ns |  2.07 |    0.04 | 31.0059 |     - |     - |  97,688 B |
|                            StructLinq |  1000 | 20,309.0 ns | 190.48 ns | 178.18 ns |  1.05 |    0.01 | 10.1929 |     - |     - |  32,312 B |
|                  StructLinq_IFunction |  1000 | 14,840.0 ns |  75.19 ns |  62.78 ns |  0.77 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                             Hyperlinq |  1000 | 22,988.5 ns | 306.63 ns | 286.82 ns |  1.19 |    0.02 | 10.1929 |     - |     - |  32,216 B |
|                   Hyperlinq_IFunction |  1000 | 16,410.1 ns | 100.12 ns |  93.66 ns |  0.85 |    0.01 | 10.1929 |     - |     - |  32,216 B |
|                              Tinyield |  1000 | 31,975.1 ns | 239.35 ns | 212.17 ns |  1.66 |    0.02 | 31.1890 |     - |     - |  98,552 B |
