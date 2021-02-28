## Range.RangeToList

### Source
[RangeToList.cs](../LinqBenchmarks/Range/RangeToList.cs)

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
|        **ValueLinq_Standard** |     **0** |    **10** |   **111.98 ns** |  **0.530 ns** |  **0.496 ns** |  **1.20** |    **0.01** | **0.0305** |     **-** |     **-** |      **96 B** |
|           ValueLinq_Stack |     0 |    10 |   101.44 ns |  0.885 ns |  0.828 ns |  1.08 |    0.01 | 0.0305 |     - |     - |      96 B |
| ValueLinq_SharedPool_Push |     0 |    10 |   256.02 ns |  1.819 ns |  1.613 ns |  2.74 |    0.02 | 0.0305 |     - |     - |      96 B |
| ValueLinq_SharedPool_Pull |     0 |    10 |   259.00 ns |  1.334 ns |  1.114 ns |  2.77 |    0.02 | 0.0305 |     - |     - |      96 B |
|                   ForLoop |     0 |    10 |    93.54 ns |  0.569 ns |  0.532 ns |  1.00 |    0.00 | 0.0688 |     - |     - |     216 B |
|               ForeachLoop |     0 |    10 |   180.05 ns |  1.187 ns |  1.052 ns |  1.93 |    0.01 | 0.0865 |     - |     - |     272 B |
|                      Linq |     0 |    10 |    60.06 ns |  1.052 ns |  0.984 ns |  0.64 |    0.01 | 0.0433 |     - |     - |     136 B |
|                LinqFaster |     0 |    10 |    51.24 ns |  0.376 ns |  0.352 ns |  0.55 |    0.00 | 0.0510 |     - |     - |     160 B |
|                    LinqAF |     0 |    10 |    87.07 ns |  0.772 ns |  0.722 ns |  0.93 |    0.01 | 0.0305 |     - |     - |      96 B |
|                StructLinq |     0 |    10 |    24.81 ns |  0.121 ns |  0.101 ns |  0.27 |    0.00 | 0.0306 |     - |     - |      96 B |
|                 Hyperlinq |     0 |    10 |    35.42 ns |  0.246 ns |  0.205 ns |  0.38 |    0.00 | 0.0306 |     - |     - |      96 B |
|                  Tinyield |     0 |    10 |   250.29 ns |  2.420 ns |  2.263 ns |  2.68 |    0.03 | 0.2112 |     - |     - |     664 B |
|                           |       |       |             |           |           |       |         |        |       |       |           |
|        **ValueLinq_Standard** |     **0** |  **1000** | **2,944.20 ns** | **17.014 ns** | **15.915 ns** |  **0.95** |    **0.01** | **1.2894** |     **-** |     **-** |   **4,056 B** |
|           ValueLinq_Stack |     0 |  1000 | 3,613.28 ns | 22.450 ns | 20.999 ns |  1.17 |    0.01 | 2.6207 |     - |     - |   8,232 B |
| ValueLinq_SharedPool_Push |     0 |  1000 | 3,429.95 ns | 20.308 ns | 16.958 ns |  1.11 |    0.01 | 1.2894 |     - |     - |   4,056 B |
| ValueLinq_SharedPool_Pull |     0 |  1000 | 3,323.83 ns | 14.432 ns | 13.500 ns |  1.08 |    0.01 | 1.2894 |     - |     - |   4,056 B |
|                   ForLoop |     0 |  1000 | 3,088.40 ns | 19.664 ns | 18.394 ns |  1.00 |    0.00 | 2.6817 |     - |     - |   8,424 B |
|               ForeachLoop |     0 |  1000 | 7,527.26 ns | 44.420 ns | 39.377 ns |  2.44 |    0.02 | 2.7008 |     - |     - |   8,480 B |
|                      Linq |     0 |  1000 | 2,222.97 ns | 11.876 ns |  9.917 ns |  0.72 |    0.00 | 1.3046 |     - |     - |   4,096 B |
|                LinqFaster |     0 |  1000 | 1,360.31 ns |  9.077 ns |  7.580 ns |  0.44 |    0.00 | 2.5730 |     - |     - |   8,080 B |
|                    LinqAF |     0 |  1000 | 3,478.68 ns | 17.080 ns | 15.977 ns |  1.13 |    0.01 | 1.2894 |     - |     - |   4,056 B |
|                StructLinq |     0 |  1000 | 1,040.95 ns | 10.379 ns |  9.709 ns |  0.34 |    0.00 | 1.2913 |     - |     - |   4,056 B |
|                 Hyperlinq |     0 |  1000 |   485.91 ns |  4.756 ns |  4.449 ns |  0.16 |    0.00 | 1.2913 |     - |     - |   4,056 B |
|                  Tinyield |     0 |  1000 | 8,872.22 ns | 77.735 ns | 72.713 ns |  2.87 |    0.03 | 2.8229 |     - |     - |   8,872 B |
