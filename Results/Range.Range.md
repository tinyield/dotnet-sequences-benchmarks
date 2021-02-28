## Range.Range

### Source
[Range.cs](../LinqBenchmarks/Range/Range.cs)

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
|          Method | Start | Count |         Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |------ |------ |-------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|         **ForLoop** |     **0** |    **10** |     **3.859 ns** |  **0.0251 ns** |  **0.0223 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|     ForeachLoop |     0 |    10 |    92.167 ns |  0.2304 ns |  0.1924 ns | 23.90 |    0.15 | 0.0178 |     - |     - |      56 B |
|            Linq |     0 |    10 |    84.461 ns |  0.3913 ns |  0.3469 ns | 21.89 |    0.17 | 0.0126 |     - |     - |      40 B |
|      LinqFaster |     0 |    10 |    20.937 ns |  0.1546 ns |  0.1446 ns |  5.42 |    0.05 | 0.0204 |     - |     - |      64 B |
| LinqFaster_SIMD |     0 |    10 |    28.852 ns |  0.2622 ns |  0.2324 ns |  7.48 |    0.07 | 0.0204 |     - |     - |      64 B |
|          LinqAF |     0 |    10 |    43.161 ns |  0.2051 ns |  0.1818 ns | 11.19 |    0.06 |      - |     - |     - |         - |
|      StructLinq |     0 |    10 |     5.364 ns |  0.0297 ns |  0.0264 ns |  1.39 |    0.01 |      - |     - |     - |         - |
|       Hyperlinq |     0 |    10 |    16.826 ns |  0.0852 ns |  0.0755 ns |  4.36 |    0.02 |      - |     - |     - |         - |
|        Tinyield |     0 |    10 |   176.966 ns |  1.7241 ns |  1.5284 ns | 45.87 |    0.51 | 0.1504 |     - |     - |     472 B |
|                 |       |       |              |            |            |       |         |        |       |       |           |
|         **ForLoop** |     **0** |  **1000** |   **375.876 ns** |  **2.3723 ns** |  **2.2191 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|     ForeachLoop |     0 |  1000 | 6,237.787 ns | 28.2398 ns | 26.4155 ns | 16.60 |    0.11 | 0.0153 |     - |     - |      56 B |
|            Linq |     0 |  1000 | 5,512.528 ns | 32.3662 ns | 30.2754 ns | 14.67 |    0.11 | 0.0076 |     - |     - |      40 B |
|      LinqFaster |     0 |  1000 | 1,855.036 ns |  9.6417 ns |  8.5471 ns |  4.93 |    0.03 | 1.2817 |     - |     - |   4,024 B |
| LinqFaster_SIMD |     0 |  1000 | 1,203.724 ns | 14.5195 ns | 13.5816 ns |  3.20 |    0.03 | 1.2817 |     - |     - |   4,024 B |
|          LinqAF |     0 |  1000 | 2,838.936 ns | 19.6753 ns | 17.4416 ns |  7.55 |    0.06 |      - |     - |     - |         - |
|      StructLinq |     0 |  1000 |   377.570 ns |  3.9501 ns |  3.6950 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|       Hyperlinq |     0 |  1000 |   391.969 ns |  2.6153 ns |  2.3184 ns |  1.04 |    0.01 |      - |     - |     - |         - |
|        Tinyield |     0 |  1000 | 7,160.164 ns | 27.5287 ns | 24.4035 ns | 19.04 |    0.11 | 0.1450 |     - |     - |     472 B |
