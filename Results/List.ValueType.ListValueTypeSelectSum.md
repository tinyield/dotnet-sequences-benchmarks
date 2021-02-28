## List.ValueType.ListValueTypeSelectSum

### Source
[ListValueTypeSelectSum.cs](../LinqBenchmarks/List/ValueType/ListValueTypeSelectSum.cs)

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
|              **ForLoop** |    **10** |     **28.77 ns** |   **0.085 ns** |   **0.071 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     67.09 ns |   1.043 ns |   0.976 ns |  2.33 |    0.04 |      - |     - |     - |         - |
|                 Linq |    10 |    173.96 ns |   1.591 ns |   1.488 ns |  6.05 |    0.06 | 0.0305 |     - |     - |      96 B |
|           LinqFaster |    10 |     58.67 ns |   0.164 ns |   0.145 ns |  2.04 |    0.01 |      - |     - |     - |         - |
|               LinqAF |    10 |    207.54 ns |   4.205 ns |   6.164 ns |  7.24 |    0.24 |      - |     - |     - |         - |
|           StructLinq |    10 |     45.14 ns |   0.223 ns |   0.186 ns |  1.57 |    0.01 | 0.0127 |     - |     - |      40 B |
| StructLinq_IFunction |    10 |     25.22 ns |   0.066 ns |   0.059 ns |  0.88 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |    10 |     95.37 ns |   0.266 ns |   0.249 ns |  3.31 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |    10 |     69.58 ns |   0.204 ns |   0.191 ns |  2.42 |    0.01 |      - |     - |     - |         - |
|                      |       |              |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |  **3,254.89 ns** |   **5.746 ns** |   **5.375 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 |  6,410.63 ns | 110.175 ns | 103.058 ns |  1.97 |    0.03 |      - |     - |     - |         - |
|                 Linq |  1000 | 11,872.11 ns |  67.988 ns |  60.269 ns |  3.65 |    0.02 | 0.0305 |     - |     - |      96 B |
|           LinqFaster |  1000 |  6,053.23 ns |  16.717 ns |  13.959 ns |  1.86 |    0.01 |      - |     - |     - |         - |
|               LinqAF |  1000 | 13,322.79 ns | 263.411 ns | 555.624 ns |  4.06 |    0.19 |      - |     - |     - |         - |
|           StructLinq |  1000 |  2,967.59 ns |  13.963 ns |  13.061 ns |  0.91 |    0.00 | 0.0114 |     - |     - |      40 B |
| StructLinq_IFunction |  1000 |  1,042.90 ns |   9.310 ns |   8.708 ns |  0.32 |    0.00 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |  6,654.80 ns |  32.267 ns |  30.182 ns |  2.04 |    0.01 |      - |     - |     - |         - |
|  Hyperlinq_IFunction |  1000 |  5,087.38 ns |  12.289 ns |  10.894 ns |  1.56 |    0.00 |      - |     - |     - |         - |
