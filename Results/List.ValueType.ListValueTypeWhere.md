## List.ValueType.ListValueTypeWhere

### Source
[ListValueTypeWhere.cs](../LinqBenchmarks/List/ValueType/ListValueTypeWhere.cs)

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
|              **ForLoop** |    **10** |     **45.45 ns** |   **0.289 ns** |   **0.226 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     87.33 ns |   0.874 ns |   0.818 ns |  1.92 |    0.02 |       - |     - |     - |         - |
|                 Linq |    10 |    195.92 ns |   2.671 ns |   2.368 ns |  4.30 |    0.05 |  0.0587 |     - |     - |     184 B |
|           LinqFaster |    10 |    112.28 ns |   1.444 ns |   1.280 ns |  2.47 |    0.04 |  0.0994 |     - |     - |     312 B |
|               LinqAF |    10 |    311.43 ns |   6.084 ns |   8.725 ns |  6.88 |    0.25 |       - |     - |     - |         - |
|           StructLinq |    10 |     81.19 ns |   0.432 ns |   0.404 ns |  1.79 |    0.02 |  0.0126 |     - |     - |      40 B |
| StructLinq_IFunction |    10 |     77.73 ns |   0.254 ns |   0.212 ns |  1.71 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |    10 |    143.26 ns |   0.553 ns |   0.517 ns |  3.15 |    0.02 |       - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |    104.09 ns |   0.292 ns |   0.258 ns |  2.29 |    0.01 |       - |     - |     - |         - |
|             Tinyield |    10 |    357.59 ns |   2.565 ns |   2.274 ns |  7.87 |    0.07 |  0.2270 |     - |     - |     712 B |
|                      |       |              |            |            |       |         |         |       |       |           |
|              **ForLoop** |  **1000** |  **7,596.26 ns** |  **82.918 ns** |  **77.562 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 | 10,692.63 ns |  91.360 ns |  80.988 ns |  1.41 |    0.02 |       - |     - |     - |         - |
|                 Linq |  1000 | 20,915.61 ns | 181.702 ns | 151.730 ns |  2.75 |    0.04 |  0.0305 |     - |     - |     184 B |
|           LinqFaster |  1000 | 20,978.85 ns | 302.833 ns | 283.271 ns |  2.76 |    0.05 | 20.8130 |     - |     - |  65,504 B |
|               LinqAF |  1000 | 26,896.91 ns | 372.968 ns | 330.626 ns |  3.54 |    0.05 |       - |     - |     - |         - |
|           StructLinq |  1000 | 10,147.42 ns |  56.946 ns |  53.267 ns |  1.34 |    0.02 |       - |     - |     - |      40 B |
| StructLinq_IFunction |  1000 |  8,087.88 ns |  55.923 ns |  43.661 ns |  1.06 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |  1000 | 20,169.85 ns |  86.681 ns |  76.840 ns |  2.65 |    0.03 |       - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 | 10,619.37 ns |  40.197 ns |  35.633 ns |  1.40 |    0.02 |       - |     - |     - |         - |
|             Tinyield |  1000 | 26,772.85 ns | 143.829 ns | 127.501 ns |  3.52 |    0.04 |  0.2136 |     - |     - |     712 B |
