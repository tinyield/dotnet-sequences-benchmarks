## List.Int32.ListInt32SkipTakeSelect

### Source
[ListInt32SkipTakeSelect.cs](../LinqBenchmarks/List/Int32/ListInt32SkipTakeSelect.cs)

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
|                      Method | Skip | Count |         Mean |      Error |     StdDev |    Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |-------------:|-----------:|-----------:|---------:|--------:|-------:|------:|------:|----------:|
|                     **ForLoop** | **1000** |    **10** |     **10.83 ns** |   **0.055 ns** |   **0.046 ns** |     **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop | 1000 |    10 |  4,454.74 ns |  13.350 ns |  11.148 ns |   411.43 |    2.34 | 0.0076 |     - |     - |      40 B |
|                        Linq | 1000 |    10 |    249.76 ns |   1.189 ns |   0.928 ns |    23.07 |    0.15 | 0.0482 |     - |     - |     152 B |
|                  LinqFaster | 1000 |    10 |    151.04 ns |   1.959 ns |   1.832 ns |    13.93 |    0.15 | 0.0918 |     - |     - |     288 B |
|                      LinqAF | 1000 |    10 |  5,818.54 ns |  31.346 ns |  29.321 ns |   537.29 |    3.80 |      - |     - |     - |         - |
|                  StructLinq | 1000 |    10 |    105.97 ns |   0.396 ns |   0.351 ns |     9.79 |    0.06 | 0.0305 |     - |     - |      96 B |
|        StructLinq_IFunction | 1000 |    10 |     54.27 ns |   0.173 ns |   0.154 ns |     5.01 |    0.02 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |    10 |     81.67 ns |   0.213 ns |   0.189 ns |     7.54 |    0.04 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |    10 |     80.77 ns |   0.134 ns |   0.119 ns |     7.46 |    0.04 |      - |     - |     - |         - |
|               Hyperlinq_For | 1000 |    10 |     68.20 ns |   0.155 ns |   0.129 ns |     6.30 |    0.02 |      - |     - |     - |         - |
|                    Tinyield | 1000 |    10 | 15,053.15 ns |  57.203 ns |  53.508 ns | 1,390.69 |    7.79 | 0.3052 |     - |     - |     984 B |
|                             |      |       |              |            |            |          |         |        |       |       |           |
|                     **ForLoop** | **1000** |  **1000** |    **887.00 ns** |  **16.555 ns** |  **15.485 ns** |     **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop | 1000 |  1000 |  8,801.23 ns |  37.837 ns |  31.596 ns |     9.94 |    0.19 |      - |     - |     - |      40 B |
|                        Linq | 1000 |  1000 | 12,215.87 ns |  46.902 ns |  39.165 ns |    13.79 |    0.25 | 0.0458 |     - |     - |     152 B |
|                  LinqFaster | 1000 |  1000 | 10,346.37 ns |  53.352 ns |  44.551 ns |    11.68 |    0.25 | 3.8757 |     - |     - |  12,168 B |
|                      LinqAF | 1000 |  1000 | 18,533.72 ns |  96.796 ns |  90.543 ns |    20.90 |    0.40 |      - |     - |     - |         - |
|                  StructLinq | 1000 |  1000 |  2,677.23 ns |  11.036 ns |   9.215 ns |     3.02 |    0.06 | 0.0305 |     - |     - |      96 B |
|        StructLinq_IFunction | 1000 |  1000 |  1,966.29 ns |   6.225 ns |   5.518 ns |     2.22 |    0.04 |      - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |  1000 |  2,967.12 ns |   9.005 ns |   8.423 ns |     3.35 |    0.06 |      - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |  1000 |  2,107.71 ns |   9.110 ns |   8.521 ns |     2.38 |    0.05 |      - |     - |     - |         - |
|               Hyperlinq_For | 1000 |  1000 |  2,596.23 ns |  10.538 ns |   9.857 ns |     2.93 |    0.05 |      - |     - |     - |         - |
|                    Tinyield | 1000 |  1000 | 32,630.37 ns | 218.576 ns | 193.762 ns |    36.83 |    0.63 | 0.3052 |     - |     - |     984 B |
