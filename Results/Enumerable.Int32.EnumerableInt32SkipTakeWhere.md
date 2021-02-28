## Enumerable.Int32.EnumerableInt32SkipTakeWhere

### Source
[EnumerableInt32SkipTakeWhere.cs](../LinqBenchmarks/Enumerable/Int32/EnumerableInt32SkipTakeWhere.cs)

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
|               Method | Skip | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |----- |------ |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|          **ForeachLoop** | **1000** |    **10** |  **3.352 μs** | **0.0154 μs** | **0.0137 μs** |  **1.00** |    **0.00** | **0.0114** |     **-** |     **-** |      **40 B** |
|                 Linq | 1000 |    10 |  4.019 μs | 0.0146 μs | 0.0122 μs |  1.20 |    0.01 | 0.0610 |     - |     - |     208 B |
|               LinqAF | 1000 |    10 |  5.449 μs | 0.0256 μs | 0.0239 μs |  1.63 |    0.01 | 0.0076 |     - |     - |      40 B |
|           StructLinq | 1000 |    10 |  4.274 μs | 0.0415 μs | 0.0389 μs |  1.28 |    0.02 | 0.0381 |     - |     - |     128 B |
| StructLinq_IFunction | 1000 |    10 |  3.819 μs | 0.0238 μs | 0.0223 μs |  1.14 |    0.01 | 0.0076 |     - |     - |      40 B |
|            Hyperlinq | 1000 |    10 |  3.865 μs | 0.0208 μs | 0.0185 μs |  1.15 |    0.01 | 0.0076 |     - |     - |      40 B |
|  Hyperlinq_IFunction | 1000 |    10 |  3.839 μs | 0.0163 μs | 0.0136 μs |  1.15 |    0.01 | 0.0076 |     - |     - |      40 B |
|             Tinyield | 1000 |    10 | 12.932 μs | 0.0505 μs | 0.0448 μs |  3.86 |    0.02 | 0.3052 |     - |     - |     984 B |
|                      |      |       |           |           |           |       |         |        |       |       |           |
|          **ForeachLoop** | **1000** |  **1000** |  **6.253 μs** | **0.0311 μs** | **0.0291 μs** |  **1.00** |    **0.00** | **0.0076** |     **-** |     **-** |      **40 B** |
|                 Linq | 1000 |  1000 | 21.832 μs | 0.1696 μs | 0.1586 μs |  3.49 |    0.03 | 0.0610 |     - |     - |     208 B |
|               LinqAF | 1000 |  1000 | 20.033 μs | 0.1055 μs | 0.0987 μs |  3.20 |    0.02 |      - |     - |     - |      40 B |
|           StructLinq | 1000 |  1000 | 14.913 μs | 0.0503 μs | 0.0471 μs |  2.38 |    0.02 | 0.0305 |     - |     - |     128 B |
| StructLinq_IFunction | 1000 |  1000 | 12.542 μs | 0.0779 μs | 0.0728 μs |  2.01 |    0.02 |      - |     - |     - |      40 B |
|            Hyperlinq | 1000 |  1000 | 15.518 μs | 0.0548 μs | 0.0458 μs |  2.48 |    0.01 |      - |     - |     - |      40 B |
|  Hyperlinq_IFunction | 1000 |  1000 | 13.746 μs | 0.0542 μs | 0.0507 μs |  2.20 |    0.01 |      - |     - |     - |      40 B |
|             Tinyield | 1000 |  1000 | 28.210 μs | 0.2018 μs | 0.1887 μs |  4.51 |    0.03 | 0.3052 |     - |     - |     984 B |
