```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
Intel Core i5-8300H CPU 2.30GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2


```
| Method           | Mean      | Error     | StdDev    |
|----------------- |----------:|----------:|----------:|
| TwoSum           | 51.270 ns | 0.8952 ns | 0.8374 ns |
| TwoSumBruteForce |  5.551 ns | 0.0448 ns | 0.0397 ns |
