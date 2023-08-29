namespace EncontrarRaizQuadrada.App.Algoritmos
{
    public static class AlgoritmoRaizQuadrada
    {
        public static int EncontrarRaizQuadradaEmComplexidadeRaizQuadradaDeTempo(int x)
        {
            if (x == 0 || x == 1)
            {
                return x;
            }
            int i = 1;
            int resultado = 1;
            while (resultado <= x)
            {
                i++;
                resultado = i * i;
            }
            return i - 1; 
        }

        public static int EncontrarRaizQuadradaEmComplexidadeLogaritmicaDeTempo(int x)
        {
            if (x == 0 || x == 1)
            {
                return x;
            }
            int inicio = 1;
            int fim = x / 2;
            int resposta = 1;
            while (inicio <= fim)
            {
                int metade = (inicio + fim) / 2;
                int quadrado = metade * metade;
                if (quadrado == x)
                {
                    return metade;
                }
                if (quadrado <= x)
                {
                    inicio = metade + 1;
                    resposta = metade;
                }
                else
                {
                    fim = metade - 1;
                }
            }
            return resposta;
        }
    }
}