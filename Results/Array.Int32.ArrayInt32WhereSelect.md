## Array.Int32.ArrayInt32WhereSelect

### Source
[ArrayInt32WhereSelect.cs](../LinqBenchmarks/Array/Int32/ArrayInt32WhereSelect.cs)

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
|               Method | Count |          Mean |      Error |     StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------- |------ |--------------:|-----------:|-----------:|------:|--------:|-------:|------:|------:|----------:|
|              **ForLoop** |    **10** |      **9.515 ns** |  **0.1215 ns** |  **0.1136 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |      9.510 ns |  0.0777 ns |  0.0727 ns |  1.00 |    0.02 |      - |     - |     - |         - |
|                 Linq |    10 |    123.251 ns |  1.6502 ns |  1.5436 ns | 12.96 |    0.21 | 0.0331 |     - |     - |     104 B |
|           LinqFaster |    10 |     68.386 ns |  0.3454 ns |  0.3062 ns |  7.19 |    0.10 | 0.0305 |     - |     - |      96 B |
|               LinqAF |    10 |     79.587 ns |  0.1871 ns |  0.1658 ns |  8.36 |    0.10 |      - |     - |     - |         - |
|           StructLinq |    10 |     82.330 ns |  0.4234 ns |  0.3753 ns |  8.65 |    0.11 | 0.0204 |     - |     - |      64 B |
| StructLinq_IFunction |    10 |     70.933 ns |  0.1260 ns |  0.1052 ns |  7.45 |    0.09 |      - |     - |     - |         - |
|            Hyperlinq |    10 |     75.266 ns |  0.3713 ns |  0.3473 ns |  7.91 |    0.11 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |     66.068 ns |  0.1767 ns |  0.1653 ns |  6.94 |    0.09 |      - |     - |     - |         - |
|             Tinyield |    10 |    244.242 ns |  2.1542 ns |  1.9096 ns | 25.67 |    0.36 | 0.2728 |     - |     - |     856 B |
|                      |       |               |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |  **1,075.117 ns** |  **8.8819 ns** |  **8.3081 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 |  1,483.196 ns | 22.9164 ns | 20.3148 ns |  1.38 |    0.02 |      - |     - |     - |         - |
|                 Linq |  1000 | 10,474.555 ns | 39.0755 ns | 36.5512 ns |  9.74 |    0.09 | 0.0305 |     - |     - |     104 B |
|           LinqFaster |  1000 |  7,432.115 ns | 27.0447 ns | 22.5836 ns |  6.91 |    0.06 | 1.9302 |     - |     - |   6,064 B |
|               LinqAF |  1000 |  8,236.310 ns | 47.3739 ns | 44.3135 ns |  7.66 |    0.08 |      - |     - |     - |         - |
|           StructLinq |  1000 |  6,828.722 ns | 61.7379 ns | 57.7496 ns |  6.35 |    0.06 | 0.0153 |     - |     - |      64 B |
| StructLinq_IFunction |  1000 |  2,109.632 ns | 19.1270 ns | 17.8914 ns |  1.96 |    0.03 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |  8,281.409 ns | 82.1870 ns | 76.8778 ns |  7.70 |    0.09 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 |  2,613.082 ns | 19.0031 ns | 17.7755 ns |  2.43 |    0.02 |      - |     - |     - |         - |
|             Tinyield |  1000 | 11,458.068 ns | 68.8434 ns | 64.3962 ns | 10.66 |    0.11 | 0.2594 |     - |     - |     856 B |
