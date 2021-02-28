## List.Int32.ListInt32WhereSelect

### Source
[ListInt32WhereSelect.cs](../LinqBenchmarks/List/Int32/ListInt32WhereSelect.cs)

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
|               Method | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** |    **10** |     **14.73 ns** |   **0.094 ns** |   **0.088 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     36.00 ns |   0.183 ns |   0.171 ns |  2.44 |    0.02 |      - |     - |     - |         - |
|                 Linq |    10 |    185.26 ns |   0.762 ns |   0.636 ns | 12.58 |    0.07 | 0.0484 |     - |     - |     152 B |
|           LinqFaster |    10 |     68.04 ns |   0.412 ns |   0.344 ns |  4.62 |    0.04 | 0.0229 |     - |     - |      72 B |
|               LinqAF |    10 |    156.59 ns |   0.669 ns |   0.593 ns | 10.63 |    0.06 |      - |     - |     - |         - |
|           StructLinq |    10 |     85.02 ns |   0.203 ns |   0.158 ns |  5.77 |    0.03 | 0.0204 |     - |     - |      64 B |
| StructLinq_IFunction |    10 |     72.49 ns |   0.133 ns |   0.103 ns |  4.92 |    0.03 |      - |     - |     - |         - |
|            Hyperlinq |    10 |     71.85 ns |   0.314 ns |   0.262 ns |  4.88 |    0.03 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |     65.92 ns |   0.183 ns |   0.171 ns |  4.48 |    0.03 |      - |     - |     - |         - |
|             Tinyield |    10 |    343.98 ns |   1.944 ns |   1.818 ns | 23.35 |    0.17 | 0.2828 |     - |     - |     888 B |
|                      |       |              |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |  **1,406.36 ns** |  **12.967 ns** |  **12.129 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 |  4,867.49 ns |  64.955 ns |  60.759 ns |  3.46 |    0.05 |      - |     - |     - |         - |
|                 Linq |  1000 | 14,129.76 ns |  77.388 ns |  72.389 ns | 10.05 |    0.10 | 0.0458 |     - |     - |     152 B |
|           LinqFaster |  1000 |  7,825.72 ns |  45.306 ns |  42.380 ns |  5.56 |    0.06 | 1.3580 |     - |     - |   4,304 B |
|               LinqAF |  1000 | 15,710.22 ns |  86.657 ns |  76.819 ns | 11.17 |    0.12 |      - |     - |     - |         - |
|           StructLinq |  1000 |  6,989.78 ns |  44.280 ns |  41.419 ns |  4.97 |    0.05 | 0.0153 |     - |     - |      64 B |
| StructLinq_IFunction |  1000 |  2,071.90 ns |  16.925 ns |  15.003 ns |  1.47 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |  6,682.62 ns |  44.911 ns |  42.010 ns |  4.75 |    0.05 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 |  2,701.97 ns |  21.866 ns |  20.454 ns |  1.92 |    0.03 |      - |     - |     - |         - |
|             Tinyield |  1000 | 19,717.43 ns | 131.753 ns | 116.796 ns | 14.01 |    0.12 | 0.2747 |     - |     - |     888 B |
