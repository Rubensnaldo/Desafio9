using Microsoft.VisualBasic;
using System;

namespace ConversorDolarReal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a cotação do dólar: ");
            double cotacao = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o valor em dólares: ");
            double valorDolar = Convert.ToDouble(Console.ReadLine());

            Conversor conversor = new Conversor(cotacao);
            double valorReal = conversor.ConverterParaReal(valorDolar);

            Console.WriteLine($"O valor em reais é: R${valorReal:F2}");
        }
    }
}
