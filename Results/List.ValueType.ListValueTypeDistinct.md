## List.ValueType.ListValueTypeDistinct

### Source
[ListValueTypeDistinct.cs](../LinqBenchmarks/List/ValueType/ListValueTypeDistinct.cs)

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
|               Method | Duplicates | Count |         Mean |       Error |      StdDev | Ratio | RatioSD |    Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|--------------------- |----------- |------ |-------------:|------------:|------------:|------:|--------:|---------:|--------:|--------:|----------:|
|              **ForLoop** |          **4** |    **10** |   **1,908.1 ns** |    **12.38 ns** |    **10.34 ns** |  **1.00** |    **0.00** |   **0.7267** |       **-** |       **-** |   **2,280 B** |
|          ForeachLoop |          4 |    10 |   1,969.4 ns |    20.46 ns |    19.14 ns |  1.03 |    0.01 |   0.7248 |       - |       - |   2,280 B |
|                 Linq |          4 |    10 |   3,255.3 ns |     8.19 ns |     6.40 ns |  1.71 |    0.01 |   0.6485 |       - |       - |   2,040 B |
|           LinqFaster |          4 |    10 |     322.4 ns |     6.46 ns |    10.44 ns |  0.17 |    0.01 |   0.0076 |       - |       - |      24 B |
|               LinqAF |          4 |    10 |   5,067.6 ns |    36.56 ns |    30.53 ns |  2.66 |    0.02 |   1.4420 |       - |       - |   4,544 B |
|           StructLinq |          4 |    10 |   2,041.0 ns |     7.89 ns |     7.38 ns |  1.07 |    0.01 |   0.0191 |       - |       - |      64 B |
| StructLinq_IFunction |          4 |    10 |     828.7 ns |     4.82 ns |     4.51 ns |  0.43 |    0.00 |        - |       - |       - |         - |
|            Hyperlinq |          4 |    10 |   2,956.0 ns |     5.54 ns |     5.18 ns |  1.55 |    0.01 |        - |       - |       - |         - |
|             Tinyield |          4 |    10 |   2,636.6 ns |    18.19 ns |    17.01 ns |  1.38 |    0.01 |   0.9537 |       - |       - |   2,992 B |
|                      |            |       |              |             |             |       |         |          |         |         |           |
|              **ForLoop** |          **4** |  **1000** | **262,100.3 ns** | **1,583.71 ns** | **1,403.91 ns** |  **1.00** |    **0.00** |  **43.9453** | **43.4570** | **43.4570** | **276,496 B** |
|          ForeachLoop |          4 |  1000 | 272,907.0 ns | 1,804.74 ns | 1,599.85 ns |  1.04 |    0.01 |  43.9453 | 43.4570 | 43.4570 | 276,496 B |
|                 Linq |          4 |  1000 | 270,529.6 ns | 2,092.62 ns | 1,957.43 ns |  1.03 |    0.01 |  48.3398 |       - |       - | 155,112 B |
|           LinqFaster |          4 |  1000 |  46,236.8 ns |   191.67 ns |   179.28 ns |  0.18 |    0.00 |        - |       - |       - |      24 B |
|               LinqAF |          4 |  1000 | 572,743.1 ns | 3,264.20 ns | 2,893.63 ns |  2.19 |    0.02 | 132.8125 |  0.9766 |       - | 419,673 B |
|           StructLinq |          4 |  1000 | 207,031.5 ns | 1,112.16 ns | 1,040.31 ns |  0.79 |    0.00 |        - |       - |       - |      64 B |
| StructLinq_IFunction |          4 |  1000 |  62,578.2 ns |   221.91 ns |   185.31 ns |  0.24 |    0.00 |        - |       - |       - |         - |
|            Hyperlinq |          4 |  1000 | 204,861.9 ns |   853.59 ns |   798.45 ns |  0.78 |    0.01 |        - |       - |       - |         - |
|             Tinyield |          4 |  1000 | 307,119.1 ns | 1,192.17 ns | 1,056.82 ns |  1.17 |    0.01 |  43.9453 | 43.4570 | 43.4570 | 277,208 B |
