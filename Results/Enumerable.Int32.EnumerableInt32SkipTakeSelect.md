## Enumerable.Int32.EnumerableInt32SkipTakeSelect

### Source
[EnumerableInt32SkipTakeSelect.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32SkipTakeSelect.cs)

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
|                      Method | Skip | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |----- |------ |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                 **ForeachLoop** | **1000** |    **10** |  **3.348 μs** | **0.0130 μs** | **0.0122 μs** |  **1.00** |    **0.00** | **0.0114** |     **-** |     **-** |      **40 B** |
|                        Linq | 1000 |    10 |  3.686 μs | 0.0127 μs | 0.0112 μs |  1.10 |    0.01 | 0.0648 |     - |     - |     208 B |
|                      LinqAF | 1000 |    10 |  4.709 μs | 0.0208 μs | 0.0174 μs |  1.41 |    0.01 | 0.0076 |     - |     - |      40 B |
|                  StructLinq | 1000 |    10 |  3.509 μs | 0.0135 μs | 0.0120 μs |  1.05 |    0.01 | 0.0381 |     - |     - |     128 B |
|        StructLinq_IFunction | 1000 |    10 |  3.790 μs | 0.0177 μs | 0.0157 μs |  1.13 |    0.01 | 0.0076 |     - |     - |      40 B |
|           Hyperlinq_Foreach | 1000 |    10 |  4.558 μs | 0.0174 μs | 0.0154 μs |  1.36 |    0.01 | 0.0076 |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction | 1000 |    10 |  4.517 μs | 0.0111 μs | 0.0099 μs |  1.35 |    0.01 | 0.0076 |     - |     - |      40 B |
|                    Tinyield | 1000 |    10 | 13.102 μs | 0.0739 μs | 0.0655 μs |  3.92 |    0.02 | 0.3052 |     - |     - |     984 B |
|                             |      |       |           |           |           |       |         |        |       |       |           |
|                 **ForeachLoop** | **1000** |  **1000** |  **6.948 μs** | **0.0173 μs** | **0.0154 μs** |  **1.00** |    **0.00** | **0.0076** |     **-** |     **-** |      **40 B** |
|                        Linq | 1000 |  1000 | 24.733 μs | 0.2254 μs | 0.2108 μs |  3.56 |    0.03 | 0.0610 |     - |     - |     208 B |
|                      LinqAF | 1000 |  1000 | 19.759 μs | 0.0815 μs | 0.0680 μs |  2.84 |    0.01 |      - |     - |     - |      40 B |
|                  StructLinq | 1000 |  1000 | 11.846 μs | 0.0440 μs | 0.0412 μs |  1.70 |    0.01 | 0.0305 |     - |     - |     128 B |
|        StructLinq_IFunction | 1000 |  1000 |  9.961 μs | 0.0332 μs | 0.0310 μs |  1.43 |    0.01 |      - |     - |     - |      40 B |
|           Hyperlinq_Foreach | 1000 |  1000 | 13.435 μs | 0.0974 μs | 0.0911 μs |  1.93 |    0.01 |      - |     - |     - |      40 B |
| Hyperlinq_Foreach_IFunction | 1000 |  1000 | 12.461 μs | 0.0458 μs | 0.0406 μs |  1.79 |    0.01 |      - |     - |     - |      40 B |
|                    Tinyield | 1000 |  1000 | 27.723 μs | 0.1338 μs | 0.1252 μs |  3.99 |    0.02 | 0.3052 |     - |     - |     984 B |
