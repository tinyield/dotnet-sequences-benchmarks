## Enumerable.Int32.EnumerableInt32Select

### Source
[EnumerableInt32Select.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32Select.cs)

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
|                      Method | Count |         Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |------ |-------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                 **ForeachLoop** |    **10** |     **76.14 ns** |  **0.262 ns** |  **0.245 ns** |  **1.00** |    **0.00** | **0.0126** |     **-** |     **-** |      **40 B** |
|                        Linq |    10 |    222.59 ns |  1.701 ns |  1.591 ns |  2.92 |    0.02 | 0.0305 |     - |     - |      96 B |
|                      LinqAF |    10 |    182.25 ns |  0.847 ns |  0.792 ns |  2.39 |    0.01 | 0.0126 |     - |     - |      40 B |
|                  StructLinq |    10 |    126.06 ns |  0.558 ns |  0.495 ns |  1.66 |    0.01 | 0.0203 |     - |     - |      64 B |
|        StructLinq_IFunction |    10 |     86.62 ns |  0.424 ns |  0.397 ns |  1.14 |    0.00 | 0.0126 |     - |     - |      40 B |
|           Hyperlinq_Foreach |    10 |    114.49 ns |  0.550 ns |  0.514 ns |  1.50 |    0.01 | 0.0126 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction |    10 |     92.51 ns |  0.311 ns |  0.275 ns |  1.21 |    0.01 | 0.0126 |     - |     - |      40 B |
|                    Tinyield |    10 |    269.53 ns |  2.103 ns |  1.864 ns |  3.54 |    0.02 | 0.1912 |     - |     - |     600 B |
|                             |       |              |           |           |       |         |        |       |       |           |
|                 **ForeachLoop** |  **1000** |  **6,580.00 ns** | **13.867 ns** | **11.580 ns** |  **1.00** |    **0.00** | **0.0076** |     **-** |     **-** |      **40 B** |
|                        Linq |  1000 | 12,926.57 ns | 69.779 ns | 65.272 ns |  1.96 |    0.01 | 0.0305 |     - |     - |      96 B |
|                      LinqAF |  1000 | 11,503.06 ns | 34.993 ns | 31.021 ns |  1.75 |    0.01 |      - |     - |     - |      40 B |
|                  StructLinq |  1000 |  8,392.32 ns | 50.513 ns | 44.778 ns |  1.28 |    0.01 | 0.0153 |     - |     - |      64 B |
|        StructLinq_IFunction |  1000 |  5,876.67 ns | 18.653 ns | 16.535 ns |  0.89 |    0.00 | 0.0076 |     - |     - |      40 B |
|           Hyperlinq_Foreach |  1000 |  8,656.44 ns | 33.946 ns | 30.093 ns |  1.32 |    0.00 |      - |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction |  1000 |  6,234.54 ns | 28.444 ns | 25.215 ns |  0.95 |    0.00 | 0.0076 |     - |     - |      40 B |
|                    Tinyield |  1000 | 11,131.58 ns | 38.258 ns | 35.787 ns |  1.69 |    0.01 | 0.1831 |     - |     - |     600 B |
