## Array.ValueType.ArrayValueTypeSkipTakeSelect

### Source
[ArrayValueTypeSkipTakeSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSkipTakeSelect.cs)

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
|                      Method | Skip | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |------------:|----------:|----------:|------:|--------:|--------:|------:|------:|----------:|
|                     **ForLoop** | **1000** |    **10** |    **219.3 ns** |   **0.55 ns** |   **0.51 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop | 1000 |    10 |  3,197.5 ns |   8.61 ns |   7.64 ns | 14.57 |    0.05 |  0.0076 |     - |     - |      32 B |
|                        Linq | 1000 |    10 |    504.1 ns |   2.03 ns |   1.80 ns |  2.30 |    0.01 |  0.1011 |     - |     - |     320 B |
|                  LinqFaster | 1000 |    10 |    583.5 ns |   3.95 ns |   3.50 ns |  2.66 |    0.01 |  0.6342 |     - |     - |   1,992 B |
|                      LinqAF | 1000 |    10 |  7,453.7 ns | 138.24 ns | 115.44 ns | 33.98 |    0.52 |       - |     - |     - |         - |
|                  StructLinq | 1000 |    10 |    409.3 ns |   1.03 ns |   0.91 ns |  1.87 |    0.01 |  0.0305 |     - |     - |      96 B |
|        StructLinq_IFunction | 1000 |    10 |    285.1 ns |   0.83 ns |   0.74 ns |  1.30 |    0.01 |       - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |    10 |    321.9 ns |   1.09 ns |   1.02 ns |  1.47 |    0.01 |       - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |    10 |    285.9 ns |   0.90 ns |   0.84 ns |  1.30 |    0.01 |       - |     - |     - |         - |
|               Hyperlinq_For | 1000 |    10 |    311.4 ns |   0.79 ns |   0.74 ns |  1.42 |    0.01 |       - |     - |     - |         - |
|     Hyperlinq_For_IFunction | 1000 |    10 |    301.7 ns |   0.64 ns |   0.60 ns |  1.38 |    0.00 |       - |     - |     - |         - |
|                    Tinyield | 1000 |    10 |  8,433.1 ns |  68.07 ns |  60.34 ns | 38.44 |    0.33 |  0.3204 |     - |     - |   1,008 B |
|                             |      |       |             |           |           |       |         |         |       |       |           |
|                     **ForLoop** | **1000** |  **1000** | **21,801.4 ns** |  **70.16 ns** |  **58.59 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop | 1000 |  1000 | 28,746.3 ns | 127.44 ns | 112.97 ns |  1.32 |    0.01 |       - |     - |     - |      32 B |
|                        Linq | 1000 |  1000 | 35,963.1 ns | 105.17 ns |  82.11 ns |  1.65 |    0.00 |  0.0610 |     - |     - |     320 B |
|                  LinqFaster | 1000 |  1000 | 47,280.0 ns | 286.08 ns | 267.60 ns |  2.17 |    0.02 | 59.9976 |     - |     - | 192,072 B |
|                      LinqAF | 1000 |  1000 | 55,408.8 ns | 905.76 ns | 847.25 ns |  2.54 |    0.04 |       - |     - |     - |         - |
|                  StructLinq | 1000 |  1000 | 24,799.0 ns |  78.85 ns |  69.90 ns |  1.14 |    0.00 |  0.0305 |     - |     - |      96 B |
|        StructLinq_IFunction | 1000 |  1000 | 33,580.9 ns |  58.80 ns |  55.00 ns |  1.54 |    0.00 |       - |     - |     - |         - |
|           Hyperlinq_Foreach | 1000 |  1000 | 26,302.7 ns |  54.79 ns |  45.75 ns |  1.21 |    0.00 |       - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction | 1000 |  1000 | 22,943.7 ns |  57.35 ns |  53.65 ns |  1.05 |    0.00 |       - |     - |     - |         - |
|               Hyperlinq_For | 1000 |  1000 | 26,606.5 ns |  81.80 ns |  76.52 ns |  1.22 |    0.01 |       - |     - |     - |         - |
|     Hyperlinq_For_IFunction | 1000 |  1000 | 23,265.9 ns |  51.96 ns |  48.60 ns |  1.07 |    0.00 |       - |     - |     - |         - |
|                    Tinyield | 1000 |  1000 | 42,238.9 ns | 181.44 ns | 169.72 ns |  1.94 |    0.00 |  0.3052 |     - |     - |   1,008 B |
