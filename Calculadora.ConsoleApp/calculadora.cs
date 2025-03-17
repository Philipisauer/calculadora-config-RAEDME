namespace calculadora.ConsoleApp

{
	public static class Calculadora
    {
        static string[] historicoOperacoes = new string[100];
        static int contadorHistorico = 0;

        public static decimal Somar(decimal primeiroNumero, decimal segundonumero)
        {
            decimal resultado = primeiroNumero + segundonumero;

            historicoOperaçoes[contadorHistorico] = $"{primeiroNumero} + {segundonumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }

        public static decimal Subtarir(decimal primeiroNumero, decimal segundonumero)
        {
            decimal resultado = primeiroNumero - segundonumero;

            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} - {segundonumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }

        public static decimal multiplicar(decimal primeiroNumero, decimal segundonumero)
        {
            decimal resultado = primeiroNumero * segundonumero;

            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} * {segundonumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;
        }

             public static decimal Dividir(decimal primeiroNumero, decimal segundonumero)
        {
            decimal resultado = primeiroNumero / segundonumero;

            historicoOperacoes[contadorHistorico] = $"{primeiroNumero} / {segundonumero} = {resultado}";

            contadorHistorico += 1;

            return resultado;

        }
	{
        public static string[] gerarTabuada(int numeroTabuada)
        {
            string linhasTabuada = new string[10];

            for (int contador = 1; contador <= 10; contador++)
            {
                int resultadoTabuada = numeroTabuada * contador;

                linhasTabuada[contador - 1] = $"{numeroTabuada} x {contador} = {resultadoTabuada}";

                return linhasTabuada;
            }
            
            public static string[] ObterHistoricoOperacoes()
        {
            return historicoOperacoes;
        }
    }
 





        }
    }
