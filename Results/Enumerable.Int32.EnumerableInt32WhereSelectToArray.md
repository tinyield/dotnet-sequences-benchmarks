## Enumerable.Int32.EnumerableInt32WhereSelectToArray

### Source
[EnumerableInt32WhereSelectToArray.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelectToArray.cs)

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
|                                Method | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------------------- |------ |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                    **ValueLinq_Standard** |    **10** |    **351.7 ns** |   **1.69 ns** |   **1.49 ns** |  **2.34** |    **0.03** | **0.0277** |     **-** |     **-** |      **88 B** |
|                       ValueLinq_Stack |    10 |    296.5 ns |   1.82 ns |   1.61 ns |  1.97 |    0.03 | 0.0277 |     - |     - |      88 B |
|             ValueLinq_SharedPool_Push |    10 |    636.8 ns |   3.38 ns |   2.99 ns |  4.23 |    0.05 | 0.0277 |     - |     - |      88 B |
|             ValueLinq_SharedPool_Pull |    10 |    507.4 ns |   3.51 ns |   3.28 ns |  3.37 |    0.05 | 0.0277 |     - |     - |      88 B |
|        ValueLinq_ValueLambda_Standard |    10 |    304.0 ns |   1.27 ns |   1.12 ns |  2.02 |    0.02 | 0.0277 |     - |     - |      88 B |
|           ValueLinq_ValueLambda_Stack |    10 |    274.4 ns |   1.63 ns |   1.45 ns |  1.82 |    0.02 | 0.0277 |     - |     - |      88 B |
| ValueLinq_ValueLambda_SharedPool_Push |    10 |    518.4 ns |   4.42 ns |   4.13 ns |  3.44 |    0.03 | 0.0277 |     - |     - |      88 B |
| ValueLinq_ValueLambda_SharedPool_Pull |    10 |    446.7 ns |   3.14 ns |   2.94 ns |  2.97 |    0.04 | 0.0277 |     - |     - |      88 B |
|                           ForeachLoop |    10 |    150.6 ns |   1.87 ns |   1.75 ns |  1.00 |    0.00 | 0.0687 |     - |     - |     216 B |
|                                  Linq |    10 |    297.2 ns |   1.14 ns |   0.89 ns |  1.98 |    0.02 | 0.0968 |     - |     - |     304 B |
|                                LinqAF |    10 |    295.7 ns |   1.07 ns |   0.95 ns |  1.97 |    0.02 | 0.0587 |     - |     - |     184 B |
|                            StructLinq |    10 |    289.8 ns |   1.98 ns |   1.76 ns |  1.93 |    0.03 | 0.0558 |     - |     - |     176 B |
|                  StructLinq_IFunction |    10 |    219.2 ns |   0.62 ns |   0.52 ns |  1.46 |    0.02 | 0.0279 |     - |     - |      88 B |
|                             Hyperlinq |    10 |    245.7 ns |   1.60 ns |   1.33 ns |  1.63 |    0.03 | 0.0277 |     - |     - |      88 B |
|                   Hyperlinq_IFunction |    10 |    191.0 ns |   1.77 ns |   1.66 ns |  1.27 |    0.02 | 0.0279 |     - |     - |      88 B |
|                              Tinyield |    10 |    452.8 ns |   3.40 ns |   3.18 ns |  3.01 |    0.04 | 0.3314 |     - |     - |   1,040 B |
|                                       |       |             |           |           |       |         |        |       |       |           |
|                    **ValueLinq_Standard** |  **1000** | **11,671.0 ns** |  **53.19 ns** |  **49.76 ns** |  **1.46** |    **0.01** | **1.3275** |     **-** |     **-** |   **4,168 B** |
|                       ValueLinq_Stack |  1000 | 10,664.7 ns |  75.33 ns |  62.90 ns |  1.34 |    0.01 | 1.3275 |     - |     - |   4,168 B |
|             ValueLinq_SharedPool_Push |  1000 | 11,927.6 ns |  74.05 ns |  69.27 ns |  1.50 |    0.01 | 0.6561 |     - |     - |   2,064 B |
|             ValueLinq_SharedPool_Pull |  1000 | 10,777.5 ns |  71.89 ns |  67.25 ns |  1.35 |    0.01 | 0.6561 |     - |     - |   2,064 B |
|        ValueLinq_ValueLambda_Standard |  1000 |  8,564.2 ns |  59.72 ns |  55.86 ns |  1.07 |    0.01 | 1.3275 |     - |     - |   4,168 B |
|           ValueLinq_ValueLambda_Stack |  1000 |  8,173.9 ns |  34.38 ns |  28.71 ns |  1.03 |    0.00 | 1.3275 |     - |     - |   4,168 B |
| ValueLinq_ValueLambda_SharedPool_Push |  1000 |  8,867.9 ns |  72.54 ns |  67.85 ns |  1.11 |    0.01 | 0.6561 |     - |     - |   2,064 B |
| ValueLinq_ValueLambda_SharedPool_Pull |  1000 |  8,229.5 ns |  42.22 ns |  37.42 ns |  1.03 |    0.01 | 0.6561 |     - |     - |   2,064 B |
|                           ForeachLoop |  1000 |  7,973.0 ns |  43.00 ns |  38.12 ns |  1.00 |    0.00 | 2.0294 |     - |     - |   6,368 B |
|                                  Linq |  1000 | 11,839.7 ns |  82.40 ns |  77.08 ns |  1.49 |    0.01 | 1.4496 |     - |     - |   4,584 B |
|                                LinqAF |  1000 | 12,721.8 ns |  61.76 ns |  57.77 ns |  1.60 |    0.01 | 2.0142 |     - |     - |   6,336 B |
|                            StructLinq |  1000 | 10,319.1 ns |  59.52 ns |  55.67 ns |  1.29 |    0.01 | 0.6714 |     - |     - |   2,152 B |
|                  StructLinq_IFunction |  1000 |  8,670.0 ns |  62.71 ns |  55.59 ns |  1.09 |    0.01 | 0.6561 |     - |     - |   2,064 B |
|                             Hyperlinq |  1000 | 11,539.8 ns |  93.03 ns |  87.02 ns |  1.45 |    0.02 | 0.6561 |     - |     - |   2,064 B |
|                   Hyperlinq_IFunction |  1000 |  7,829.4 ns |  60.21 ns |  56.32 ns |  0.98 |    0.01 | 0.6561 |     - |     - |   2,064 B |
|                              Tinyield |  1000 | 14,398.7 ns | 275.49 ns | 294.77 ns |  1.81 |    0.04 | 2.2888 |     - |     - |   7,192 B |
