## List.ValueType.ListValueTypeWhereSelect

### Source
[ListValueTypeWhereSelect.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhereSelect.cs)

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
|               Method | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-------------:|-----------:|-----------:|------:|--------:|--------:|------:|------:|----------:|
|              **ForLoop** |    **10** |     **66.00 ns** |   **0.334 ns** |   **0.296 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |    107.92 ns |   0.585 ns |   0.489 ns |  1.64 |    0.01 |       - |     - |     - |         - |
|                 Linq |    10 |    274.05 ns |   2.399 ns |   2.004 ns |  4.15 |    0.03 |  0.1197 |     - |     - |     376 B |
|           LinqFaster |    10 |    164.45 ns |   3.081 ns |   2.882 ns |  2.49 |    0.05 |  0.0994 |     - |     - |     312 B |
|               LinqAF |    10 |    359.75 ns |   6.244 ns |   5.841 ns |  5.46 |    0.09 |       - |     - |     - |         - |
|           StructLinq |    10 |    128.84 ns |   0.737 ns |   0.690 ns |  1.95 |    0.01 |  0.0229 |     - |     - |      72 B |
| StructLinq_IFunction |    10 |    127.56 ns |   0.465 ns |   0.412 ns |  1.93 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |    10 |    169.36 ns |   0.566 ns |   0.502 ns |  2.57 |    0.01 |       - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |    162.48 ns |   0.681 ns |   0.604 ns |  2.46 |    0.01 |       - |     - |     - |         - |
|             Tinyield |    10 |    446.41 ns |   1.408 ns |   1.176 ns |  6.76 |    0.04 |  0.3185 |     - |     - |   1,000 B |
|                      |       |              |            |            |       |         |         |       |       |           |
|              **ForLoop** |  **1000** | **12,562.86 ns** |  **51.053 ns** |  **47.755 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 | 16,473.84 ns |  90.427 ns |  84.585 ns |  1.31 |    0.01 |       - |     - |     - |         - |
|                 Linq |  1000 | 26,850.91 ns | 141.852 ns | 132.689 ns |  2.14 |    0.01 |  0.0916 |     - |     - |     376 B |
|           LinqFaster |  1000 | 32,360.76 ns | 406.919 ns | 360.723 ns |  2.58 |    0.03 | 20.8130 |     - |     - |  65,504 B |
|               LinqAF |  1000 | 37,628.48 ns | 746.745 ns | 830.005 ns |  3.00 |    0.07 |       - |     - |     - |         - |
|           StructLinq |  1000 | 17,488.11 ns | 110.718 ns |  98.149 ns |  1.39 |    0.01 |       - |     - |     - |      72 B |
| StructLinq_IFunction |  1000 | 13,849.49 ns |  58.864 ns |  55.061 ns |  1.10 |    0.00 |       - |     - |     - |         - |
|            Hyperlinq |  1000 | 21,806.41 ns | 170.647 ns | 151.274 ns |  1.74 |    0.01 |       - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 | 17,311.90 ns |  44.533 ns |  41.656 ns |  1.38 |    0.01 |       - |     - |     - |         - |
|             Tinyield |  1000 | 33,809.03 ns | 232.188 ns | 205.828 ns |  2.69 |    0.02 |  0.3052 |     - |     - |   1,000 B |
