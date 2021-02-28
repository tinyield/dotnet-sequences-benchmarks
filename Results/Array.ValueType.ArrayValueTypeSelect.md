## Array.ValueType.ArrayValueTypeSelect

### Source
[ArrayValueTypeSelect.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeSelect.cs)

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
|                      Method | Count |        Mean |     Error |    StdDev | Ratio |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |------------:|----------:|----------:|------:|--------:|------:|------:|----------:|
|                     **ForLoop** |    **10** |    **331.4 ns** |   **0.27 ns** |   **0.24 ns** |  **1.00** |       **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop |    10 |    329.4 ns |   0.79 ns |   0.74 ns |  0.99 |       - |     - |     - |         - |
|                        Linq |    10 |    362.9 ns |   1.24 ns |   1.16 ns |  1.09 |  0.0329 |     - |     - |     104 B |
|                  LinqFaster |    10 |    323.6 ns |   3.06 ns |   2.86 ns |  0.98 |  0.2112 |     - |     - |     664 B |
|                      LinqAF |    10 |    466.0 ns |   4.55 ns |   4.26 ns |  1.41 |       - |     - |     - |         - |
|                  StructLinq |    10 |    284.8 ns |   0.59 ns |   0.49 ns |  0.86 |  0.0100 |     - |     - |      32 B |
|        StructLinq_IFunction |    10 |    278.5 ns |   0.93 ns |   0.83 ns |  0.84 |       - |     - |     - |         - |
|           Hyperlinq_Foreach |    10 |    301.1 ns |   0.85 ns |   0.71 ns |  0.91 |       - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction |    10 |    265.2 ns |   0.56 ns |   0.50 ns |  0.80 |       - |     - |     - |         - |
|               Hyperlinq_For |    10 |    380.2 ns |   0.89 ns |   0.83 ns |  1.15 |       - |     - |     - |         - |
|     Hyperlinq_For_IFunction |    10 |    252.6 ns |   0.70 ns |   0.58 ns |  0.76 |       - |     - |     - |         - |
|                    Tinyield |    10 |    419.7 ns |   2.87 ns |   2.68 ns |  1.27 |  0.1988 |     - |     - |     624 B |
|                             |       |             |           |           |       |         |       |       |           |
|                     **ForLoop** |  **1000** | **32,960.7 ns** |  **55.72 ns** |  **49.39 ns** |  **1.00** |       **-** |     **-** |     **-** |         **-** |
|                 ForeachLoop |  1000 | 32,622.8 ns |  45.21 ns |  42.29 ns |  0.99 |       - |     - |     - |         - |
|                        Linq |  1000 | 30,723.8 ns |  30.15 ns |  23.54 ns |  0.93 |  0.0305 |     - |     - |     104 B |
|                  LinqFaster |  1000 | 32,040.9 ns | 242.01 ns | 214.54 ns |  0.97 | 19.9585 |     - |     - |  64,024 B |
|                      LinqAF |  1000 | 38,745.7 ns | 491.45 ns | 459.70 ns |  1.18 |       - |     - |     - |         - |
|                  StructLinq |  1000 | 25,536.3 ns |  82.20 ns |  76.89 ns |  0.77 |       - |     - |     - |      32 B |
|        StructLinq_IFunction |  1000 | 24,426.8 ns |  75.35 ns |  66.79 ns |  0.74 |       - |     - |     - |         - |
|           Hyperlinq_Foreach |  1000 | 33,764.0 ns |  75.46 ns |  66.89 ns |  1.02 |       - |     - |     - |         - |
| Hyperlinq_Foreach_IFunction |  1000 | 22,925.5 ns |  68.02 ns |  63.62 ns |  0.70 |       - |     - |     - |         - |
|               Hyperlinq_For |  1000 | 26,570.6 ns |  97.50 ns |  86.43 ns |  0.81 |       - |     - |     - |         - |
|     Hyperlinq_For_IFunction |  1000 | 22,916.0 ns |  55.03 ns |  45.95 ns |  0.70 |       - |     - |     - |         - |
|                    Tinyield |  1000 | 28,944.4 ns |  67.07 ns |  62.73 ns |  0.88 |  0.1831 |     - |     - |     624 B |
