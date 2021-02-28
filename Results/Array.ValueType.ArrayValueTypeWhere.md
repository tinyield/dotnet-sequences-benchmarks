## Array.ValueType.ArrayValueTypeWhere

### Source
[ArrayValueTypeWhere.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhere.cs)

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
|              **ForLoop** |    **10** |     **30.07 ns** |   **0.056 ns** |   **0.047 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     44.97 ns |   0.179 ns |   0.167 ns |  1.49 |    0.00 |       - |     - |     - |         - |
|                 Linq |    10 |    283.27 ns |   0.687 ns |   0.643 ns |  9.42 |    0.03 |  0.0331 |     - |     - |     104 B |
|           LinqFaster |    10 |    142.45 ns |   0.823 ns |   0.770 ns |  4.73 |    0.03 |  0.2601 |     - |     - |     816 B |
|               LinqAF |    10 |    198.74 ns |   3.931 ns |   4.679 ns |  6.59 |    0.12 |       - |     - |     - |         - |
|           StructLinq |    10 |     81.07 ns |   0.262 ns |   0.245 ns |  2.70 |    0.01 |  0.0101 |     - |     - |      32 B |
| StructLinq_IFunction |    10 |     73.30 ns |   0.161 ns |   0.151 ns |  2.44 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |    10 |    143.15 ns |   0.387 ns |   0.362 ns |  4.76 |    0.01 |       - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |    104.97 ns |   0.241 ns |   0.188 ns |  3.49 |    0.01 |       - |     - |     - |         - |
|             Tinyield |    10 |    218.44 ns |   0.976 ns |   0.815 ns |  7.26 |    0.03 |  0.1988 |     - |     - |     624 B |
|                      |       |              |            |            |       |         |         |       |       |           |
|              **ForLoop** |  **1000** |  **6,329.37 ns** |  **25.530 ns** |  **22.631 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 |  7,567.42 ns |  59.566 ns |  49.741 ns |  1.20 |    0.01 |       - |     - |     - |         - |
|                 Linq |  1000 | 19,029.22 ns |  72.711 ns |  68.014 ns |  3.01 |    0.02 |  0.0305 |     - |     - |     104 B |
|           LinqFaster |  1000 | 19,454.69 ns | 184.587 ns | 163.632 ns |  3.07 |    0.03 | 30.2734 |     - |     - |  96,240 B |
|               LinqAF |  1000 | 35,155.64 ns | 296.572 ns | 277.413 ns |  5.55 |    0.04 |       - |     - |     - |         - |
|           StructLinq |  1000 | 12,632.71 ns |  45.562 ns |  40.390 ns |  2.00 |    0.01 |       - |     - |     - |      32 B |
| StructLinq_IFunction |  1000 |  9,143.70 ns |  63.347 ns |  56.155 ns |  1.44 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |  1000 | 19,104.87 ns |  93.038 ns |  87.028 ns |  3.02 |    0.02 |       - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 | 10,953.96 ns |  57.346 ns |  53.642 ns |  1.73 |    0.01 |       - |     - |     - |         - |
|             Tinyield |  1000 | 25,049.34 ns |  55.784 ns |  52.181 ns |  3.96 |    0.02 |  0.1831 |     - |     - |     624 B |
