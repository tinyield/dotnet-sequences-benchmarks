## Range.RangeSelectToArray

### Source
[RangeSelectToArray.cs](../LinqBenchmarks/Range/RangeSelectToArray.cs)

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
|                                Method | Start | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |------ |-------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|                    **ValueLinq_Standard** |     **0** |    **10** |    **146.86 ns** |   **0.456 ns** |   **0.404 ns** | **10.20** |    **0.11** | **0.0203** |     **-** |     **-** |      **64 B** |
|                       ValueLinq_Stack |     0 |    10 |    122.00 ns |   0.772 ns |   0.722 ns |  8.47 |    0.13 | 0.0203 |     - |     - |      64 B |
|             ValueLinq_SharedPool_Push |     0 |    10 |    422.78 ns |   1.422 ns |   1.187 ns | 29.35 |    0.37 | 0.0200 |     - |     - |      64 B |
|             ValueLinq_SharedPool_Pull |     0 |    10 |    289.37 ns |   1.027 ns |   0.802 ns | 20.08 |    0.25 | 0.0200 |     - |     - |      64 B |
|        ValueLinq_ValueLambda_Standard |     0 |    10 |    131.47 ns |   0.700 ns |   0.585 ns |  9.13 |    0.12 | 0.0203 |     - |     - |      64 B |
|           ValueLinq_ValueLambda_Stack |     0 |    10 |    109.41 ns |   0.559 ns |   0.495 ns |  7.60 |    0.08 | 0.0204 |     - |     - |      64 B |
| ValueLinq_ValueLambda_SharedPool_Push |     0 |    10 |    311.48 ns |   2.024 ns |   1.690 ns | 21.62 |    0.28 | 0.0200 |     - |     - |      64 B |
| ValueLinq_ValueLambda_SharedPool_Pull |     0 |    10 |    279.44 ns |   1.732 ns |   1.446 ns | 19.40 |    0.23 | 0.0200 |     - |     - |      64 B |
|                               ForLoop |     0 |    10 |     14.41 ns |   0.185 ns |   0.164 ns |  1.00 |    0.00 | 0.0204 |     - |     - |      64 B |
|                                  Linq |     0 |    10 |     88.43 ns |   0.851 ns |   0.796 ns |  6.14 |    0.06 | 0.0484 |     - |     - |     152 B |
|                            LinqFaster |     0 |    10 |     49.41 ns |   0.393 ns |   0.368 ns |  3.43 |    0.05 | 0.0408 |     - |     - |     128 B |
|                       LinqFaster_SIMD |     0 |    10 |     44.06 ns |   0.291 ns |   0.272 ns |  3.06 |    0.04 | 0.0408 |     - |     - |     128 B |
|                                LinqAF |     0 |    10 |    215.91 ns |   1.589 ns |   1.486 ns | 15.00 |    0.19 | 0.0789 |     - |     - |     248 B |
|                            StructLinq |     0 |    10 |     64.55 ns |   0.459 ns |   0.407 ns |  4.48 |    0.06 | 0.0381 |     - |     - |     120 B |
|                  StructLinq_IFunction |     0 |    10 |     38.28 ns |   0.210 ns |   0.197 ns |  2.66 |    0.04 | 0.0204 |     - |     - |      64 B |
|                             Hyperlinq |     0 |    10 |     69.82 ns |   0.397 ns |   0.352 ns |  4.85 |    0.05 | 0.0203 |     - |     - |      64 B |
|                   Hyperlinq_IFunction |     0 |    10 |     52.75 ns |   0.137 ns |   0.122 ns |  3.66 |    0.05 | 0.0203 |     - |     - |      64 B |
|                        Hyperlinq_SIMD |     0 |    10 |     54.02 ns |   0.276 ns |   0.245 ns |  3.75 |    0.04 | 0.0204 |     - |     - |      64 B |
|              Hyperlinq_IFunction_SIMD |     0 |    10 |     38.47 ns |   0.206 ns |   0.172 ns |  2.67 |    0.03 | 0.0203 |     - |     - |      64 B |
|                              Tinyield |     0 |    10 |    405.22 ns |   2.072 ns |   1.837 ns | 28.13 |    0.31 | 0.3233 |     - |     - |   1,016 B |
|                                       |       |       |              |            |            |       |         |        |       |       |           |
|                    **ValueLinq_Standard** |     **0** |  **1000** |  **2,735.71 ns** |  **14.763 ns** |  **13.087 ns** |  **2.19** |    **0.02** | **1.2817** |     **-** |     **-** |   **4,024 B** |
|                       ValueLinq_Stack |     0 |  1000 |  5,523.80 ns |  25.584 ns |  22.680 ns |  4.42 |    0.03 | 2.6093 |     - |     - |   8,200 B |
|             ValueLinq_SharedPool_Push |     0 |  1000 |  4,396.82 ns |  22.087 ns |  18.444 ns |  3.52 |    0.03 | 1.2817 |     - |     - |   4,024 B |
|             ValueLinq_SharedPool_Pull |     0 |  1000 |  4,861.94 ns |  13.820 ns |  12.927 ns |  3.89 |    0.03 | 1.2817 |     - |     - |   4,024 B |
|        ValueLinq_ValueLambda_Standard |     0 |  1000 |  2,702.38 ns |  13.520 ns |  12.647 ns |  2.16 |    0.01 | 1.2817 |     - |     - |   4,024 B |
|           ValueLinq_ValueLambda_Stack |     0 |  1000 |  3,548.20 ns |  19.699 ns |  18.426 ns |  2.84 |    0.03 | 2.6093 |     - |     - |   8,200 B |
| ValueLinq_ValueLambda_SharedPool_Push |     0 |  1000 |  3,496.52 ns |  29.580 ns |  27.669 ns |  2.80 |    0.03 | 1.2817 |     - |     - |   4,024 B |
| ValueLinq_ValueLambda_SharedPool_Pull |     0 |  1000 |  3,411.82 ns |  21.329 ns |  19.951 ns |  2.73 |    0.02 | 1.2817 |     - |     - |   4,024 B |
|                               ForLoop |     0 |  1000 |  1,249.20 ns |   7.828 ns |   7.322 ns |  1.00 |    0.00 | 1.2817 |     - |     - |   4,024 B |
|                                  Linq |     0 |  1000 |  3,006.18 ns |  32.856 ns |  30.734 ns |  2.41 |    0.03 | 1.3084 |     - |     - |   4,112 B |
|                            LinqFaster |     0 |  1000 |  3,668.05 ns |  25.512 ns |  23.864 ns |  2.94 |    0.03 | 2.5635 |     - |     - |   8,048 B |
|                       LinqFaster_SIMD |     0 |  1000 |  1,252.65 ns |  15.058 ns |  14.085 ns |  1.00 |    0.01 | 2.5635 |     - |     - |   8,048 B |
|                                LinqAF |     0 |  1000 |  8,409.87 ns |  67.809 ns |  63.429 ns |  6.73 |    0.07 | 3.9520 |     - |     - |  12,416 B |
|                            StructLinq |     0 |  1000 |  2,967.53 ns |  15.937 ns |  14.908 ns |  2.38 |    0.01 | 1.2970 |     - |     - |   4,080 B |
|                  StructLinq_IFunction |     0 |  1000 |  1,112.26 ns |  12.092 ns |  10.719 ns |  0.89 |    0.01 | 1.2817 |     - |     - |   4,024 B |
|                             Hyperlinq |     0 |  1000 |  3,007.93 ns |  17.669 ns |  16.528 ns |  2.41 |    0.02 | 1.2817 |     - |     - |   4,024 B |
|                   Hyperlinq_IFunction |     0 |  1000 |  1,357.93 ns |  13.833 ns |  12.939 ns |  1.09 |    0.01 | 1.2817 |     - |     - |   4,024 B |
|                        Hyperlinq_SIMD |     0 |  1000 |    706.60 ns |   6.433 ns |   6.018 ns |  0.57 |    0.01 | 1.2779 |     - |     - |   4,024 B |
|              Hyperlinq_IFunction_SIMD |     0 |  1000 |    429.98 ns |   4.687 ns |   4.385 ns |  0.34 |    0.00 | 1.2784 |     - |     - |   4,024 B |
|                              Tinyield |     0 |  1000 | 12,566.20 ns | 138.980 ns | 130.002 ns | 10.06 |    0.12 | 4.1962 |     - |     - |  13,184 B |
