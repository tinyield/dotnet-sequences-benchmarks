## Array.Int32.ArrayInt32WhereCount

### Source
[ArrayInt32WhereCount.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereCount.cs)

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
|               Method | Count |          Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |--------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** |    **10** |      **9.411 ns** |  **0.0596 ns** |  **0.0528 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     10.684 ns |  0.0315 ns |  0.0295 ns |  1.14 |    0.01 |      - |     - |     - |         - |
|                 Linq |    10 |     97.857 ns |  0.5258 ns |  0.4391 ns | 10.39 |    0.07 | 0.0101 |     - |     - |      32 B |
|           LinqFaster |    10 |     34.979 ns |  0.1739 ns |  0.1627 ns |  3.72 |    0.02 |      - |     - |     - |         - |
|               LinqAF |    10 |     50.570 ns |  0.1268 ns |  0.0990 ns |  5.37 |    0.03 |      - |     - |     - |         - |
|           StructLinq |    10 |     69.220 ns |  0.4494 ns |  0.4204 ns |  7.36 |    0.07 | 0.0204 |     - |     - |      64 B |
| StructLinq_IFunction |    10 |     31.445 ns |  0.0924 ns |  0.0819 ns |  3.34 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq |    10 |     41.448 ns |  0.1776 ns |  0.1662 ns |  4.41 |    0.03 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |     30.311 ns |  0.0682 ns |  0.0605 ns |  3.22 |    0.02 |      - |     - |     - |         - |
|             Tinyield |    10 |    169.023 ns |  1.4850 ns |  1.3890 ns | 17.95 |    0.14 | 0.1810 |     - |     - |     568 B |
|                      |       |               |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |  **1,115.196 ns** | **12.3407 ns** | **11.5435 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 |  1,116.276 ns |  7.8286 ns |  6.9398 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|                 Linq |  1000 | 12,093.992 ns | 41.8091 ns | 37.0627 ns | 10.85 |    0.12 |      - |     - |     - |      32 B |
|           LinqFaster |  1000 |  4,244.551 ns | 30.4094 ns | 28.4450 ns |  3.81 |    0.05 |      - |     - |     - |         - |
|               LinqAF |  1000 |  5,282.019 ns | 38.6482 ns | 34.2606 ns |  4.74 |    0.05 |      - |     - |     - |         - |
|           StructLinq |  1000 |  4,301.503 ns | 43.2851 ns | 40.4889 ns |  3.86 |    0.05 | 0.0153 |     - |     - |      64 B |
| StructLinq_IFunction |  1000 |    971.880 ns | 10.5820 ns |  9.3807 ns |  0.87 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |  2,570.393 ns | 10.1639 ns |  7.9353 ns |  2.31 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 |    904.005 ns |  1.8898 ns |  1.5781 ns |  0.81 |    0.01 |      - |     - |     - |         - |
|             Tinyield |  1000 |  9,005.757 ns | 48.3893 ns | 42.8959 ns |  8.08 |    0.06 | 0.1678 |     - |     - |     568 B |
