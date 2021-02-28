## Array.Int32.ArrayInt32Select

### Source
[ArrayInt32Select.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Select.cs)

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
|                      Method | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |-------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|                     **ForLoop** |    **10** |     **4.059 ns** |  **0.0317 ns** |  **0.0296 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop |    10 |     4.054 ns |  0.0205 ns |  0.0192 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|                        Linq |    10 |   150.280 ns |  1.1505 ns |  1.0199 ns | 37.01 |    0.30 | 0.0153 |     - |     - |      48 B |
|                  LinqFaster |    10 |    43.758 ns |  0.2450 ns |  0.2292 ns | 10.78 |    0.07 | 0.0204 |     - |     - |      64 B |
|             LinqFaster_SIMD |    10 |    27.124 ns |  0.3698 ns |  0.3459 ns |  6.68 |    0.10 | 0.0204 |     - |     - |      64 B |
|                      LinqAF |    10 |    97.522 ns |  0.2052 ns |  0.1819 ns | 24.02 |    0.19 |      - |     - |     - |         - |
|                  StructLinq |    10 |    58.374 ns |  0.4953 ns |  0.4633 ns | 14.38 |    0.13 | 0.0101 |     - |     - |      32 B |
|        StructLinq_IFunction |    10 |    51.810 ns |  0.1226 ns |  0.1147 ns | 12.76 |    0.10 |      - |     - |     - |         - |
|           Hyperlinq_Foreach |    10 |    61.778 ns |  0.2638 ns |  0.2339 ns | 15.22 |    0.13 |      - |     - |     - |         - |
| Hyperlinq_IFunction_Foreach |    10 |    57.075 ns |  0.0852 ns |  0.0797 ns | 14.06 |    0.10 |      - |     - |     - |         - |
|               Hyperlinq_For |    10 |    45.494 ns |  0.1661 ns |  0.1387 ns | 11.20 |    0.11 |      - |     - |     - |         - |
|     Hyperlinq_IFunction_For |    10 |    30.633 ns |  0.1310 ns |  0.1225 ns |  7.55 |    0.07 |      - |     - |     - |         - |
|                    Tinyield |    10 |   180.279 ns |  1.2884 ns |  1.2051 ns | 44.42 |    0.53 | 0.1810 |     - |     - |     568 B |
|                             |       |              |            |            |       |         |        |       |       |           |
|                     **ForLoop** |  **1000** |   **736.475 ns** |  **1.7256 ns** |  **1.5297 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop |  1000 |   736.610 ns |  3.3139 ns |  3.0998 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|                        Linq |  1000 | 7,742.977 ns | 49.8875 ns | 44.2240 ns | 10.51 |    0.07 | 0.0153 |     - |     - |      48 B |
|                  LinqFaster |  1000 | 3,874.804 ns | 20.7318 ns | 18.3782 ns |  5.26 |    0.03 | 1.2817 |     - |     - |   4,024 B |
|             LinqFaster_SIMD |  1000 | 1,324.646 ns | 14.3354 ns | 13.4093 ns |  1.80 |    0.02 | 1.2817 |     - |     - |   4,024 B |
|                      LinqAF |  1000 | 6,424.420 ns | 21.0183 ns | 17.5513 ns |  8.72 |    0.02 |      - |     - |     - |         - |
|                  StructLinq |  1000 | 2,946.194 ns |  6.1265 ns |  5.4309 ns |  4.00 |    0.01 | 0.0076 |     - |     - |      32 B |
|        StructLinq_IFunction |  1000 | 1,963.300 ns |  8.2780 ns |  6.9125 ns |  2.67 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach |  1000 | 2,588.818 ns |  9.9401 ns |  9.2979 ns |  3.51 |    0.01 |      - |     - |     - |         - |
| Hyperlinq_IFunction_Foreach |  1000 | 2,059.695 ns |  7.6119 ns |  7.1202 ns |  2.80 |    0.01 |      - |     - |     - |         - |
|               Hyperlinq_For |  1000 | 2,927.734 ns | 11.4863 ns | 10.7443 ns |  3.98 |    0.02 |      - |     - |     - |         - |
|     Hyperlinq_IFunction_For |  1000 | 1,115.153 ns |  3.7059 ns |  3.2852 ns |  1.51 |    0.01 |      - |     - |     - |         - |
|                    Tinyield |  1000 | 6,009.612 ns | 30.8777 ns | 27.3723 ns |  8.16 |    0.05 | 0.1755 |     - |     - |     568 B |
