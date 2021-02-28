## List.Int32.ListInt32WhereSelectToArray

### Source
[ListInt32WhereSelectToArray.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelectToArray.cs)

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
|                                        Method | Count |         Mean |      Error |       StdDev |       Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------------------------- |------ |-------------:|-----------:|-------------:|-------------:|------:|--------:|-------:|------:|------:|----------:|
|                            **ValueLinq_Standard** |    **10** |    **260.78 ns** |   **1.481 ns** |     **1.313 ns** |    **260.46 ns** |  **5.14** |    **0.02** | **0.0100** |     **-** |     **-** |      **32 B** |
|                               ValueLinq_Stack |    10 |    203.79 ns |   1.148 ns |     1.074 ns |    203.44 ns |  4.02 |    0.04 | 0.0100 |     - |     - |      32 B |
|                     ValueLinq_SharedPool_Push |    10 |    495.36 ns |   2.955 ns |     2.467 ns |    495.18 ns |  9.76 |    0.05 | 0.0095 |     - |     - |      32 B |
|                     ValueLinq_SharedPool_Pull |    10 |    383.63 ns |   1.557 ns |     1.380 ns |    383.52 ns |  7.55 |    0.04 | 0.0100 |     - |     - |      32 B |
|                ValueLinq_ValueLambda_Standard |    10 |    238.20 ns |   1.203 ns |     1.126 ns |    238.13 ns |  4.69 |    0.03 | 0.0100 |     - |     - |      32 B |
|                   ValueLinq_ValueLambda_Stack |    10 |    180.28 ns |   1.423 ns |     1.331 ns |    179.91 ns |  3.55 |    0.03 | 0.0100 |     - |     - |      32 B |
|         ValueLinq_ValueLambda_SharedPool_Push |    10 |    395.28 ns |   1.800 ns |     1.503 ns |    395.04 ns |  7.79 |    0.04 | 0.0100 |     - |     - |      32 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |    10 |    376.34 ns |   3.018 ns |     2.676 ns |    375.52 ns |  7.41 |    0.07 | 0.0100 |     - |     - |      32 B |
|                    ValueLinq_Standard_ByIndex |    10 |    226.04 ns |   2.627 ns |     2.457 ns |    224.82 ns |  4.45 |    0.05 | 0.0100 |     - |     - |      32 B |
|                       ValueLinq_Stack_ByIndex |    10 |    173.36 ns |   0.525 ns |     0.410 ns |    173.39 ns |  3.41 |    0.02 | 0.0100 |     - |     - |      32 B |
|             ValueLinq_SharedPool_Push_ByIndex |    10 |    512.59 ns |   1.486 ns |     1.390 ns |    512.65 ns | 10.10 |    0.06 | 0.0095 |     - |     - |      32 B |
|             ValueLinq_SharedPool_Pull_ByIndex |    10 |    362.14 ns |   1.235 ns |     1.095 ns |    362.36 ns |  7.13 |    0.05 | 0.0100 |     - |     - |      32 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |    10 |    206.23 ns |   1.331 ns |     1.245 ns |    206.06 ns |  4.06 |    0.03 | 0.0100 |     - |     - |      32 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |    10 |    172.44 ns |   0.669 ns |     0.522 ns |    172.31 ns |  3.40 |    0.02 | 0.0100 |     - |     - |      32 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |    10 |    406.00 ns |   1.510 ns |     1.413 ns |    405.65 ns |  8.00 |    0.05 | 0.0100 |     - |     - |      32 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |    10 |    339.46 ns |   1.383 ns |     1.226 ns |    339.23 ns |  6.68 |    0.04 | 0.0100 |     - |     - |      32 B |
|                                       ForLoop |    10 |     50.75 ns |   0.273 ns |     0.256 ns |     50.81 ns |  1.00 |    0.00 | 0.0331 |     - |     - |     104 B |
|                                   ForeachLoop |    10 |     72.97 ns |   0.688 ns |     0.644 ns |     72.83 ns |  1.44 |    0.01 | 0.0331 |     - |     - |     104 B |
|                                          Linq |    10 |    180.12 ns |   1.732 ns |     1.447 ns |    180.08 ns |  3.55 |    0.03 | 0.0713 |     - |     - |     224 B |
|                                    LinqFaster |    10 |     86.24 ns |   0.409 ns |     0.382 ns |     86.17 ns |  1.70 |    0.01 | 0.0330 |     - |     - |     104 B |
|                                        LinqAF |    10 |    236.61 ns |   4.700 ns |     7.035 ns |    238.35 ns |  4.58 |    0.15 | 0.0226 |     - |     - |      72 B |
|                                    StructLinq |    10 |    201.70 ns |   4.127 ns |     4.238 ns |    201.92 ns |  3.98 |    0.09 | 0.0408 |     - |     - |     128 B |
|                          StructLinq_IFunction |    10 |    135.14 ns |   1.922 ns |     1.704 ns |    135.17 ns |  2.66 |    0.03 | 0.0100 |     - |     - |      32 B |
|                                     Hyperlinq |    10 |    154.69 ns |   3.208 ns |     3.565 ns |    154.42 ns |  3.03 |    0.07 | 0.0100 |     - |     - |      32 B |
|                           Hyperlinq_IFunction |    10 |    119.10 ns |   1.549 ns |     1.449 ns |    119.07 ns |  2.35 |    0.03 | 0.0100 |     - |     - |      32 B |
|                                      Tinyield |    10 |    457.22 ns |   7.342 ns |     6.508 ns |    458.08 ns |  9.00 |    0.15 | 0.3080 |     - |     - |     968 B |
|                                               |       |              |            |              |              |       |         |        |       |       |           |
|                            **ValueLinq_Standard** |  **1000** | **11,510.34 ns** | **174.170 ns** |   **162.919 ns** | **11,460.20 ns** |  **2.50** |    **0.05** | **1.3123** |     **-** |     **-** |   **4,144 B** |
|                               ValueLinq_Stack |  1000 | 10,727.94 ns | 171.506 ns |   152.036 ns | 10,771.46 ns |  2.33 |    0.04 | 1.3123 |     - |     - |   4,144 B |
|                     ValueLinq_SharedPool_Push |  1000 |  7,729.49 ns |  75.462 ns |    66.895 ns |  7,711.17 ns |  1.68 |    0.02 | 0.6485 |     - |     - |   2,040 B |
|                     ValueLinq_SharedPool_Pull |  1000 | 10,663.59 ns | 162.121 ns |   151.648 ns | 10,638.33 ns |  2.32 |    0.04 | 0.6409 |     - |     - |   2,040 B |
|                ValueLinq_ValueLambda_Standard |  1000 | 11,104.42 ns | 110.205 ns |   103.086 ns | 11,132.58 ns |  2.41 |    0.04 | 1.3123 |     - |     - |   4,144 B |
|                   ValueLinq_ValueLambda_Stack |  1000 | 10,601.77 ns | 211.836 ns |   235.455 ns | 10,461.21 ns |  2.31 |    0.07 | 1.3123 |     - |     - |   4,144 B |
|         ValueLinq_ValueLambda_SharedPool_Push |  1000 |  3,807.41 ns |  37.375 ns |    34.960 ns |  3,816.67 ns |  0.83 |    0.01 | 0.6485 |     - |     - |   2,040 B |
|         ValueLinq_ValueLambda_SharedPool_Pull |  1000 | 11,400.05 ns |  47.467 ns |    42.078 ns | 11,410.27 ns |  2.48 |    0.03 | 0.6409 |     - |     - |   2,040 B |
|                    ValueLinq_Standard_ByIndex |  1000 |  8,112.95 ns |  65.389 ns |    61.165 ns |  8,109.68 ns |  1.76 |    0.02 | 1.3123 |     - |     - |   4,144 B |
|                       ValueLinq_Stack_ByIndex |  1000 |  7,895.59 ns |  81.749 ns |    72.468 ns |  7,890.63 ns |  1.72 |    0.02 | 1.3123 |     - |     - |   4,144 B |
|             ValueLinq_SharedPool_Push_ByIndex |  1000 |  7,693.00 ns |  32.086 ns |    28.443 ns |  7,690.40 ns |  1.67 |    0.02 | 0.6409 |     - |     - |   2,040 B |
|             ValueLinq_SharedPool_Pull_ByIndex |  1000 |  8,289.89 ns |  52.420 ns |    49.034 ns |  8,278.16 ns |  1.80 |    0.02 | 0.6409 |     - |     - |   2,040 B |
|        ValueLinq_ValueLambda_Standard_ByIndex |  1000 |  3,438.47 ns |  17.682 ns |    16.540 ns |  3,436.22 ns |  0.75 |    0.01 | 1.3199 |     - |     - |   4,144 B |
|           ValueLinq_ValueLambda_Stack_ByIndex |  1000 |  4,618.87 ns |  48.384 ns |    42.891 ns |  4,612.25 ns |  1.00 |    0.01 | 1.3199 |     - |     - |   4,144 B |
| ValueLinq_ValueLambda_SharedPool_Push_ByIndex |  1000 |  3,928.62 ns |  22.175 ns |    19.658 ns |  3,924.79 ns |  0.85 |    0.01 | 0.6485 |     - |     - |   2,040 B |
| ValueLinq_ValueLambda_SharedPool_Pull_ByIndex |  1000 |  3,351.46 ns |  20.428 ns |    18.109 ns |  3,354.29 ns |  0.73 |    0.01 | 0.6485 |     - |     - |   2,040 B |
|                                       ForLoop |  1000 |  4,604.01 ns |  43.553 ns |    40.740 ns |  4,597.75 ns |  1.00 |    0.00 | 2.0218 |     - |     - |   6,344 B |
|                                   ForeachLoop |  1000 |  6,127.38 ns |  58.861 ns |    55.058 ns |  6,131.77 ns |  1.33 |    0.02 | 2.0218 |     - |     - |   6,344 B |
|                                          Linq |  1000 |  7,783.61 ns |  99.229 ns |    87.964 ns |  7,752.26 ns |  1.69 |    0.02 | 1.4496 |     - |     - |   4,592 B |
|                                    LinqFaster |  1000 |  8,172.65 ns |  48.229 ns |    45.114 ns |  8,173.06 ns |  1.78 |    0.02 | 2.0142 |     - |     - |   6,344 B |
|                                        LinqAF |  1000 | 31,500.00 ns | 831.080 ns | 2,316.720 ns | 30,450.00 ns |  7.15 |    0.62 |      - |     - |     - |   6,312 B |
|                                    StructLinq |  1000 |  7,462.80 ns |  31.664 ns |    29.618 ns |  7,460.27 ns |  1.62 |    0.02 | 0.6790 |     - |     - |   2,136 B |
|                          StructLinq_IFunction |  1000 |  4,108.30 ns |  31.725 ns |    29.676 ns |  4,101.28 ns |  0.89 |    0.01 | 0.6485 |     - |     - |   2,040 B |
|                                     Hyperlinq |  1000 |  6,722.33 ns |  39.858 ns |    37.283 ns |  6,719.36 ns |  1.46 |    0.02 | 0.6485 |     - |     - |   2,040 B |
|                           Hyperlinq_IFunction |  1000 |  5,240.05 ns |  25.398 ns |    22.514 ns |  5,230.84 ns |  1.14 |    0.01 | 0.6485 |     - |     - |   2,040 B |
|                                      Tinyield |  1000 | 20,833.88 ns |  96.214 ns |    89.999 ns | 20,821.28 ns |  4.53 |    0.04 | 2.2888 |     - |     - |   7,208 B |
