## List.ValueType.ListValueTypeSkipTakeWhere

### Source
[ListValueTypeSkipTakeWhere.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSkipTakeWhere.cs)

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
|               Method | Skip | Count |         Mean |        Error |       StdDev |       Median |  Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |-------------:|-------------:|-------------:|-------------:|-------:|--------:|--------:|------:|------:|----------:|
|              **ForLoop** | **1000** |    **10** |     **81.72 ns** |     **0.345 ns** |     **0.305 ns** |     **81.62 ns** |   **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop | 1000 |    10 |  5,754.49 ns |    32.003 ns |    29.936 ns |  5,754.99 ns |  70.40 |    0.54 |  0.0305 |     - |     - |      96 B |
|                 Linq | 1000 |    10 |    367.61 ns |     1.839 ns |     1.720 ns |    367.69 ns |   4.50 |    0.03 |  0.1016 |     - |     - |     320 B |
|           LinqFaster | 1000 |    10 |    648.24 ns |     7.056 ns |     6.600 ns |    646.62 ns |   7.94 |    0.08 |  0.7133 |     - |     - |   2,240 B |
|               LinqAF | 1000 |    10 | 27,538.04 ns |   593.426 ns | 1,673.769 ns | 26,800.00 ns | 341.49 |   17.17 |       - |     - |     - |         - |
|           StructLinq | 1000 |    10 |    178.87 ns |     1.027 ns |     0.910 ns |    178.90 ns |   2.19 |    0.02 |  0.0381 |     - |     - |     120 B |
| StructLinq_IFunction | 1000 |    10 |    139.77 ns |     0.422 ns |     0.374 ns |    139.58 ns |   1.71 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq | 1000 |    10 |    202.04 ns |     0.598 ns |     0.559 ns |    201.90 ns |   2.47 |    0.01 |       - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |    10 |    166.81 ns |     0.497 ns |     0.465 ns |    166.89 ns |   2.04 |    0.01 |       - |     - |     - |         - |
|             Tinyield | 1000 |    10 | 17,634.80 ns |    70.929 ns |    62.877 ns | 17,633.08 ns | 215.79 |    1.18 |  0.3357 |     - |     - |   1,096 B |
|                      |      |       |              |              |              |              |        |         |         |       |       |           |
|              **ForLoop** | **1000** |  **1000** |  **7,733.55 ns** |    **33.362 ns** |    **26.047 ns** |  **7,740.40 ns** |   **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop | 1000 |  1000 |  9,756.17 ns |    71.830 ns |    67.189 ns |  9,732.03 ns |   1.26 |    0.01 |  0.0305 |     - |     - |      96 B |
|                 Linq | 1000 |  1000 | 29,390.26 ns |   147.847 ns |   131.063 ns | 29,344.61 ns |   3.80 |    0.03 |  0.0916 |     - |     - |     320 B |
|           LinqFaster | 1000 |  1000 | 48,684.53 ns |   633.963 ns |   593.009 ns | 48,779.32 ns |   6.27 |    0.07 | 61.2183 |     - |     - | 193,616 B |
|               LinqAF | 1000 |  1000 | 51,430.69 ns | 1,026.807 ns | 1,628.624 ns | 51,231.20 ns |   6.72 |    0.27 |       - |     - |     - |         - |
|           StructLinq | 1000 |  1000 | 11,360.30 ns |    55.557 ns |    51.968 ns | 11,349.28 ns |   1.47 |    0.01 |  0.0305 |     - |     - |     120 B |
| StructLinq_IFunction | 1000 |  1000 |  7,311.44 ns |    48.426 ns |    45.298 ns |  7,312.07 ns |   0.94 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq | 1000 |  1000 | 15,804.58 ns |    85.820 ns |    80.276 ns | 15,828.45 ns |   2.04 |    0.01 |       - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |  1000 | 10,680.16 ns |    47.362 ns |    44.302 ns | 10,682.22 ns |   1.38 |    0.01 |       - |     - |     - |         - |
|             Tinyield | 1000 |  1000 | 53,239.29 ns |   411.659 ns |   385.066 ns | 53,251.43 ns |   6.89 |    0.06 |  0.3052 |     - |     - |   1,096 B |
