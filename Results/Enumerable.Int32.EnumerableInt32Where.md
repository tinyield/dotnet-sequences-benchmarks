## Enumerable.Int32.EnumerableInt32Where

### Source
[EnumerableInt32Where.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Where.cs)

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
|               Method | Count |        Mean |    Error |   StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |------------:|---------:|---------:|------:|--------:|-------:|------:|------:|----------:|
|                 **Linq** |    **10** |    **208.8 ns** |  **1.70 ns** |  **1.59 ns** |  **1.00** |    **0.00** | **0.0305** |     **-** |     **-** |      **96 B** |
|               LinqAF |    10 |    169.1 ns |  0.70 ns |  0.62 ns |  0.81 |    0.00 | 0.0126 |     - |     - |      40 B |
|           StructLinq |    10 |    139.9 ns |  0.74 ns |  0.69 ns |  0.67 |    0.01 | 0.0203 |     - |     - |      64 B |
| StructLinq_IFunction |    10 |    103.6 ns |  0.34 ns |  0.30 ns |  0.50 |    0.00 | 0.0126 |     - |     - |      40 B |
|            Hyperlinq |    10 |    130.4 ns |  0.76 ns |  0.63 ns |  0.62 |    0.01 | 0.0126 |     - |     - |      40 B |
|  Hyperlinq_IFunction |    10 |    104.6 ns |  0.58 ns |  0.54 ns |  0.50 |    0.01 | 0.0126 |     - |     - |      40 B |
|             Tinyield |    10 |    272.6 ns |  4.72 ns |  4.41 ns |  1.31 |    0.03 | 0.1912 |     - |     - |     600 B |
|                      |       |             |          |          |       |         |        |       |       |           |
|                 **Linq** |  **1000** | **11,199.7 ns** | **40.10 ns** | **35.55 ns** |  **1.00** |    **0.00** | **0.0305** |     **-** |     **-** |      **96 B** |
|               LinqAF |  1000 | 10,744.3 ns | 27.57 ns | 21.53 ns |  0.96 |    0.00 |      - |     - |     - |      40 B |
|           StructLinq |  1000 |  9,685.7 ns | 41.73 ns | 36.99 ns |  0.86 |    0.00 | 0.0153 |     - |     - |      64 B |
| StructLinq_IFunction |  1000 |  7,738.7 ns | 41.78 ns | 39.08 ns |  0.69 |    0.00 |      - |     - |     - |      40 B |
|            Hyperlinq |  1000 |  9,535.3 ns | 52.41 ns | 49.02 ns |  0.85 |    0.00 |      - |     - |     - |      40 B |
|  Hyperlinq_IFunction |  1000 |  7,537.7 ns | 26.47 ns | 20.67 ns |  0.67 |    0.00 | 0.0076 |     - |     - |      40 B |
|             Tinyield |  1000 | 11,593.1 ns | 26.68 ns | 22.28 ns |  1.03 |    0.00 | 0.1831 |     - |     - |     600 B |
