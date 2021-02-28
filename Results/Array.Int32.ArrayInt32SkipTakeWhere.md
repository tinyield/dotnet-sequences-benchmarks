## Array.Int32.ArrayInt32SkipTakeWhere

### Source
[ArrayInt32SkipTakeWhere.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SkipTakeWhere.cs)

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
|               Method | Skip | Count |         Mean |     Error |    StdDev |  Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |-------------:|----------:|----------:|-------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** | **1000** |    **10** |     **12.73 ns** |  **0.045 ns** |  **0.042 ns** |   **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop | 1000 |    10 |  3,002.72 ns | 13.203 ns | 11.704 ns | 235.96 |    1.38 | 0.0076 |     - |     - |      32 B |
|                 Linq | 1000 |    10 |    303.97 ns |  2.299 ns |  2.151 ns |  23.88 |    0.21 | 0.0482 |     - |     - |     152 B |
|           LinqFaster | 1000 |    10 |     94.27 ns |  0.766 ns |  0.716 ns |   7.41 |    0.06 | 0.0764 |     - |     - |     240 B |
|               LinqAF | 1000 |    10 |  2,815.44 ns |  8.421 ns |  7.877 ns | 221.19 |    0.76 |      - |     - |     - |         - |
|           StructLinq | 1000 |    10 |    120.48 ns |  1.000 ns |  0.935 ns |   9.47 |    0.08 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction | 1000 |    10 |     55.52 ns |  0.186 ns |  0.174 ns |   4.36 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq | 1000 |    10 |     85.95 ns |  0.309 ns |  0.274 ns |   6.75 |    0.02 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |    10 |     76.40 ns |  0.193 ns |  0.171 ns |   6.00 |    0.03 |      - |     - |     - |         - |
|             Tinyield | 1000 |    10 |  8,010.39 ns | 26.193 ns | 23.220 ns | 629.48 |    1.97 | 0.2899 |     - |     - |     952 B |
|                      |      |       |              |           |           |        |         |        |       |       |           |
|              **ForLoop** | **1000** |  **1000** |  **1,304.70 ns** |  **8.093 ns** |  **7.570 ns** |   **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop | 1000 |  1000 |  5,880.04 ns | 31.999 ns | 28.366 ns |   4.51 |    0.03 | 0.0076 |     - |     - |      32 B |
|                 Linq | 1000 |  1000 | 21,281.60 ns | 71.478 ns | 63.364 ns |  16.32 |    0.10 | 0.0305 |     - |     - |     152 B |
|           LinqFaster | 1000 |  1000 |  6,044.69 ns | 45.723 ns | 40.532 ns |   4.64 |    0.04 | 4.4785 |     - |     - |  14,064 B |
|               LinqAF | 1000 |  1000 | 20,304.09 ns | 45.261 ns | 40.123 ns |  15.57 |    0.11 |      - |     - |     - |         - |
|           StructLinq | 1000 |  1000 |  7,513.04 ns | 22.404 ns | 20.957 ns |   5.76 |    0.03 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction | 1000 |  1000 |  2,197.56 ns | 21.645 ns | 18.074 ns |   1.69 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq | 1000 |  1000 |  7,391.98 ns | 19.241 ns | 17.057 ns |   5.67 |    0.04 |      - |     - |     - |         - |
|  Hyperlinq_IFunction | 1000 |  1000 |  2,731.11 ns | 10.592 ns |  9.390 ns |   2.09 |    0.01 |      - |     - |     - |         - |
|             Tinyield | 1000 |  1000 | 24,767.37 ns | 63.133 ns | 59.054 ns |  18.98 |    0.13 | 0.2747 |     - |     - |     952 B |
