## List.Int32.ListInt32Distinct

### Source
[ListInt32Distinct.cs](../LinqBenchmarks/List/Int32/ListInt32Distinct.cs)

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
|               Method | Duplicates | Count |          Mean |      Error |     StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----------- |------ |--------------:|-----------:|-----------:|------:|--------:|--------:|------:|------:|----------:|
|              **ForLoop** |          **4** |    **10** |     **530.55 ns** |   **5.824 ns** |   **5.448 ns** |  **1.00** |    **0.00** |  **0.2136** |     **-** |     **-** |     **672 B** |
|          ForeachLoop |          4 |    10 |     604.60 ns |   4.473 ns |   3.965 ns |  1.14 |    0.01 |  0.2136 |     - |     - |     672 B |
|                 Linq |          4 |    10 |   1,105.45 ns |  12.951 ns |  12.114 ns |  2.08 |    0.02 |  0.1945 |     - |     - |     616 B |
|           LinqFaster |          4 |    10 |      76.31 ns |   0.469 ns |   0.438 ns |  0.14 |    0.00 |       - |     - |     - |         - |
|               LinqAF |          4 |    10 |   1,468.07 ns |  10.561 ns |   9.362 ns |  2.77 |    0.03 |  0.4120 |     - |     - |   1,296 B |
|           StructLinq |          4 |    10 |     720.55 ns |   5.693 ns |   5.046 ns |  1.36 |    0.02 |  0.0095 |     - |     - |      32 B |
| StructLinq_IFunction |          4 |    10 |     658.19 ns |   6.070 ns |   5.381 ns |  1.24 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |          4 |    10 |     676.64 ns |   5.798 ns |   5.424 ns |  1.28 |    0.02 |       - |     - |     - |         - |
|             Tinyield |          4 |    10 |   1,012.97 ns |  10.811 ns |  10.113 ns |  1.91 |    0.03 |  0.4044 |     - |     - |   1,272 B |
|                      |            |       |               |            |            |       |         |         |       |       |           |
|              **ForLoop** |          **4** |  **1000** |  **44,197.20 ns** | **215.144 ns** | **179.655 ns** |  **1.00** |    **0.00** | **18.6157** |     **-** |     **-** |  **58,672 B** |
|          ForeachLoop |          4 |  1000 |  50,339.36 ns | 131.006 ns | 109.396 ns |  1.14 |    0.00 | 18.6157 |     - |     - |  58,672 B |
|                 Linq |          4 |  1000 |  93,608.67 ns | 416.310 ns | 369.048 ns |  2.12 |    0.01 | 10.4980 |     - |     - |  33,112 B |
|           LinqFaster |          4 |  1000 |  10,261.73 ns |  46.077 ns |  43.101 ns |  0.23 |    0.00 |       - |     - |     - |         - |
|               LinqAF |          4 |  1000 | 125,052.49 ns | 887.063 ns | 740.738 ns |  2.83 |    0.02 | 35.8887 |     - |     - | 113,184 B |
|           StructLinq |          4 |  1000 |  44,206.33 ns | 210.607 ns | 197.002 ns |  1.00 |    0.00 |       - |     - |     - |      32 B |
| StructLinq_IFunction |          4 |  1000 |  44,450.08 ns | 307.668 ns | 287.793 ns |  1.01 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |          4 |  1000 |  52,186.79 ns | 402.872 ns | 376.846 ns |  1.18 |    0.01 |       - |     - |     - |         - |
|             Tinyield |          4 |  1000 |  79,246.59 ns | 693.040 ns | 614.362 ns |  1.79 |    0.02 | 18.7988 |     - |     - |  59,272 B |
