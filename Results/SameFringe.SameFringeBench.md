## SameFringe.SameFringeBench

### Source
[SameFringeBench.cs](../LinqBenchmarks/SameFringe/SameFringeBench.cs)

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
|      Method | Count |       Mean |      Error |     StdDev |     Median | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |------ |-----------:|-----------:|-----------:|-----------:|------:|--------:|--------:|------:|------:|----------:|
| **ForeachLoop** |    **10** |   **2.898 μs** |  **0.0221 μs** |  **0.0196 μs** |   **2.892 μs** |  **1.00** |    **0.00** |  **0.5798** |     **-** |     **-** |      **2 KB** |
|        Linq |    10 |   3.328 μs |  0.0214 μs |  0.0189 μs |   3.322 μs |  1.15 |    0.01 |  0.6104 |     - |     - |      2 KB |
|      LinqAF |    10 |  10.988 μs |  0.7622 μs |  2.1622 μs |   9.900 μs |  4.04 |    0.76 |       - |     - |     - |      2 KB |
|   HyperLinq |    10 |   3.273 μs |  0.0332 μs |  0.0294 μs |   3.270 μs |  1.13 |    0.01 |  0.6256 |     - |     - |      2 KB |
|    Tinyield |    10 |   1.891 μs |  0.0207 μs |  0.0183 μs |   1.886 μs |  0.65 |    0.01 |  1.2531 |     - |     - |      4 KB |
|             |       |            |            |            |            |       |         |         |       |       |           |
| **ForeachLoop** |  **1000** | **612.210 μs** |  **6.3196 μs** |  **5.9113 μs** | **610.788 μs** |  **1.00** |    **0.00** | **60.5469** |     **-** |     **-** |    **187 KB** |
|        Linq |  1000 | 648.040 μs |  7.0996 μs |  6.2936 μs | 645.545 μs |  1.06 |    0.01 | 60.5469 |     - |     - |    188 KB |
|      LinqAF |  1000 | 661.462 μs |  3.6553 μs |  3.4191 μs | 661.694 μs |  1.08 |    0.01 | 60.5469 |     - |     - |    187 KB |
|   HyperLinq |  1000 | 639.500 μs | 11.3692 μs | 10.6347 μs | 637.604 μs |  1.04 |    0.02 | 60.5469 |     - |     - |    188 KB |
|    Tinyield |  1000 | 148.389 μs |  0.9565 μs |  0.8479 μs | 148.532 μs |  0.24 |    0.00 | 84.7168 |     - |     - |    260 KB |
