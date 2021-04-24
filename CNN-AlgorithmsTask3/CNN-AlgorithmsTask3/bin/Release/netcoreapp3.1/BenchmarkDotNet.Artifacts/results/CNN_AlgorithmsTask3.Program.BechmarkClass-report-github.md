``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
AMD A12-9720P RADEON R7, 12 COMPUTE CORES 4C+8G, 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.104
  [Host]     : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT  [AttachedDebugger]
  DefaultJob : .NET Core 3.1.13 (CoreCLR 4.700.21.11102, CoreFX 4.700.21.11602), X64 RyuJIT


```
|              Method |      Mean |     Error |    StdDev |    Median |
|-------------------- |----------:|----------:|----------:|----------:|
|       PointDistance | 2.5535 ns | 0.2488 ns | 0.7140 ns | 2.8646 ns |
|  PointDistanceFloat | 0.1720 ns | 0.0294 ns | 0.0858 ns | 0.2064 ns |
| PointDistanceDouble | 0.0324 ns | 0.0128 ns | 0.0113 ns | 0.0304 ns |
| PointDistanceStruct | 0.1481 ns | 0.0264 ns | 0.0754 ns | 0.1751 ns |
