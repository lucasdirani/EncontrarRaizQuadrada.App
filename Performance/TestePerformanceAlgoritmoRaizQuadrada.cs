using BenchmarkDotNet.Attributes;
using EncontrarRaizQuadrada.App.Algoritmos;

namespace EncontrarRaizQuadrada.App.Performance
{
    [MemoryDiagnoser]
    [RankColumn]
    public class TestePerformanceAlgoritmoRaizQuadrada
    {
        [Params(100, 500, 1000, 5000, 1000000)]
        public int X { get; set; }

        [Benchmark]
        public void MedirPerformanceEncontrarRaizQuadradaEmComplexidadeRaizQuadradaDeTempo()
        {
            AlgoritmoRaizQuadrada.EncontrarRaizQuadradaEmComplexidadeRaizQuadradaDeTempo(X);
        }

        [Benchmark]
        public void MedirPerformanceEncontrarRaizQuadradaEmComplexidadeLogaritmicaDeTempo()
        {
            AlgoritmoRaizQuadrada.EncontrarRaizQuadradaEmComplexidadeLogaritmicaDeTempo(X);
        }
    }
}