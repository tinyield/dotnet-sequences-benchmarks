## List.ValueType.ListValueTypeSkipTakeSelect

### Source
[ListValueTypeSkipTakeSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSkipTakeSelect.cs)

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
|                      Method | Skip | Count |         Mean |       Error |      StdDev |       Median | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |-------------:|------------:|------------:|-------------:|------:|--------:|--------:|------:|------:|----------:|
|                     **ForLoop** | **1000** |    **10** |     **328.6 ns** |     **0.84 ns** |     **0.75 ns** |     **328.5 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop | 1000 |    10 |   5,543.6 ns |    23.94 ns |    21.22 ns |   5,540.3 ns | 16.87 |    0.09 |  0.0305 |     - |     - |      96 B |
|                        Linq | 1000 |    10 |     477.5 ns |     2.18 ns |     1.82 ns |     478.3 ns |  1.45 |    0.01 |  0.1011 |     - |     - |     320 B |
|                  LinqFaster | 1000 |    10 |     677.3 ns |    10.67 ns |     9.98 ns |     676.5 ns |  2.06 |    0.03 |  0.6647 |     - |     - |   2,088 B |
|                      LinqAF | 1000 |    10 |  29,422.7 ns | 1,044.08 ns | 2,875.69 ns |  28,350.0 ns | 94.20 |    9.84 |       - |     - |     - |         - |
|                  StructLinq | 1000 |    10 |     341.1 ns |     1.03 ns |     0.96 ns |     340.9 ns |  1.04 |    0.00 |  0.0381 |     - |     - |     120 B |
|        StructLinq_IFunction | 1000 |    10 |     300.1 ns |     0.57 ns |     0.47 ns |     300.1 ns |  0.91 |    0.00 |       - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |    10 |     322.5 ns |     1.02 ns |     0.91 ns |     322.2 ns |  0.98 |    0.00 |       - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |    10 |     286.1 ns |     1.17 ns |     1.03 ns |     286.0 ns |  0.87 |    0.00 |       - |     - |     - |         - |
|               Hyperlinq_For | 1000 |    10 |     307.0 ns |     1.12 ns |     0.99 ns |     306.8 ns |  0.93 |    0.00 |       - |     - |     - |         - |
|     Hyperlinq_For_IFunction | 1000 |    10 |     271.0 ns |     0.70 ns |     0.62 ns |     271.1 ns |  0.82 |    0.00 |       - |     - |     - |         - |
|                    Tinyield | 1000 |    10 |  17,360.1 ns |   136.00 ns |   120.56 ns |  17,348.1 ns | 52.83 |    0.39 |  0.3357 |     - |     - |   1,096 B |
|                             |      |       |              |             |             |              |       |         |         |       |       |           |
|                     **ForLoop** | **1000** |  **1000** |  **31,172.9 ns** |    **75.01 ns** |    **70.16 ns** |  **31,193.3 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop | 1000 |  1000 |  30,857.6 ns |   205.97 ns |   192.66 ns |  30,782.5 ns |  0.99 |    0.01 |       - |     - |     - |      96 B |
|                        Linq | 1000 |  1000 |  34,993.3 ns |   165.23 ns |   154.56 ns |  34,957.8 ns |  1.12 |    0.01 |  0.0610 |     - |     - |     320 B |
|                  LinqFaster | 1000 |  1000 |  69,430.1 ns |   586.39 ns |   548.51 ns |  69,457.2 ns |  2.23 |    0.02 | 61.1572 |     - |     - | 192,168 B |
|                      LinqAF | 1000 |  1000 | 137,213.6 ns | 2,734.60 ns | 3,358.33 ns | 136,600.0 ns |  4.43 |    0.12 |       - |     - |     - |         - |
|                  StructLinq | 1000 |  1000 |  24,968.4 ns |    73.58 ns |    68.83 ns |  24,954.8 ns |  0.80 |    0.00 |  0.0305 |     - |     - |     120 B |
|        StructLinq_IFunction | 1000 |  1000 |  22,958.6 ns |    69.84 ns |    58.32 ns |  22,945.4 ns |  0.74 |    0.00 |       - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |  1000 |  34,124.1 ns |    61.77 ns |    54.76 ns |  34,126.0 ns |  1.09 |    0.00 |       - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |  1000 |  22,983.1 ns |    77.89 ns |    72.86 ns |  22,969.7 ns |  0.74 |    0.00 |       - |     - |     - |         - |
|               Hyperlinq_For | 1000 |  1000 |  40,703.3 ns |    96.05 ns |    89.84 ns |  40,714.5 ns |  1.31 |    0.00 |       - |     - |     - |         - |
|     Hyperlinq_For_IFunction | 1000 |  1000 |  23,240.7 ns |    53.37 ns |    44.57 ns |  23,223.5 ns |  0.75 |    0.00 |       - |     - |     - |         - |
|                    Tinyield | 1000 |  1000 |  60,020.8 ns |   304.04 ns |   284.40 ns |  59,976.6 ns |  1.93 |    0.01 |  0.3052 |     - |     - |   1,096 B |
