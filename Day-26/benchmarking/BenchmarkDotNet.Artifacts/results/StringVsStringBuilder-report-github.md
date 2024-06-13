```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3737/23H2/2023Update/SunValley3)
Intel Core i5-8300H CPU 2.30GHz (Coffee Lake), 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.200
  [Host]     : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.2 (8.0.224.6711), X64 RyuJIT AVX2


```
| Method          | n   | Mean        | Error     | StdDev    | Median      | Gen0   | Allocated |
|---------------- |---- |------------:|----------:|----------:|------------:|-------:|----------:|
| **MyString**        | **10**  |   **121.12 ns** |  **2.457 ns** |  **4.615 ns** |   **118.93 ns** | **0.0801** |     **336 B** |
| MyStringBuilder | 10  |    56.47 ns |  0.774 ns |  0.686 ns |    56.61 ns | 0.0363 |     152 B |
| **MyString**        | **100** | **2,087.47 ns** | **37.888 ns** | **35.440 ns** | **2,083.48 ns** | **4.9858** |   **20856 B** |
| MyString        | 100 | 2,088.88 ns | 32.830 ns | 36.490 ns | 2,078.48 ns | 4.9858 |   20856 B |
| MyStringBuilder | 100 |   728.70 ns | 14.073 ns | 19.728 ns |   726.93 ns | 0.3052 |    1280 B |
| MyStringBuilder | 100 |   707.42 ns |  7.368 ns |  6.532 ns |   705.07 ns | 0.3052 |    1280 B |
