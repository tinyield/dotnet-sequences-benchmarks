## Array.Int32.ArrayInt32Distinct

### Source
[ArrayInt32Distinct.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Distinct.cs)

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
|               Method | Duplicates | Count |         Mean |     Error |    StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----------- |------ |-------------:|----------:|----------:|------:|--------:|--------:|------:|------:|----------:|
|              **ForLoop** |          **4** |    **10** |     **501.1 ns** |   **5.10 ns** |   **4.77 ns** |  **1.00** |    **0.00** |  **0.2136** |     **-** |     **-** |     **672 B** |
|          ForeachLoop |          4 |    10 |     497.3 ns |   3.35 ns |   2.97 ns |  0.99 |    0.01 |  0.2136 |     - |     - |     672 B |
|                 Linq |          4 |    10 |   1,028.2 ns |   4.70 ns |   4.17 ns |  2.05 |    0.02 |  0.1926 |     - |     - |     608 B |
|               LinqAF |          4 |    10 |   1,173.5 ns |   7.34 ns |   6.87 ns |  2.34 |    0.03 |  0.4120 |     - |     - |   1,296 B |
|           StructLinq |          4 |    10 |     662.7 ns |   3.53 ns |   3.13 ns |  1.32 |    0.02 |  0.0095 |     - |     - |      32 B |
| StructLinq_IFunction |          4 |    10 |     650.9 ns |   1.62 ns |   1.43 ns |  1.30 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |          4 |    10 |     632.7 ns |   4.29 ns |   4.01 ns |  1.26 |    0.02 |       - |     - |     - |         - |
|             Tinyield |          4 |    10 |     770.3 ns |   4.43 ns |   3.92 ns |  1.54 |    0.01 |  0.3948 |     - |     - |   1,240 B |
|                      |            |       |              |           |           |       |         |         |       |       |           |
|              **ForLoop** |          **4** |  **1000** |  **42,128.7 ns** | **259.01 ns** | **242.28 ns** |  **1.00** |    **0.00** | **18.6157** |     **-** |     **-** |  **58,672 B** |
|          ForeachLoop |          4 |  1000 |  42,087.7 ns | 252.89 ns | 236.55 ns |  1.00 |    0.01 | 18.6157 |     - |     - |  58,672 B |
|                 Linq |          4 |  1000 |  87,150.9 ns | 611.39 ns | 571.90 ns |  2.07 |    0.02 | 10.4980 |     - |     - |  33,104 B |
|               LinqAF |          4 |  1000 | 103,955.2 ns | 406.56 ns | 339.50 ns |  2.47 |    0.01 | 36.0107 |     - |     - | 113,184 B |
|           StructLinq |          4 |  1000 |  43,068.3 ns | 320.29 ns | 299.60 ns |  1.02 |    0.01 |       - |     - |     - |      32 B |
| StructLinq_IFunction |          4 |  1000 |  42,803.2 ns | 226.36 ns | 200.67 ns |  1.02 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |          4 |  1000 |  46,654.2 ns | 231.44 ns | 216.49 ns |  1.11 |    0.01 |       - |     - |     - |         - |
|             Tinyield |          4 |  1000 |  55,692.2 ns | 261.41 ns | 231.73 ns |  1.32 |    0.01 | 18.8599 |     - |     - |  59,240 B |
