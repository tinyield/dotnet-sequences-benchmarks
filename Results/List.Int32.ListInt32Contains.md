## List.Int32.ListInt32Contains

### Source
[ListInt32Contains.cs](../LinqBenchmarks/List/Int32/ListInt32Contains.cs)

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
|               Method | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** |    **10** |    **10.419 ns** |  **0.0660 ns** |  **0.0617 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |    34.342 ns |  0.1078 ns |  0.0956 ns |  3.30 |    0.02 |      - |     - |     - |         - |
|                 Linq |    10 |    12.933 ns |  0.0711 ns |  0.0631 ns |  1.24 |    0.01 |      - |     - |     - |         - |
|           LinqFaster |    10 |    10.374 ns |  0.0314 ns |  0.0262 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|               LinqAF |    10 |     9.145 ns |  0.0626 ns |  0.0586 ns |  0.88 |    0.01 |      - |     - |     - |         - |
|           StructLinq |    10 |    22.248 ns |  0.1789 ns |  0.1673 ns |  2.14 |    0.02 | 0.0102 |     - |     - |      32 B |
| StructLinq_IFunction |    10 |    10.786 ns |  0.1108 ns |  0.1037 ns |  1.04 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |    10 |    16.409 ns |  0.0563 ns |  0.0527 ns |  1.57 |    0.01 |      - |     - |     - |         - |
|       Hyperlinq_SIMD |    10 |    23.863 ns |  0.0652 ns |  0.0544 ns |  2.29 |    0.01 |      - |     - |     - |         - |
|                      |       |              |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |   **828.061 ns** |  **2.5085 ns** |  **2.3465 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 | 2,936.911 ns | 15.4082 ns | 13.6589 ns |  3.55 |    0.02 |      - |     - |     - |         - |
|                 Linq |  1000 |   314.874 ns |  1.5675 ns |  1.3896 ns |  0.38 |    0.00 |      - |     - |     - |         - |
|           LinqFaster |  1000 |   310.578 ns |  1.8056 ns |  1.6006 ns |  0.38 |    0.00 |      - |     - |     - |         - |
|               LinqAF |  1000 |   321.578 ns |  2.6576 ns |  2.3559 ns |  0.39 |    0.00 |      - |     - |     - |         - |
|           StructLinq |  1000 |   762.806 ns |  3.6955 ns |  3.4567 ns |  0.92 |    0.01 | 0.0095 |     - |     - |      32 B |
| StructLinq_IFunction |  1000 |   752.636 ns |  1.5874 ns |  1.2393 ns |  0.91 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |   317.369 ns |  1.2561 ns |  1.0489 ns |  0.38 |    0.00 |      - |     - |     - |         - |
|       Hyperlinq_SIMD |  1000 |   153.560 ns |  0.3616 ns |  0.3020 ns |  0.19 |    0.00 |      - |     - |     - |         - |
