## List.Int32.ListInt32Select

### Source
[ListInt32Select.cs](../LinqBenchmarks/List/Int32/ListInt32Select.cs)

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
|                      Method | Count |         Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |-------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                     **ForLoop** |    **10** |     **14.65 ns** |  **0.105 ns** |  **0.093 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop |    10 |     34.40 ns |  0.161 ns |  0.143 ns |  2.35 |    0.01 |      - |     - |     - |         - |
|                        Linq |    10 |    171.53 ns |  1.491 ns |  1.321 ns | 11.71 |    0.13 | 0.0229 |     - |     - |      72 B |
|                  LinqFaster |    10 |     57.49 ns |  0.557 ns |  0.494 ns |  3.92 |    0.04 | 0.0305 |     - |     - |      96 B |
|                      LinqAF |    10 |    156.96 ns |  0.543 ns |  0.454 ns | 10.71 |    0.08 |      - |     - |     - |         - |
|                  StructLinq |    10 |     58.35 ns |  0.388 ns |  0.363 ns |  3.98 |    0.03 | 0.0101 |     - |     - |      32 B |
|        StructLinq_IFunction |    10 |     52.64 ns |  0.121 ns |  0.114 ns |  3.59 |    0.02 |      - |     - |     - |         - |
|           Hyperlinq_Foreach |    10 |     59.32 ns |  0.274 ns |  0.243 ns |  4.05 |    0.03 |      - |     - |     - |         - |
| Hyperlinq_IFunction_Foreach |    10 |     60.00 ns |  0.124 ns |  0.110 ns |  4.09 |    0.03 |      - |     - |     - |         - |
|               Hyperlinq_For |    10 |     45.78 ns |  0.116 ns |  0.103 ns |  3.12 |    0.02 |      - |     - |     - |         - |
|     Hyperlinq_IFunction_For |    10 |     30.65 ns |  0.143 ns |  0.127 ns |  2.09 |    0.02 |      - |     - |     - |         - |
|                    Tinyield |    10 |    294.76 ns |  3.795 ns |  3.364 ns | 20.12 |    0.30 | 0.1912 |     - |     - |     600 B |
|                             |       |              |           |           |       |         |        |       |       |           |
|                     **ForLoop** |  **1000** |  **1,368.46 ns** |  **4.068 ns** |  **3.606 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop |  1000 |  2,928.99 ns | 12.139 ns | 11.355 ns |  2.14 |    0.01 |      - |     - |     - |         - |
|                        Linq |  1000 |  9,586.27 ns | 49.259 ns | 43.667 ns |  7.01 |    0.04 | 0.0153 |     - |     - |      72 B |
|                  LinqFaster |  1000 |  4,195.96 ns | 29.228 ns | 27.340 ns |  3.06 |    0.03 | 1.2894 |     - |     - |   4,056 B |
|                      LinqAF |  1000 |  9,478.85 ns | 84.255 ns | 74.690 ns |  6.93 |    0.06 |      - |     - |     - |         - |
|                  StructLinq |  1000 |  3,013.17 ns | 20.889 ns | 19.540 ns |  2.20 |    0.02 | 0.0076 |     - |     - |      32 B |
|        StructLinq_IFunction |  1000 |  1,962.26 ns |  9.924 ns |  9.283 ns |  1.43 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach |  1000 |  2,944.53 ns |  7.355 ns |  6.142 ns |  2.15 |    0.01 |      - |     - |     - |         - |
| Hyperlinq_IFunction_Foreach |  1000 |  2,095.19 ns |  8.637 ns |  6.743 ns |  1.53 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For |  1000 |  2,569.47 ns |  9.919 ns |  9.278 ns |  1.88 |    0.01 |      - |     - |     - |         - |
|     Hyperlinq_IFunction_For |  1000 |  1,120.13 ns |  4.645 ns |  4.345 ns |  0.82 |    0.00 |      - |     - |     - |         - |
|                    Tinyield |  1000 | 13,423.81 ns | 58.344 ns | 51.720 ns |  9.81 |    0.05 | 0.1831 |     - |     - |     600 B |
