``` ini

BenchmarkDotNet=v0.13.5, OS=Windows 10 (10.0.19045.3324/22H2/2022Update)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.203
  [Host]     : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
  DefaultJob : .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2


```
|                                                                 Method |       X |       Mean |     Error |    StdDev |     Median | Rank | Allocated |
|----------------------------------------------------------------------- |-------- |-----------:|----------:|----------:|-----------:|-----:|----------:|
| **MedirPerformanceEncontrarRaizQuadradaEmComplexidadeRaizQuadradaDeTempo** |     **100** |   **3.742 ns** | **0.0139 ns** | **0.0108 ns** |   **3.745 ns** |    **1** |         **-** |
|  MedirPerformanceEncontrarRaizQuadradaEmComplexidadeLogaritmicaDeTempo |     100 |   6.782 ns | 0.1625 ns | 0.2530 ns |   6.711 ns |    2 |         - |
| **MedirPerformanceEncontrarRaizQuadradaEmComplexidadeRaizQuadradaDeTempo** |     **500** |   **6.615 ns** | **0.0701 ns** | **0.0548 ns** |   **6.609 ns** |    **2** |         **-** |
|  MedirPerformanceEncontrarRaizQuadradaEmComplexidadeLogaritmicaDeTempo |     500 |  11.563 ns | 0.2132 ns | 0.4680 ns |  11.396 ns |    5 |         - |
| **MedirPerformanceEncontrarRaizQuadradaEmComplexidadeRaizQuadradaDeTempo** |    **1000** |   **9.633 ns** | **0.2210 ns** | **0.3693 ns** |   **9.627 ns** |    **3** |         **-** |
|  MedirPerformanceEncontrarRaizQuadradaEmComplexidadeLogaritmicaDeTempo |    1000 |  10.572 ns | 0.2361 ns | 0.2318 ns |  10.559 ns |    4 |         - |
| **MedirPerformanceEncontrarRaizQuadradaEmComplexidadeRaizQuadradaDeTempo** |    **5000** |  **20.407 ns** | **0.2933 ns** | **0.2600 ns** |  **20.498 ns** |    **7** |         **-** |
|  MedirPerformanceEncontrarRaizQuadradaEmComplexidadeLogaritmicaDeTempo |    5000 |  14.836 ns | 0.1328 ns | 0.1109 ns |  14.831 ns |    6 |         - |
| **MedirPerformanceEncontrarRaizQuadradaEmComplexidadeRaizQuadradaDeTempo** | **1000000** | **246.772 ns** | **3.6664 ns** | **3.2502 ns** | **246.455 ns** |    **9** |         **-** |
|  MedirPerformanceEncontrarRaizQuadradaEmComplexidadeLogaritmicaDeTempo | 1000000 |  27.472 ns | 0.2859 ns | 0.2674 ns |  27.440 ns |    8 |         - |
