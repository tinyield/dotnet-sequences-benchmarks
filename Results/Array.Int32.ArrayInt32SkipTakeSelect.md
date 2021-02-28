## Array.Int32.ArrayInt32SkipTakeSelect

### Source
[ArrayInt32SkipTakeSelect.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SkipTakeSelect.cs)

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
|                      Method | Skip | Count |          Mean |       Error |      StdDev |  Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |--------------:|------------:|------------:|-------:|--------:|-------:|------:|------:|----------:|
|                     **ForLoop** | **1000** |    **10** |      **8.700 ns** |   **0.0711 ns** |   **0.0665 ns** |   **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop | 1000 |    10 |  2,976.243 ns |  14.2467 ns |  13.3263 ns | 342.12 |    3.12 | 0.0076 |     - |     - |      32 B |
|                        Linq | 1000 |    10 |    276.847 ns |   2.3737 ns |   2.2204 ns |  31.82 |    0.29 | 0.0482 |     - |     - |     152 B |
|                  LinqFaster | 1000 |    10 |     78.312 ns |   0.4889 ns |   0.4573 ns |   9.00 |    0.09 | 0.0612 |     - |     - |     192 B |
|                      LinqAF | 1000 |    10 |  2,832.386 ns |   9.3535 ns |   8.7493 ns | 325.59 |    2.84 |      - |     - |     - |         - |
|                  StructLinq | 1000 |    10 |    105.239 ns |   0.3275 ns |   0.2557 ns |  12.10 |    0.08 | 0.0305 |     - |     - |      96 B |
|        StructLinq_IFunction | 1000 |    10 |     52.281 ns |   0.1041 ns |   0.0923 ns |   6.01 |    0.05 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |    10 |     83.289 ns |   0.4144 ns |   0.3460 ns |   9.58 |    0.07 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |    10 |     81.394 ns |   0.1616 ns |   0.1512 ns |   9.36 |    0.07 |      - |     - |     - |         - |
|               Hyperlinq_For | 1000 |    10 |     68.780 ns |   0.2973 ns |   0.2781 ns |   7.91 |    0.08 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | 1000 |    10 |     53.834 ns |   0.1912 ns |   0.1695 ns |   6.19 |    0.06 |      - |     - |     - |         - |
|                    Tinyield | 1000 |    10 |  7,354.796 ns |  27.9953 ns |  26.1868 ns | 845.44 |    6.45 | 0.2975 |     - |     - |     952 B |
|                             |      |       |               |             |             |        |         |        |       |       |           |
|                     **ForLoop** | **1000** |  **1000** |    **739.773 ns** |   **4.0863 ns** |   **3.6224 ns** |   **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop | 1000 |  1000 |  5,853.784 ns |  18.7759 ns |  16.6443 ns |   7.91 |    0.05 | 0.0076 |     - |     - |      32 B |
|                        Linq | 1000 |  1000 | 13,992.255 ns |  38.1306 ns |  33.8018 ns |  18.91 |    0.13 | 0.0458 |     - |     - |     152 B |
|                  LinqFaster | 1000 |  1000 |  4,570.015 ns |  43.7680 ns |  40.9406 ns |   6.18 |    0.05 | 3.8452 |     - |     - |  12,072 B |
|                      LinqAF | 1000 |  1000 | 13,742.968 ns |  61.5566 ns |  57.5801 ns |  18.58 |    0.14 |      - |     - |     - |         - |
|                  StructLinq | 1000 |  1000 |  2,676.087 ns |  12.5898 ns |  11.1605 ns |   3.62 |    0.03 | 0.0305 |     - |     - |      96 B |
|        StructLinq_IFunction | 1000 |  1000 |  1,957.234 ns |   4.9351 ns |   4.3748 ns |   2.65 |    0.01 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |  1000 |  2,616.234 ns |  14.8167 ns |  13.8595 ns |   3.54 |    0.03 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |  1000 |  2,071.268 ns |   9.0064 ns |   8.4246 ns |   2.80 |    0.02 |      - |     - |     - |         - |
|               Hyperlinq_For | 1000 |  1000 |  2,605.884 ns |  20.4228 ns |  19.1035 ns |   3.52 |    0.03 |      - |     - |     - |         - |
|     Hyperlinq_For_IFunction | 1000 |  1000 |  1,138.470 ns |   2.9701 ns |   2.4802 ns |   1.54 |    0.01 |      - |     - |     - |         - |
|                    Tinyield | 1000 |  1000 | 18,442.061 ns | 141.0740 ns | 131.9607 ns |  24.94 |    0.23 | 0.2747 |     - |     - |     952 B |
