## Array.ValueType.ArrayValueTypeDistinct

### Source
[ArrayValueTypeDistinct.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeDistinct.cs)

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
|               Method | Duplicates | Count |           Mean |        Error |       StdDev | Ratio | RatioSD |    Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|--------------------- |----------- |------ |---------------:|-------------:|-------------:|------:|--------:|---------:|--------:|--------:|----------:|
|              **ForLoop** |          **4** |    **10** |     **1,693.5 ns** |      **7.52 ns** |      **6.28 ns** |  **1.00** |    **0.00** |   **0.7267** |       **-** |       **-** |   **2,280 B** |
|          ForeachLoop |          4 |    10 |     1,739.5 ns |     17.89 ns |     16.73 ns |  1.03 |    0.01 |   0.7267 |       - |       - |   2,280 B |
|                 Linq |          4 |    10 |     2,241.5 ns |     10.63 ns |      9.42 ns |  1.32 |    0.01 |   0.6294 |       - |       - |   1,976 B |
|               LinqAF |          4 |    10 |     4,628.2 ns |     22.78 ns |     20.19 ns |  2.73 |    0.01 |   1.4267 |       - |       - |   4,480 B |
|           StructLinq |          4 |    10 |     2,181.0 ns |      5.61 ns |      5.24 ns |  1.29 |    0.01 |   0.0153 |       - |       - |      56 B |
| StructLinq_IFunction |          4 |    10 |       805.3 ns |      2.64 ns |      2.21 ns |  0.48 |    0.00 |        - |       - |       - |         - |
|            Hyperlinq |          4 |    10 |     1,731.7 ns |      5.55 ns |      5.19 ns |  1.02 |    0.00 |        - |       - |       - |         - |
|             Tinyield |          4 |    10 |     2,102.8 ns |     10.00 ns |      9.36 ns |  1.24 |    0.01 |   0.9232 |       - |       - |   2,904 B |
|                      |            |       |                |              |              |       |         |          |         |         |           |
|              **ForLoop** |          **4** |  **1000** |   **246,782.2 ns** |  **1,565.77 ns** |  **1,388.02 ns** |  **1.00** |    **0.00** |  **43.9453** | **43.4570** | **43.4570** | **276,496 B** |
|          ForeachLoop |          4 |  1000 |   251,970.2 ns |  1,369.71 ns |  1,281.22 ns |  1.02 |    0.01 |  43.9453 | 43.4570 | 43.4570 | 276,496 B |
|                 Linq |          4 |  1000 |   270,254.5 ns |  1,790.41 ns |  1,674.75 ns |  1.10 |    0.01 |  48.3398 |       - |       - | 155,048 B |
|               LinqAF |          4 |  1000 | 6,352,863.8 ns | 24,098.87 ns | 21,363.02 ns | 25.74 |    0.16 | 117.1875 |       - |       - | 382,472 B |
|           StructLinq |          4 |  1000 |   207,049.4 ns |  1,176.32 ns |  1,042.78 ns |  0.84 |    0.01 |        - |       - |       - |      56 B |
| StructLinq_IFunction |          4 |  1000 |    62,790.3 ns |    193.83 ns |    161.85 ns |  0.25 |    0.00 |        - |       - |       - |         - |
|            Hyperlinq |          4 |  1000 |   205,067.3 ns |    557.24 ns |    493.98 ns |  0.83 |    0.01 |        - |       - |       - |         - |
|             Tinyield |          4 |  1000 |   236,315.6 ns |  1,053.44 ns |    933.85 ns |  0.96 |    0.01 |  43.4570 | 43.4570 | 43.4570 | 277,120 B |
