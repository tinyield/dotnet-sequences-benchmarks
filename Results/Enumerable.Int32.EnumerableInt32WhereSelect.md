## Enumerable.Int32.EnumerableInt32WhereSelect

### Source
[EnumerableInt32WhereSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32WhereSelect.cs)

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
|               Method | Count |         Mean |      Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-------------:|-----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|          **ForeachLoop** |    **10** |     **81.89 ns** |   **0.932 ns** |  **0.827 ns** |  **1.00** |    **0.00** | **0.0126** |     **-** |     **-** |      **40 B** |
|                 Linq |    10 |    257.70 ns |   2.027 ns |  1.796 ns |  3.15 |    0.04 | 0.0505 |     - |     - |     160 B |
|               LinqAF |    10 |    199.16 ns |   1.337 ns |  1.251 ns |  2.43 |    0.04 | 0.0126 |     - |     - |      40 B |
|           StructLinq |    10 |    169.24 ns |   1.314 ns |  1.229 ns |  2.07 |    0.03 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction |    10 |    114.89 ns |   0.498 ns |  0.442 ns |  1.40 |    0.02 | 0.0126 |     - |     - |      40 B |
|            Hyperlinq |    10 |    157.37 ns |   0.672 ns |  0.596 ns |  1.92 |    0.02 | 0.0126 |     - |     - |      40 B |
|  Hyperlinq_IFunction |    10 |    112.03 ns |   0.370 ns |  0.347 ns |  1.37 |    0.01 | 0.0126 |     - |     - |      40 B |
|             Tinyield |    10 |    345.08 ns |   1.909 ns |  1.692 ns |  4.21 |    0.05 | 0.2828 |     - |     - |     888 B |
|                      |       |              |            |           |       |         |        |       |       |           |
|          **ForeachLoop** |  **1000** |  **5,983.45 ns** |  **44.536 ns** | **41.659 ns** |  **1.00** |    **0.00** | **0.0076** |     **-** |     **-** |      **40 B** |
|                 Linq |  1000 | 13,265.39 ns |  32.770 ns | 29.050 ns |  2.22 |    0.02 | 0.0458 |     - |     - |     160 B |
|               LinqAF |  1000 | 11,349.02 ns |  61.912 ns | 57.913 ns |  1.90 |    0.01 |      - |     - |     - |      40 B |
|           StructLinq |  1000 | 10,324.29 ns | 100.360 ns | 88.967 ns |  1.73 |    0.01 | 0.0305 |     - |     - |      96 B |
| StructLinq_IFunction |  1000 |  7,709.84 ns |  46.566 ns | 41.280 ns |  1.29 |    0.01 |      - |     - |     - |      40 B |
|            Hyperlinq |  1000 | 10,457.10 ns |  51.624 ns | 45.763 ns |  1.75 |    0.01 |      - |     - |     - |      40 B |
|  Hyperlinq_IFunction |  1000 |  6,798.80 ns |  31.181 ns | 27.641 ns |  1.14 |    0.01 | 0.0076 |     - |     - |      40 B |
|             Tinyield |  1000 | 12,771.07 ns |  34.981 ns | 32.721 ns |  2.13 |    0.02 | 0.2747 |     - |     - |     888 B |
