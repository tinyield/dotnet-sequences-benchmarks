## Every.EveryBench

### Source
[EveryBench.cs](../LinqBenchmarks/Every/EveryBench.cs)

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
|      Method | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |------------:|----------:|----------:|------:|--------:|--------:|------:|------:|----------:|
| **ForeachLoop** |    **10** |    **200.3 ns** |   **1.09 ns** |   **0.96 ns** |  **1.00** |    **0.00** |  **0.0126** |     **-** |     **-** |      **40 B** |
|        Linq |    10 |    655.1 ns |   5.06 ns |   4.73 ns |  3.27 |    0.03 |  0.0839 |     - |     - |     264 B |
|      LinqAF |    10 |    851.6 ns |   4.68 ns |   4.38 ns |  4.25 |    0.02 |  0.0401 |     - |     - |     128 B |
|   HyperLinq |    10 |    850.1 ns |   4.37 ns |   4.09 ns |  4.25 |    0.03 |  0.1116 |     - |     - |     352 B |
|    Tinyield |    10 |  1,421.6 ns |  15.01 ns |  13.30 ns |  7.10 |    0.06 |  1.1673 |     - |     - |   3,664 B |
|             |       |             |           |           |       |         |         |       |       |           |
| **ForeachLoop** |  **1000** | **16,021.0 ns** | **108.21 ns** |  **95.93 ns** |  **1.00** |    **0.00** |       **-** |     **-** |     **-** |      **40 B** |
|        Linq |  1000 | 34,582.1 ns | 233.11 ns | 206.64 ns |  2.16 |    0.01 |  0.0610 |     - |     - |     264 B |
|      LinqAF |  1000 | 50,727.0 ns | 122.78 ns | 102.53 ns |  3.17 |    0.02 |       - |     - |     - |     128 B |
|   HyperLinq |  1000 | 43,130.3 ns | 121.51 ns | 113.66 ns |  2.69 |    0.02 |  0.0610 |     - |     - |     352 B |
|    Tinyield |  1000 | 99,229.1 ns | 529.08 ns | 494.90 ns |  6.20 |    0.05 | 84.4727 |     - |     - | 265,024 B |
