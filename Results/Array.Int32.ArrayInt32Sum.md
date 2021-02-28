## Array.Int32.ArrayInt32Sum

### Source
[ArrayInt32Sum.cs](../LinqBenchmarks/Array/Int32/ArrayInt32Sum.cs)

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
|              **ForLoop** |    **10** |     **7.526 ns** |  **0.0249 ns** |  **0.0208 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |    10 |     7.508 ns |  0.0482 ns |  0.0427 ns |  1.00 |    0.01 |      - |     - |     - |         - |
|                 Linq |    10 |    69.803 ns |  0.3674 ns |  0.3257 ns |  9.27 |    0.05 | 0.0101 |     - |     - |      32 B |
|           LinqFaster |    10 |     8.422 ns |  0.0490 ns |  0.0409 ns |  1.12 |    0.01 |      - |     - |     - |         - |
|      LinqFaster_SIMD |    10 |     9.568 ns |  0.0652 ns |  0.0578 ns |  1.27 |    0.01 |      - |     - |     - |         - |
|               LinqAF |    10 |    36.912 ns |  0.1771 ns |  0.1657 ns |  4.90 |    0.03 |      - |     - |     - |         - |
|           StructLinq |    10 |    24.487 ns |  0.1885 ns |  0.1763 ns |  3.25 |    0.03 | 0.0102 |     - |     - |      32 B |
| StructLinq_IFunction |    10 |     6.663 ns |  0.0586 ns |  0.0548 ns |  0.89 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |    10 |    21.745 ns |  0.0538 ns |  0.0504 ns |  2.89 |    0.01 |      - |     - |     - |         - |
|                      |       |              |            |            |       |         |        |       |       |           |
|              **ForLoop** |  **1000** |   **540.752 ns** |  **2.1000 ns** |  **1.9644 ns** |  **1.00** |    **0.00** |      **-** |     **-** |     **-** |         **-** |
|          ForeachLoop |  1000 |   736.160 ns |  2.2807 ns |  2.1334 ns |  1.36 |    0.01 |      - |     - |     - |         - |
|                 Linq |  1000 | 5,128.328 ns | 24.8115 ns | 23.2087 ns |  9.48 |    0.06 | 0.0076 |     - |     - |      32 B |
|           LinqFaster |  1000 |   736.666 ns |  2.8642 ns |  2.3917 ns |  1.36 |    0.01 |      - |     - |     - |         - |
|      LinqFaster_SIMD |  1000 |    72.795 ns |  0.4216 ns |  0.3944 ns |  0.13 |    0.00 |      - |     - |     - |         - |
|               LinqAF |  1000 | 2,754.249 ns |  6.0435 ns |  5.6531 ns |  5.09 |    0.02 |      - |     - |     - |         - |
|           StructLinq |  1000 |   953.254 ns |  3.9886 ns |  3.7310 ns |  1.76 |    0.01 | 0.0095 |     - |     - |      32 B |
| StructLinq_IFunction |  1000 |   771.621 ns |  2.5057 ns |  2.2212 ns |  1.43 |    0.01 |      - |     - |     - |         - |
|            Hyperlinq |  1000 |   118.105 ns |  0.4823 ns |  0.4028 ns |  0.22 |    0.00 |      - |     - |     - |         - |
