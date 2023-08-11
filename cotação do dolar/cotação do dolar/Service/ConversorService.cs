namespace ConversorDolarReal
{
    class Conversor
    {
        private double cotacaoDolar;

        public Conversor(double cotacao)
        {
            cotacaoDolar = cotacao;
        }

        public double ConverterParaReal(double valorDolar)
        {
            return valorDolar * cotacaoDolar;
        }
    }
}

