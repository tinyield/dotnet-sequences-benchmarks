## Array.Int32.ArrayInt32Where

### Source
[ArrayInt32Where.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Where.cs)

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
|              **ForLoop** |    **10** |     **9.520 ns** |  **0.1031 ns** |  **0.0914 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |    10.783 ns |  0.0945 ns |  0.0884 ns |  1.13 |    0.02 |      - |     - |     - |         - |
|                 Linq |    10 |    75.486 ns |  0.2364 ns |  0.1974 ns |  7.93 |    0.08 | 0.0153 |     - |     - |      48 B |
|           LinqFaster |    10 |    53.622 ns |  0.3563 ns |  0.3333 ns |  5.63 |    0.06 | 0.0306 |     - |     - |      96 B |
|               LinqAF |    10 |    67.936 ns |  0.5198 ns |  0.4862 ns |  7.14 |    0.10 |      - |     - |     - |         - |
|           StructLinq |    10 |    58.285 ns |  0.3647 ns |  0.3412 ns |  6.12 |    0.06 | 0.0101 |     - |     - |      32 B |
| StructLinq_IFunction |    10 |    50.835 ns |  0.1107 ns |  0.1035 ns |  5.34 |    0.06 |      - |     - |     - |         - |
|            Hyperlinq |    10 |    58.102 ns |  0.1972 ns |  0.1647 ns |  6.10 |    0.06 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |    53.030 ns |  0.1235 ns |  0.1095 ns |  5.57 |    0.05 |      - |     - |     - |         - |
|             Tinyield |    10 |   172.690 ns |  1.3904 ns |  1.3005 ns | 18.15 |    0.26 | 0.1810 |     - |     - |     568 B |
|                      |       |              |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** | **1,054.329 ns** |  **7.0304 ns** |  **5.8707 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 | 1,053.320 ns |  9.3853 ns |  8.7790 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|                 Linq |  1000 | 7,547.422 ns | 36.2558 ns | 33.9137 ns |  7.16 |    0.06 | 0.0153 |     - |     - |      48 B |
|           LinqFaster |  1000 | 5,014.128 ns | 32.7335 ns | 30.6189 ns |  4.75 |    0.03 | 1.9302 |     - |     - |   6,064 B |
|               LinqAF |  1000 | 8,662.754 ns | 48.8494 ns | 40.7914 ns |  8.22 |    0.06 |      - |     - |     - |         - |
|           StructLinq |  1000 | 8,202.739 ns | 68.6235 ns | 60.8330 ns |  7.78 |    0.08 |      - |     - |     - |      32 B |
| StructLinq_IFunction |  1000 | 2,098.324 ns | 13.4033 ns | 12.5375 ns |  1.99 |    0.02 |      - |     - |     - |         - |
|            Hyperlinq |  1000 | 6,838.863 ns | 29.6908 ns | 27.7728 ns |  6.49 |    0.06 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 | 2,723.211 ns | 11.4885 ns | 10.1843 ns |  2.58 |    0.02 |      - |     - |     - |         - |
|             Tinyield |  1000 | 9,081.994 ns | 35.4034 ns | 31.3842 ns |  8.62 |    0.05 | 0.1678 |     - |     - |     568 B |
