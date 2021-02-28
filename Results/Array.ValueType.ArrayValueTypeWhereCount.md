## Array.ValueType.ArrayValueTypeWhereCount

### Source
[ArrayValueTypeWhereCount.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereCount.cs)

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
|              **ForLoop** |    **10** |     **11.54 ns** |   **0.070 ns** |   **0.066 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     20.62 ns |   0.079 ns |   0.070 ns |  1.79 |    0.01 |      - |     - |     - |         - |
|                 Linq |    10 |    102.67 ns |   0.420 ns |   0.373 ns |  8.90 |    0.07 | 0.0101 |     - |     - |      32 B |
|           LinqFaster |    10 |     37.42 ns |   0.305 ns |   0.270 ns |  3.24 |    0.03 |      - |     - |     - |         - |
|               LinqAF |    10 |    124.12 ns |   2.462 ns |   4.860 ns | 10.76 |    0.53 |      - |     - |     - |         - |
|           StructLinq |    10 |     73.06 ns |   0.641 ns |   0.568 ns |  6.33 |    0.06 | 0.0204 |     - |     - |      64 B |
| StructLinq_IFunction |    10 |     56.55 ns |   0.205 ns |   0.182 ns |  4.90 |    0.03 |      - |     - |     - |         - |
|            Hyperlinq |    10 |     91.12 ns |   0.510 ns |   0.477 ns |  7.90 |    0.07 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |     72.25 ns |   0.208 ns |   0.185 ns |  6.26 |    0.05 |      - |     - |     - |         - |
|             Tinyield |    10 |    197.20 ns |   1.502 ns |   1.405 ns | 17.10 |    0.18 | 0.1810 |     - |     - |     568 B |
|                      |       |              |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |  **1,151.30 ns** |  **10.805 ns** |  **10.107 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 |  5,911.47 ns |  29.351 ns |  27.455 ns |  5.14 |    0.05 |      - |     - |     - |         - |
|                 Linq |  1000 | 13,544.89 ns |  51.464 ns |  48.140 ns | 11.77 |    0.10 |      - |     - |     - |      32 B |
|           LinqFaster |  1000 |  5,287.26 ns |  41.392 ns |  36.692 ns |  4.59 |    0.05 |      - |     - |     - |         - |
|               LinqAF |  1000 | 16,757.28 ns | 334.198 ns | 343.197 ns | 14.59 |    0.32 |      - |     - |     - |         - |
|           StructLinq |  1000 |  6,722.75 ns |  48.838 ns |  45.683 ns |  5.84 |    0.05 | 0.0153 |     - |     - |      64 B |
| StructLinq_IFunction |  1000 |  2,122.11 ns |  24.450 ns |  22.870 ns |  1.84 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |  7,169.24 ns |  24.356 ns |  22.782 ns |  6.23 |    0.05 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 |  5,261.32 ns |  16.151 ns |  13.487 ns |  4.57 |    0.05 |      - |     - |     - |         - |
|             Tinyield |  1000 | 14,554.09 ns | 140.065 ns | 131.017 ns | 12.64 |    0.14 | 0.1678 |     - |     - |     568 B |
