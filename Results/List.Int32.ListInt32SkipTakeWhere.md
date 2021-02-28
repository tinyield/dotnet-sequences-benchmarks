## List.Int32.ListInt32SkipTakeWhere

### Source
[ListInt32SkipTakeWhere.cs](../LinqBenchmarks/List/Int32/ListInt32SkipTakeWhere.cs)

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
|               Method | Skip | Count |         Mean |      Error |     StdDev |    Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |-------------:|-----------:|-----------:|---------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** | **1000** |    **10** |     **11.68 ns** |   **0.063 ns** |   **0.059 ns** |     **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop | 1000 |    10 |  4,809.59 ns |  18.696 ns |  16.574 ns |   411.74 |    2.23 | 0.0076 |     - |     - |      40 B |
|                 Linq | 1000 |    10 |    290.45 ns |   4.039 ns |   3.580 ns |    24.86 |    0.31 | 0.0482 |     - |     - |     152 B |
|           LinqFaster | 1000 |    10 |    173.68 ns |   1.187 ns |   1.111 ns |    14.87 |    0.14 | 0.1018 |     - |     - |     320 B |
|               LinqAF | 1000 |    10 |  5,812.42 ns |  27.058 ns |  23.986 ns |   497.60 |    3.82 |      - |     - |     - |         - |
|           StructLinq | 1000 |    10 |    111.78 ns |   0.366 ns |   0.306 ns |     9.58 |    0.04 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction | 1000 |    10 |     56.32 ns |   0.116 ns |   0.102 ns |     4.82 |    0.03 |      - |     - |     - |         - |
|            Hyperlinq | 1000 |    10 |     88.25 ns |   0.371 ns |   0.329 ns |     7.56 |    0.05 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |    10 |     76.66 ns |   0.350 ns |   0.327 ns |     6.56 |    0.05 |      - |     - |     - |         - |
|             Tinyield | 1000 |    10 | 15,035.28 ns |  81.666 ns |  68.195 ns | 1,288.22 |    8.21 | 0.3052 |     - |     - |     984 B |
|                      |      |       |              |            |            |          |         |        |       |       |           |
|              **ForLoop** | **1000** |  **1000** |  **1,137.44 ns** |   **7.385 ns** |   **6.546 ns** |     **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop | 1000 |  1000 |  9,490.79 ns |  27.521 ns |  22.982 ns |     8.35 |    0.05 |      - |     - |     - |      40 B |
|                 Linq | 1000 |  1000 | 20,894.91 ns | 138.344 ns | 129.407 ns |    18.38 |    0.19 | 0.0305 |     - |     - |     152 B |
|           LinqFaster | 1000 |  1000 | 10,949.18 ns |  76.627 ns |  67.928 ns |     9.63 |    0.07 | 3.9520 |     - |     - |  12,416 B |
|               LinqAF | 1000 |  1000 | 25,424.49 ns | 166.507 ns | 155.751 ns |    22.35 |    0.22 |      - |     - |     - |         - |
|           StructLinq | 1000 |  1000 |  7,975.04 ns |  30.713 ns |  27.227 ns |     7.01 |    0.05 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction | 1000 |  1000 |  2,115.58 ns |  24.378 ns |  20.356 ns |     1.86 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq | 1000 |  1000 |  6,770.14 ns |  24.862 ns |  23.256 ns |     5.95 |    0.04 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |  1000 |  2,706.34 ns |  16.946 ns |  15.852 ns |     2.38 |    0.02 |      - |     - |     - |         - |
|             Tinyield | 1000 |  1000 | 39,556.16 ns | 292.037 ns | 273.172 ns |    34.77 |    0.25 | 0.3052 |     - |     - |     984 B |
