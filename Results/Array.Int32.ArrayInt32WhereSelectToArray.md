## Array.Int32.ArrayInt32WhereSelectToArray

### Source
[ArrayInt32WhereSelectToArray.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelectToArray.cs)

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
|                    **ValueLinq_Standard** |    **10** |    **225.21 ns** |  **1.631 ns** |  **1.446 ns** |  **4.81** |    **0.04** | **0.0100** |     **-** |     **-** |      **32 B** |
|                       ValueLinq_Stack |    10 |    180.85 ns |  0.653 ns |  0.579 ns |  3.86 |    0.02 | 0.0100 |     - |     - |      32 B |
|             ValueLinq_SharedPool_Push |    10 |    478.01 ns |  3.542 ns |  3.140 ns | 10.21 |    0.09 | 0.0095 |     - |     - |      32 B |
|             ValueLinq_SharedPool_Pull |    10 |    352.85 ns |  1.486 ns |  1.317 ns |  7.54 |    0.04 | 0.0100 |     - |     - |      32 B |
|        ValueLinq_ValueLambda_Standard |    10 |    202.31 ns |  0.765 ns |  0.678 ns |  4.32 |    0.03 | 0.0100 |     - |     - |      32 B |
|           ValueLinq_ValueLambda_Stack |    10 |    154.01 ns |  0.974 ns |  0.911 ns |  3.29 |    0.03 | 0.0100 |     - |     - |      32 B |
| ValueLinq_ValueLambda_SharedPool_Push |    10 |    391.09 ns |  0.639 ns |  0.533 ns |  8.35 |    0.04 | 0.0100 |     - |     - |      32 B |
| ValueLinq_ValueLambda_SharedPool_Pull |    10 |    367.66 ns |  1.983 ns |  1.758 ns |  7.85 |    0.03 | 0.0100 |     - |     - |      32 B |
|                               ForLoop |    10 |     46.82 ns |  0.252 ns |  0.210 ns |  1.00 |    0.00 | 0.0331 |     - |     - |     104 B |
|                           ForeachLoop |    10 |     46.81 ns |  0.219 ns |  0.205 ns |  1.00 |    0.01 | 0.0331 |     - |     - |     104 B |
|                                  Linq |    10 |    161.63 ns |  0.617 ns |  0.547 ns |  3.45 |    0.02 | 0.0560 |     - |     - |     176 B |
|                            LinqFaster |    10 |     59.05 ns |  0.398 ns |  0.353 ns |  1.26 |    0.01 | 0.0305 |     - |     - |      96 B |
|                                LinqAF |    10 |    145.03 ns |  0.573 ns |  0.478 ns |  3.10 |    0.02 | 0.0229 |     - |     - |      72 B |
|                            StructLinq |    10 |    192.92 ns |  0.844 ns |  0.789 ns |  4.12 |    0.03 | 0.0408 |     - |     - |     128 B |
|                  StructLinq_IFunction |    10 |    126.94 ns |  1.091 ns |  1.020 ns |  2.71 |    0.03 | 0.0100 |     - |     - |      32 B |
|                             Hyperlinq |    10 |    144.48 ns |  0.924 ns |  0.819 ns |  3.09 |    0.02 | 0.0100 |     - |     - |      32 B |
|                   Hyperlinq_IFunction |    10 |    112.45 ns |  0.357 ns |  0.279 ns |  2.40 |    0.02 | 0.0100 |     - |     - |      32 B |
|                              Tinyield |    10 |    317.31 ns |  2.344 ns |  2.078 ns |  6.78 |    0.04 | 0.2980 |     - |     - |     936 B |
|                                       |       |              |           |           |       |         |        |       |       |           |
|                    **ValueLinq_Standard** |  **1000** |  **8,582.08 ns** | **49.707 ns** | **44.064 ns** |  **2.42** |    **0.02** | **1.3123** |     **-** |     **-** |   **4,144 B** |
|                       ValueLinq_Stack |  1000 |  9,742.12 ns | 41.199 ns | 38.537 ns |  2.75 |    0.02 | 1.3123 |     - |     - |   4,144 B |
|             ValueLinq_SharedPool_Push |  1000 |  7,576.85 ns | 54.187 ns | 48.035 ns |  2.14 |    0.01 | 0.6485 |     - |     - |   2,040 B |
|             ValueLinq_SharedPool_Pull |  1000 | 10,059.73 ns | 51.940 ns | 48.584 ns |  2.84 |    0.02 | 0.6409 |     - |     - |   2,040 B |
|        ValueLinq_ValueLambda_Standard |  1000 |  3,547.18 ns | 34.582 ns | 32.348 ns |  1.00 |    0.01 | 1.3199 |     - |     - |   4,144 B |
|           ValueLinq_ValueLambda_Stack |  1000 |  3,463.29 ns | 26.625 ns | 24.905 ns |  0.98 |    0.01 | 1.3199 |     - |     - |   4,144 B |
| ValueLinq_ValueLambda_SharedPool_Push |  1000 |  4,716.99 ns | 32.270 ns | 30.186 ns |  1.33 |    0.01 | 0.6485 |     - |     - |   2,040 B |
| ValueLinq_ValueLambda_SharedPool_Pull |  1000 |  3,800.68 ns | 30.577 ns | 28.602 ns |  1.07 |    0.01 | 0.6485 |     - |     - |   2,040 B |
|                               ForLoop |  1000 |  3,540.26 ns | 28.270 ns | 25.061 ns |  1.00 |    0.00 | 2.0218 |     - |     - |   6,344 B |
|                           ForeachLoop |  1000 |  3,485.65 ns | 17.703 ns | 15.693 ns |  0.98 |    0.01 | 2.0218 |     - |     - |   6,344 B |
|                                  Linq |  1000 |  6,935.44 ns | 32.694 ns | 30.582 ns |  1.96 |    0.01 | 1.4420 |     - |     - |   4,544 B |
|                            LinqFaster |  1000 |  6,021.72 ns | 41.371 ns | 38.698 ns |  1.70 |    0.02 | 1.9302 |     - |     - |   6,064 B |
|                                LinqAF |  1000 | 10,997.07 ns | 60.144 ns | 56.258 ns |  3.11 |    0.03 | 1.9989 |     - |     - |   6,312 B |
|                            StructLinq |  1000 |  7,490.27 ns | 39.438 ns | 36.890 ns |  2.12 |    0.01 | 0.6790 |     - |     - |   2,136 B |
|                  StructLinq_IFunction |  1000 |  4,199.87 ns | 33.426 ns | 31.266 ns |  1.19 |    0.01 | 0.6485 |     - |     - |   2,040 B |
|                             Hyperlinq |  1000 |  6,283.74 ns | 31.258 ns | 26.102 ns |  1.78 |    0.02 | 0.6485 |     - |     - |   2,040 B |
|                   Hyperlinq_IFunction |  1000 |  4,996.21 ns | 15.325 ns | 13.585 ns |  1.41 |    0.01 | 0.6485 |     - |     - |   2,040 B |
|                              Tinyield |  1000 | 12,311.15 ns | 48.111 ns | 45.003 ns |  3.48 |    0.02 | 2.2736 |     - |     - |   7,176 B |
