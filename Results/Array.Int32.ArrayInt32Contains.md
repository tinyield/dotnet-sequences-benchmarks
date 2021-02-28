## Array.Int32.ArrayInt32Contains

### Source
[ArrayInt32Contains.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Contains.cs)

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
|               Method | Count |       Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |-----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** |    **10** |   **4.267 ns** | **0.0489 ns** | **0.0433 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |   7.470 ns | 0.0375 ns | 0.0332 ns |  1.75 |    0.02 |      - |     - |     - |         - |
|                 Linq |    10 |  20.609 ns | 0.0520 ns | 0.0461 ns |  4.83 |    0.05 |      - |     - |     - |         - |
|           LinqFaster |    10 |  10.927 ns | 0.0273 ns | 0.0242 ns |  2.56 |    0.02 |      - |     - |     - |         - |
|      LinqFaster_SIMD |    10 |   6.157 ns | 0.0238 ns | 0.0223 ns |  1.44 |    0.02 |      - |     - |     - |         - |
|               LinqAF |    10 |  13.818 ns | 0.0640 ns | 0.0599 ns |  3.24 |    0.03 |      - |     - |     - |         - |
|           StructLinq |    10 |  24.744 ns | 0.1009 ns | 0.0895 ns |  5.80 |    0.06 | 0.0102 |     - |     - |      32 B |
| StructLinq_IFunction |    10 |  10.672 ns | 0.0423 ns | 0.0375 ns |  2.50 |    0.03 |      - |     - |     - |         - |
|            Hyperlinq |    10 |  18.837 ns | 0.0619 ns | 0.0549 ns |  4.42 |    0.05 |      - |     - |     - |         - |
|       Hyperlinq_SIMD |    10 |  24.270 ns | 0.0945 ns | 0.0837 ns |  5.69 |    0.07 |      - |     - |     - |         - |
|                      |       |            |           |           |       |         |        |       |       |           |
|              **ForLoop** |  **1000** | **738.855 ns** | **4.3575 ns** | **4.0760 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 | 737.331 ns | 3.5790 ns | 3.3478 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|                 Linq |  1000 | 331.389 ns | 1.2826 ns | 1.1370 ns |  0.45 |    0.00 |      - |     - |     - |         - |
|           LinqFaster |  1000 | 321.645 ns | 1.4287 ns | 1.1930 ns |  0.44 |    0.00 |      - |     - |     - |         - |
|      LinqFaster_SIMD |  1000 | 114.198 ns | 0.2480 ns | 0.2071 ns |  0.15 |    0.00 |      - |     - |     - |         - |
|               LinqAF |  1000 | 313.593 ns | 1.2685 ns | 1.0592 ns |  0.42 |    0.00 |      - |     - |     - |         - |
|           StructLinq |  1000 | 768.722 ns | 3.7429 ns | 3.3180 ns |  1.04 |    0.01 | 0.0095 |     - |     - |      32 B |
| StructLinq_IFunction |  1000 | 759.242 ns | 3.1865 ns | 2.8247 ns |  1.03 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |  1000 | 317.670 ns | 0.8092 ns | 0.7174 ns |  0.43 |    0.00 |      - |     - |     - |         - |
|       Hyperlinq_SIMD |  1000 | 150.140 ns | 0.6765 ns | 0.5997 ns |  0.20 |    0.00 |      - |     - |     - |         - |
