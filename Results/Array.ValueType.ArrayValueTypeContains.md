## Array.ValueType.ArrayValueTypeContains

### Source
[ArrayValueTypeContains.cs](../LinqBenchmarks/Array/ValueType/ArrayValueTypeContains.cs)

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
|               Method | Count |        Mean |     Error |    StdDev | Ratio |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |------------:|----------:|----------:|------:|-------:|------:|------:|----------:|
|              **ForLoop** |    **10** |    **86.78 ns** |  **0.194 ns** |  **0.172 ns** |  **1.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |    65.77 ns |  0.114 ns |  0.089 ns |  0.76 |      - |     - |     - |         - |
|                 Linq |    10 |    34.88 ns |  0.341 ns |  0.302 ns |  0.40 |      - |     - |     - |         - |
|           LinqFaster |    10 |    36.24 ns |  0.189 ns |  0.167 ns |  0.42 |      - |     - |     - |         - |
|               LinqAF |    10 |    44.46 ns |  0.205 ns |  0.171 ns |  0.51 |      - |     - |     - |         - |
|           StructLinq |    10 |    64.16 ns |  0.357 ns |  0.298 ns |  0.74 | 0.0101 |     - |     - |      32 B |
| StructLinq_IFunction |    10 |    55.32 ns |  0.298 ns |  0.279 ns |  0.64 |      - |     - |     - |         - |
|            Hyperlinq |    10 |    41.34 ns |  0.199 ns |  0.186 ns |  0.48 |      - |     - |     - |         - |
|                      |       |             |           |           |       |        |       |       |           |
|              **ForLoop** |  **1000** | **7,078.47 ns** | **34.950 ns** | **32.693 ns** |  **1.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 | 6,606.43 ns | 25.069 ns | 22.223 ns |  0.93 |      - |     - |     - |         - |
|                 Linq |  1000 | 2,960.98 ns | 18.162 ns | 16.989 ns |  0.42 |      - |     - |     - |         - |
|           LinqFaster |  1000 | 2,589.28 ns |  9.111 ns |  7.608 ns |  0.37 |      - |     - |     - |         - |
|               LinqAF |  1000 | 3,300.23 ns | 11.359 ns | 10.625 ns |  0.47 |      - |     - |     - |         - |
|           StructLinq |  1000 | 5,285.01 ns | 35.551 ns | 31.515 ns |  0.75 | 0.0076 |     - |     - |      32 B |
| StructLinq_IFunction |  1000 | 4,852.73 ns | 38.350 ns | 35.873 ns |  0.69 |      - |     - |     - |         - |
|            Hyperlinq |  1000 | 2,598.48 ns | 13.391 ns | 11.870 ns |  0.37 |      - |     - |     - |         - |
