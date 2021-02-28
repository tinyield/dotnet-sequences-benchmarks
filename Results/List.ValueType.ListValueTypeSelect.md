## List.ValueType.ListValueTypeSelect

### Source
[ListValueTypeSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSelect.cs)

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
|                      Method | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |------------:|----------:|----------:|------:|--------:|--------:|------:|------:|----------:|
|                     **ForLoop** |    **10** |    **230.0 ns** |   **0.51 ns** |   **0.40 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop |    10 |    272.1 ns |   0.57 ns |   0.53 ns |  1.18 |    0.00 |       - |     - |     - |         - |
|                        Linq |    10 |    438.2 ns |   1.96 ns |   1.84 ns |  1.90 |    0.01 |  0.0587 |     - |     - |     184 B |
|                  LinqFaster |    10 |    391.9 ns |   2.26 ns |   2.12 ns |  1.70 |    0.01 |  0.2217 |     - |     - |     696 B |
|                      LinqAF |    10 |    563.0 ns |   7.12 ns |   6.66 ns |  2.44 |    0.03 |       - |     - |     - |         - |
|                  StructLinq |    10 |    284.3 ns |   0.96 ns |   0.85 ns |  1.24 |    0.01 |  0.0124 |     - |     - |      40 B |
|        StructLinq_IFunction |    10 |    296.8 ns |   0.37 ns |   0.29 ns |  1.29 |    0.00 |       - |     - |     - |         - |
|           Hyperlinq_Foreach |    10 |    306.5 ns |   1.29 ns |   1.21 ns |  1.33 |    0.01 |       - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction |    10 |    263.0 ns |   1.39 ns |   1.23 ns |  1.14 |    0.01 |       - |     - |     - |         - |
|               Hyperlinq_For |    10 |    287.4 ns |   0.79 ns |   0.66 ns |  1.25 |    0.00 |       - |     - |     - |         - |
|     Hyperlinq_For_IFunction |    10 |    251.7 ns |   0.81 ns |   0.71 ns |  1.09 |    0.00 |       - |     - |     - |         - |
|                    Tinyield |    10 |    537.1 ns |   3.73 ns |   3.49 ns |  2.34 |    0.02 |  0.2270 |     - |     - |     712 B |
|                             |       |             |           |           |       |         |         |       |       |           |
|                     **ForLoop** |  **1000** | **22,491.3 ns** |  **39.68 ns** |  **35.18 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop |  1000 | 25,509.8 ns | 124.78 ns | 116.72 ns |  1.13 |    0.01 |       - |     - |     - |         - |
|                        Linq |  1000 | 35,475.0 ns | 156.12 ns | 121.89 ns |  1.58 |    0.00 |       - |     - |     - |     184 B |
|                  LinqFaster |  1000 | 41,820.7 ns | 413.64 ns | 345.41 ns |  1.86 |    0.02 | 20.3857 |     - |     - |  64,056 B |
|                      LinqAF |  1000 | 44,079.2 ns | 683.68 ns | 606.06 ns |  1.96 |    0.03 |       - |     - |     - |         - |
|                  StructLinq |  1000 | 24,754.3 ns |  40.70 ns |  33.99 ns |  1.10 |    0.00 |       - |     - |     - |      40 B |
|        StructLinq_IFunction |  1000 | 24,431.0 ns |  73.32 ns |  64.99 ns |  1.09 |    0.00 |       - |     - |     - |         - |
|           Hyperlinq_Foreach |  1000 | 26,268.8 ns |  67.56 ns |  63.19 ns |  1.17 |    0.00 |       - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction |  1000 | 22,660.2 ns |  47.16 ns |  41.80 ns |  1.01 |    0.00 |       - |     - |     - |         - |
|               Hyperlinq_For |  1000 | 26,589.9 ns |  69.49 ns |  65.00 ns |  1.18 |    0.00 |       - |     - |     - |         - |
|     Hyperlinq_For_IFunction |  1000 | 22,872.2 ns |  37.23 ns |  34.83 ns |  1.02 |    0.00 |       - |     - |     - |         - |
|                    Tinyield |  1000 | 37,233.4 ns | 128.26 ns | 119.98 ns |  1.66 |    0.01 |  0.1831 |     - |     - |     712 B |
