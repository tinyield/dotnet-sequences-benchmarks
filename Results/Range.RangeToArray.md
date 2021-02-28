## Range.RangeToArray

### Source
[RangeToArray.cs](../LinqBenchmarks/Range/RangeToArray.cs)

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
|                    Method | Start | Count |        Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |------ |------ |------------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|        **ValueLinq_Standard** |     **0** |    **10** |   **102.22 ns** |  **0.384 ns** |  **0.321 ns** |  **7.15** |    **0.06** | **0.0204** |     **-** |     **-** |      **64 B** |
|           ValueLinq_Stack |     0 |    10 |    59.31 ns |  0.436 ns |  0.408 ns |  4.15 |    0.04 | 0.0204 |     - |     - |      64 B |
| ValueLinq_SharedPool_Push |     0 |    10 |   223.61 ns |  1.152 ns |  1.078 ns | 15.64 |    0.09 | 0.0203 |     - |     - |      64 B |
| ValueLinq_SharedPool_Pull |     0 |    10 |   229.96 ns |  0.803 ns |  0.670 ns | 16.09 |    0.13 | 0.0203 |     - |     - |      64 B |
|                   ForLoop |     0 |    10 |    14.30 ns |  0.123 ns |  0.109 ns |  1.00 |    0.00 | 0.0204 |     - |     - |      64 B |
|                      Linq |     0 |    10 |    36.16 ns |  0.425 ns |  0.397 ns |  2.53 |    0.03 | 0.0331 |     - |     - |     104 B |
|                LinqFaster |     0 |    10 |    13.36 ns |  0.110 ns |  0.097 ns |  0.93 |    0.01 | 0.0204 |     - |     - |      64 B |
|           LinqFaster_SIMD |     0 |    10 |    21.04 ns |  0.212 ns |  0.188 ns |  1.47 |    0.01 | 0.0204 |     - |     - |      64 B |
|                    LinqAF |     0 |    10 |    69.30 ns |  0.340 ns |  0.284 ns |  4.85 |    0.05 | 0.0203 |     - |     - |      64 B |
|                StructLinq |     0 |    10 |    17.30 ns |  0.211 ns |  0.198 ns |  1.21 |    0.02 | 0.0204 |     - |     - |      64 B |
|                 Hyperlinq |     0 |    10 |    23.06 ns |  0.105 ns |  0.093 ns |  1.61 |    0.01 | 0.0204 |     - |     - |      64 B |
|                  Tinyield |     0 |    10 |   286.44 ns |  2.104 ns |  1.865 ns | 20.03 |    0.16 | 0.2317 |     - |     - |     728 B |
|                           |       |       |             |           |           |       |         |        |       |       |           |
|        **ValueLinq_Standard** |     **0** |  **1000** | **2,524.54 ns** | **15.167 ns** | **13.445 ns** |  **2.30** |    **0.03** | **1.2817** |     **-** |     **-** |   **4,024 B** |
|           ValueLinq_Stack |     0 |  1000 | 3,292.94 ns | 21.265 ns | 19.891 ns |  3.00 |    0.02 | 2.6093 |     - |     - |   8,200 B |
| ValueLinq_SharedPool_Push |     0 |  1000 | 3,360.80 ns | 21.510 ns | 20.120 ns |  3.07 |    0.03 | 1.2817 |     - |     - |   4,024 B |
| ValueLinq_SharedPool_Pull |     0 |  1000 | 3,112.45 ns | 16.767 ns | 14.863 ns |  2.84 |    0.03 | 1.2817 |     - |     - |   4,024 B |
|                   ForLoop |     0 |  1000 | 1,096.88 ns | 11.856 ns |  9.900 ns |  1.00 |    0.00 | 1.2817 |     - |     - |   4,024 B |
|                      Linq |     0 |  1000 |   926.02 ns |  7.106 ns |  6.647 ns |  0.84 |    0.01 | 1.2951 |     - |     - |   4,064 B |
|                LinqFaster |     0 |  1000 |   926.82 ns |  6.392 ns |  5.979 ns |  0.84 |    0.01 | 1.2817 |     - |     - |   4,024 B |
|           LinqFaster_SIMD |     0 |  1000 |   460.23 ns |  5.313 ns |  4.970 ns |  0.42 |    0.01 | 1.2817 |     - |     - |   4,024 B |
|                    LinqAF |     0 |  1000 | 3,121.80 ns | 17.662 ns | 16.521 ns |  2.84 |    0.03 | 1.2817 |     - |     - |   4,024 B |
|                StructLinq |     0 |  1000 | 1,087.52 ns | 12.425 ns | 11.622 ns |  0.99 |    0.01 | 1.2817 |     - |     - |   4,024 B |
|                 Hyperlinq |     0 |  1000 |   458.99 ns |  8.702 ns |  8.139 ns |  0.42 |    0.01 | 1.2817 |     - |     - |   4,024 B |
|                  Tinyield |     0 |  1000 | 8,582.74 ns | 30.963 ns | 25.856 ns |  7.83 |    0.08 | 4.1046 |     - |     - |  12,896 B |
