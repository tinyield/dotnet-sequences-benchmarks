## Range.RangeSelect

### Source
[RangeSelect.cs](../LinqBenchmarks/Range/RangeSelect.cs)

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
|               Method | Start | Count |          Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |------ |--------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** |     **0** |    **10** |      **3.859 ns** |  **0.0351 ns** |  **0.0311 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |     0 |    10 |     95.918 ns |  0.7039 ns |  0.6584 ns | 24.88 |    0.21 | 0.0178 |     - |     - |      56 B |
|                 Linq |     0 |    10 |    165.448 ns |  0.7414 ns |  0.6935 ns | 42.88 |    0.38 | 0.0279 |     - |     - |      88 B |
|           LinqFaster |     0 |    10 |     56.649 ns |  0.3849 ns |  0.3600 ns | 14.69 |    0.17 | 0.0408 |     - |     - |     128 B |
|      LinqFaster_SIMD |     0 |    10 |     49.966 ns |  0.3288 ns |  0.3075 ns | 12.95 |    0.13 | 0.0408 |     - |     - |     128 B |
|               LinqAF |     0 |    10 |    104.837 ns |  0.3465 ns |  0.2894 ns | 27.16 |    0.24 |      - |     - |     - |         - |
|           StructLinq |     0 |    10 |     50.132 ns |  0.1587 ns |  0.1407 ns | 12.99 |    0.11 | 0.0076 |     - |     - |      24 B |
| StructLinq_IFunction |     0 |    10 |     38.578 ns |  0.0869 ns |  0.0678 ns | 10.00 |    0.09 |      - |     - |     - |         - |
|            Hyperlinq |     0 |    10 |     53.510 ns |  0.1715 ns |  0.1605 ns | 13.87 |    0.12 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |     0 |    10 |     47.785 ns |  0.1140 ns |  0.1011 ns | 12.38 |    0.10 |      - |     - |     - |         - |
|             Tinyield |     0 |    10 |    269.783 ns |  2.9926 ns |  2.7993 ns | 69.97 |    0.82 | 0.2422 |     - |     - |     760 B |
|                      |       |       |               |            |            |       |         |        |       |       |           |
|              **ForLoop** |     **0** |  **1000** |    **444.141 ns** |  **2.3925 ns** |  **2.1209 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |     0 |  1000 |  6,603.048 ns | 27.7596 ns | 25.9664 ns | 14.86 |    0.09 | 0.0153 |     - |     - |      56 B |
|                 Linq |     0 |  1000 |  8,084.958 ns | 43.0230 ns | 38.1388 ns | 18.20 |    0.12 | 0.0153 |     - |     - |      88 B |
|           LinqFaster |     0 |  1000 |  4,431.276 ns | 50.0106 ns | 46.7800 ns |  9.98 |    0.11 | 2.5635 |     - |     - |   8,048 B |
|      LinqFaster_SIMD |     0 |  1000 |  1,999.003 ns | 26.7126 ns | 24.9870 ns |  4.51 |    0.06 | 2.5635 |     - |     - |   8,048 B |
|               LinqAF |     0 |  1000 |  6,679.260 ns | 35.7805 ns | 33.4691 ns | 15.04 |    0.10 |      - |     - |     - |         - |
|           StructLinq |     0 |  1000 |  3,041.916 ns |  8.9153 ns |  7.4447 ns |  6.85 |    0.04 | 0.0076 |     - |     - |      24 B |
| StructLinq_IFunction |     0 |  1000 |  2,027.426 ns |  2.9675 ns |  2.6306 ns |  4.56 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq |     0 |  1000 |  2,591.079 ns | 16.3839 ns | 15.3255 ns |  5.83 |    0.04 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |     0 |  1000 |  2,040.236 ns |  4.7854 ns |  4.2421 ns |  4.59 |    0.03 |      - |     - |     - |         - |
|             Tinyield |     0 |  1000 | 10,690.130 ns | 86.2917 ns | 72.0574 ns | 24.08 |    0.17 | 0.2289 |     - |     - |     760 B |
