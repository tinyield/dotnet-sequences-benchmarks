## Enumerable.Int32.EnumerableInt32Distinct

### Source
[EnumerableInt32Distinct.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Distinct.cs)

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
|               Method | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |------------:|----------:|----------:|------:|--------:|--------:|------:|------:|----------:|
|          **ForeachLoop** |    **10** |    **339.9 ns** |   **2.38 ns** |   **2.11 ns** |  **1.00** |    **0.00** |  **0.2270** |     **-** |     **-** |     **712 B** |
|                 Linq |    10 |    460.8 ns |   3.38 ns |   3.16 ns |  1.36 |    0.01 |  0.1960 |     - |     - |     616 B |
|               LinqAF |    10 |    609.9 ns |   3.22 ns |   2.69 ns |  1.79 |    0.01 |  0.1955 |     - |     - |     616 B |
|           StructLinq |    10 |    471.2 ns |   2.23 ns |   1.86 ns |  1.39 |    0.01 |  0.0200 |     - |     - |      64 B |
| StructLinq_IFunction |    10 |    475.8 ns |   1.64 ns |   1.28 ns |  1.40 |    0.01 |  0.0124 |     - |     - |      40 B |
|            Hyperlinq |    10 |    400.3 ns |   3.21 ns |   3.00 ns |  1.18 |    0.01 |  0.0124 |     - |     - |      40 B |
|             Tinyield |    10 |    514.5 ns |   4.82 ns |   4.51 ns |  1.51 |    0.02 |  0.4053 |     - |     - |   1,272 B |
|                      |       |             |           |           |       |         |         |       |       |           |
|          **ForeachLoop** |  **1000** | **23,556.4 ns** | **131.34 ns** | **109.68 ns** |  **1.00** |    **0.00** | **18.6157** |     **-** |     **-** |  **58,712 B** |
|                 Linq |  1000 | 32,734.4 ns | 173.34 ns | 153.66 ns |  1.39 |    0.01 | 10.4980 |     - |     - |  33,112 B |
|               LinqAF |  1000 | 43,018.8 ns | 235.04 ns | 208.36 ns |  1.83 |    0.01 | 13.0615 |     - |     - |  41,224 B |
|           StructLinq |  1000 | 22,819.9 ns | 256.54 ns | 239.97 ns |  0.97 |    0.01 |       - |     - |     - |      64 B |
| StructLinq_IFunction |  1000 | 23,975.6 ns | 106.18 ns |  94.12 ns |  1.02 |    0.01 |       - |     - |     - |      40 B |
|            Hyperlinq |  1000 | 23,017.8 ns | 107.21 ns |  95.04 ns |  0.98 |    0.01 |       - |     - |     - |      40 B |
|             Tinyield |  1000 | 28,813.3 ns | 186.71 ns | 165.51 ns |  1.22 |    0.01 | 18.8599 |     - |     - |  59,272 B |
