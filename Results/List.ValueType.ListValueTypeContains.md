## List.ValueType.ListValueTypeContains

### Source
[ListValueTypeContains.cs](../LinqBenchmarks/List/ValueType/ListValueTypeContains.cs)

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
|              **ForLoop** |    **10** |     **85.13 ns** |   **0.351 ns** |   **0.311 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |    137.81 ns |   2.797 ns |   4.973 ns |  1.63 |    0.05 |      - |     - |     - |         - |
|                 Linq |    10 |     37.58 ns |   0.191 ns |   0.169 ns |  0.44 |    0.00 |      - |     - |     - |         - |
|           LinqFaster |    10 |     35.73 ns |   0.190 ns |   0.168 ns |  0.42 |    0.00 |      - |     - |     - |         - |
|               LinqAF |    10 |     43.83 ns |   0.329 ns |   0.292 ns |  0.51 |    0.00 |      - |     - |     - |         - |
|           StructLinq |    10 |     70.87 ns |   0.704 ns |   0.624 ns |  0.83 |    0.01 | 0.0126 |     - |     - |      40 B |
| StructLinq_IFunction |    10 |     77.36 ns |   0.385 ns |   0.361 ns |  0.91 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |    10 |     42.47 ns |   0.219 ns |   0.205 ns |  0.50 |    0.00 |      - |     - |     - |         - |
|                      |       |              |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |  **8,432.44 ns** |  **42.551 ns** |  **37.720 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 | 10,940.49 ns | 218.711 ns | 637.990 ns |  1.27 |    0.07 |      - |     - |     - |         - |
|                 Linq |  1000 |  2,941.82 ns |   6.608 ns |   5.159 ns |  0.35 |    0.00 |      - |     - |     - |         - |
|           LinqFaster |  1000 |  2,599.11 ns |  14.532 ns |  12.135 ns |  0.31 |    0.00 |      - |     - |     - |         - |
|               LinqAF |  1000 |  3,382.68 ns |   7.920 ns |   7.021 ns |  0.40 |    0.00 |      - |     - |     - |         - |
|           StructLinq |  1000 |  4,804.54 ns |  17.277 ns |  13.489 ns |  0.57 |    0.00 | 0.0076 |     - |     - |      40 B |
| StructLinq_IFunction |  1000 |  4,784.45 ns |  21.868 ns |  20.456 ns |  0.57 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |  3,317.36 ns |  14.553 ns |  12.901 ns |  0.39 |    0.00 |      - |     - |     - |         - |
