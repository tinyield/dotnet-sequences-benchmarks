## Array.Int32.ArrayInt32SelectToList

### Source
[ArrayInt32SelectToList.cs](../LinqBenchmarks/Array/Int32/ArrayInt32SelectToList.cs)

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
|                   Method | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------- |------ |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                  **ForLoop** |    **10** |    **90.79 ns** |  **0.480 ns** |  **0.426 ns** |  **1.00** |    **0.00** | **0.0688** |     **-** |     **-** |     **216 B** |
|              ForeachLoop |    10 |    88.72 ns |  1.048 ns |  0.875 ns |  0.98 |    0.01 | 0.0688 |     - |     - |     216 B |
|                     Linq |    10 |    95.19 ns |  0.771 ns |  0.683 ns |  1.05 |    0.01 | 0.0458 |     - |     - |     144 B |
|               LinqFaster |    10 |    75.47 ns |  0.542 ns |  0.453 ns |  0.83 |    0.01 | 0.0509 |     - |     - |     160 B |
|          LinqFaster_SIMD |    10 |    62.65 ns |  0.479 ns |  0.374 ns |  0.69 |    0.00 | 0.0509 |     - |     - |     160 B |
|                   LinqAF |    10 |   216.30 ns |  1.356 ns |  1.269 ns |  2.38 |    0.02 | 0.0687 |     - |     - |     216 B |
|               StructLinq |    10 |    89.89 ns |  0.596 ns |  0.528 ns |  0.99 |    0.01 | 0.0509 |     - |     - |     160 B |
|     StructLinq_IFunction |    10 |    63.56 ns |  0.445 ns |  0.395 ns |  0.70 |    0.01 | 0.0433 |     - |     - |     136 B |
|                Hyperlinq |    10 |    66.20 ns |  0.618 ns |  0.548 ns |  0.73 |    0.01 | 0.0305 |     - |     - |      96 B |
|      Hyperlinq_IFunction |    10 |    50.83 ns |  0.332 ns |  0.310 ns |  0.56 |    0.00 | 0.0305 |     - |     - |      96 B |
|           Hyperlinq_SIMD |    10 |    93.06 ns |  0.521 ns |  0.487 ns |  1.02 |    0.01 | 0.0305 |     - |     - |      96 B |
| Hyperlinq_IFunction_SIMD |    10 |    66.26 ns |  0.214 ns |  0.189 ns |  0.73 |    0.00 | 0.0305 |     - |     - |      96 B |
|                          |       |             |           |           |       |         |        |       |       |           |
|                  **ForLoop** |  **1000** | **2,966.23 ns** | **22.879 ns** | **21.401 ns** |  **1.00** |    **0.00** | **2.6817** |     **-** |     **-** |   **8,424 B** |
|              ForeachLoop |  1000 | 2,973.97 ns | 14.360 ns | 12.730 ns |  1.00 |    0.00 | 2.6817 |     - |     - |   8,424 B |
|                     Linq |  1000 | 3,441.69 ns | 16.231 ns | 15.182 ns |  1.16 |    0.01 | 1.3046 |     - |     - |   4,104 B |
|               LinqFaster |  1000 | 3,420.02 ns | 20.501 ns | 18.174 ns |  1.15 |    0.01 | 2.5711 |     - |     - |   8,080 B |
|          LinqFaster_SIMD |  1000 | 1,249.97 ns | 11.666 ns | 10.341 ns |  0.42 |    0.00 | 2.5730 |     - |     - |   8,080 B |
|                   LinqAF |  1000 | 8,928.29 ns | 71.727 ns | 67.094 ns |  3.01 |    0.03 | 2.6703 |     - |     - |   8,424 B |
|               StructLinq |  1000 | 2,995.94 ns | 15.508 ns | 14.506 ns |  1.01 |    0.01 | 1.3123 |     - |     - |   4,120 B |
|     StructLinq_IFunction |  1000 | 1,435.65 ns | 11.981 ns | 10.621 ns |  0.48 |    0.00 | 1.3046 |     - |     - |   4,096 B |
|                Hyperlinq |  1000 | 2,987.44 ns | 13.203 ns | 12.350 ns |  1.01 |    0.01 | 1.2894 |     - |     - |   4,056 B |
|      Hyperlinq_IFunction |  1000 | 1,202.04 ns |  9.357 ns |  8.753 ns |  0.41 |    0.00 | 1.2894 |     - |     - |   4,056 B |
|           Hyperlinq_SIMD |  1000 |   881.22 ns |  5.167 ns |  4.833 ns |  0.30 |    0.00 | 1.2903 |     - |     - |   4,056 B |
| Hyperlinq_IFunction_SIMD |  1000 |   567.91 ns |  5.643 ns |  5.002 ns |  0.19 |    0.00 | 1.2903 |     - |     - |   4,056 B |
