## Array.ValueType.ArrayValueTypeSkipTakeWhere

### Source
[ArrayValueTypeSkipTakeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSkipTakeWhere.cs)

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
|               Method | Skip | Count |         Mean |      Error |       StdDev |  Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |-------------:|-----------:|-------------:|-------:|--------:|--------:|------:|------:|----------:|
|              **ForLoop** | **1000** |    **10** |     **62.33 ns** |   **0.208 ns** |     **0.195 ns** |   **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop | 1000 |    10 |  3,077.93 ns |  10.775 ns |     9.551 ns |  49.39 |    0.24 |  0.0076 |     - |     - |      32 B |
|                 Linq | 1000 |    10 |    383.08 ns |   1.450 ns |     1.211 ns |   6.15 |    0.03 |  0.1016 |     - |     - |     320 B |
|           LinqFaster | 1000 |    10 |    366.01 ns |   3.697 ns |     3.458 ns |   5.87 |    0.06 |  0.7443 |     - |     - |   2,336 B |
|               LinqAF | 1000 |    10 |  7,358.79 ns | 122.829 ns |   150.845 ns | 118.09 |    2.42 |       - |     - |     - |         - |
|           StructLinq | 1000 |    10 |    163.03 ns |   0.558 ns |     0.522 ns |   2.62 |    0.01 |  0.0305 |     - |     - |      96 B |
| StructLinq_IFunction | 1000 |    10 |    106.66 ns |   0.153 ns |     0.135 ns |   1.71 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq | 1000 |    10 |    244.67 ns |   0.690 ns |     0.646 ns |   3.93 |    0.01 |       - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |    10 |    164.37 ns |   0.370 ns |     0.346 ns |   2.64 |    0.01 |       - |     - |     - |         - |
|             Tinyield | 1000 |    10 |  7,968.51 ns |  44.951 ns |    37.536 ns | 127.94 |    0.68 |  0.3204 |     - |     - |   1,008 B |
|                      |      |       |              |            |              |        |         |         |       |       |           |
|              **ForLoop** | **1000** |  **1000** |  **6,360.53 ns** |  **24.247 ns** |    **22.681 ns** |   **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop | 1000 |  1000 |  6,635.69 ns |  32.728 ns |    30.614 ns |   1.04 |    0.01 |  0.0076 |     - |     - |      32 B |
|                 Linq | 1000 |  1000 | 26,337.83 ns |  85.058 ns |    71.027 ns |   4.14 |    0.02 |  0.0916 |     - |     - |     320 B |
|           LinqFaster | 1000 |  1000 | 34,433.90 ns | 346.230 ns |   323.864 ns |   5.41 |    0.05 | 70.1294 |     - |     - | 223,520 B |
|               LinqAF | 1000 |  1000 | 41,090.80 ns | 819.481 ns | 1,323.308 ns |   6.39 |    0.18 |       - |     - |     - |         - |
|           StructLinq | 1000 |  1000 | 10,511.13 ns |  77.757 ns |    64.931 ns |   1.65 |    0.01 |  0.0305 |     - |     - |      96 B |
| StructLinq_IFunction | 1000 |  1000 |  7,446.91 ns |  36.860 ns |    32.676 ns |   1.17 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq | 1000 |  1000 | 15,887.04 ns |  68.175 ns |    63.771 ns |   2.50 |    0.01 |       - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |  1000 | 10,834.94 ns |  46.768 ns |    41.459 ns |   1.70 |    0.01 |       - |     - |     - |         - |
|             Tinyield | 1000 |  1000 | 40,155.30 ns | 145.438 ns |   128.927 ns |   6.32 |    0.02 |  0.3052 |     - |     - |   1,008 B |
