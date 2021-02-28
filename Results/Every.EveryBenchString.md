## Every.EveryBenchString

### Source
[EveryBenchString.cs](../LinqBenchmarks/Every/EveryBenchString.cs)

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
|      Method | Count |        Mean |     Error |    StdDev |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |------------:|----------:|----------:|--------:|------:|------:|----------:|
| **ForeachLoop** |    **10** |    **190.7 ns** |   **0.93 ns** |   **0.87 ns** |  **0.0126** |     **-** |     **-** |      **40 B** |
|        Linq |    10 |    659.1 ns |   3.78 ns |   3.35 ns |  0.0839 |     - |     - |     264 B |
|      LinqAF |    10 |    928.8 ns |   7.14 ns |   6.68 ns |  0.0401 |     - |     - |     128 B |
|   HyperLinq |    10 |    652.5 ns |   3.02 ns |   2.36 ns |  0.0935 |     - |     - |     296 B |
|    Tinyield |    10 |  1,438.3 ns |  14.80 ns |  13.84 ns |  1.1673 |     - |     - |   3,664 B |
| **ForeachLoop** |  **1000** | **15,293.3 ns** |  **52.65 ns** |  **46.68 ns** |       **-** |     **-** |     **-** |      **40 B** |
|        Linq |  1000 | 36,056.6 ns | 172.73 ns | 153.12 ns |  0.0610 |     - |     - |     264 B |
|      LinqAF |  1000 | 54,917.6 ns | 314.74 ns | 294.40 ns |       - |     - |     - |     128 B |
|   HyperLinq |  1000 | 34,009.4 ns | 339.58 ns | 301.03 ns |  0.0610 |     - |     - |     296 B |
|    Tinyield |  1000 | 98,532.0 ns | 648.21 ns | 606.34 ns | 84.4727 |     - |     - | 265,024 B |
