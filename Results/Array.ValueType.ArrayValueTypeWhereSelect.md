## Array.ValueType.ArrayValueTypeWhereSelect

### Source
[ArrayValueTypeWhereSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeWhereSelect.cs)

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
|              **ForLoop** |    **10** |     **52.93 ns** |   **0.133 ns** |   **0.125 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     68.94 ns |   0.154 ns |   0.129 ns |  1.30 |    0.00 |       - |     - |     - |         - |
|                 Linq |    10 |    200.53 ns |   1.093 ns |   1.023 ns |  3.79 |    0.02 |  0.0687 |     - |     - |     216 B |
|           LinqFaster |    10 |    168.91 ns |   1.549 ns |   1.449 ns |  3.19 |    0.03 |  0.2601 |     - |     - |     816 B |
|               LinqAF |    10 |    269.45 ns |   5.001 ns |   7.173 ns |  5.09 |    0.12 |       - |     - |     - |         - |
|           StructLinq |    10 |    126.80 ns |   0.489 ns |   0.457 ns |  2.40 |    0.01 |  0.0203 |     - |     - |      64 B |
| StructLinq_IFunction |    10 |    127.99 ns |   0.230 ns |   0.180 ns |  2.42 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |    10 |    174.61 ns |   1.178 ns |   1.102 ns |  3.30 |    0.02 |       - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |    149.89 ns |   0.451 ns |   0.422 ns |  2.83 |    0.01 |       - |     - |     - |         - |
|             Tinyield |    10 |    308.09 ns |   3.027 ns |   2.832 ns |  5.82 |    0.05 |  0.2904 |     - |     - |     912 B |
|                      |       |              |            |            |       |         |         |       |       |           |
|              **ForLoop** |  **1000** | **11,638.98 ns** |  **35.695 ns** |  **29.807 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 | 12,925.42 ns |  48.044 ns |  44.940 ns |  1.11 |    0.00 |       - |     - |     - |         - |
|                 Linq |  1000 | 22,749.41 ns | 100.231 ns |  88.853 ns |  1.95 |    0.01 |  0.0610 |     - |     - |     216 B |
|           LinqFaster |  1000 | 24,917.40 ns | 135.829 ns | 120.409 ns |  2.14 |    0.01 | 30.2734 |     - |     - |  96,240 B |
|               LinqAF |  1000 | 31,650.68 ns | 627.089 ns | 697.008 ns |  2.72 |    0.07 |       - |     - |     - |       1 B |
|           StructLinq |  1000 | 17,628.42 ns |  73.668 ns |  65.305 ns |  1.51 |    0.01 |       - |     - |     - |      64 B |
| StructLinq_IFunction |  1000 | 13,224.11 ns |  58.686 ns |  52.024 ns |  1.14 |    0.01 |       - |     - |     - |         - |
|            Hyperlinq |  1000 | 22,674.65 ns |  81.965 ns |  72.660 ns |  1.95 |    0.01 |       - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 | 16,787.76 ns |  87.189 ns |  81.557 ns |  1.44 |    0.01 |       - |     - |     - |         - |
|             Tinyield |  1000 | 23,415.03 ns | 143.845 ns | 134.552 ns |  2.01 |    0.01 |  0.2747 |     - |     - |     912 B |
