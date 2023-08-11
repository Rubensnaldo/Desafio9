namespace ConversorDolarReal.Domain
{
    public class Moeda
    {
        public string Codigo { get; set; }
        public string Nome { get; set; }
        public string Simbolo { get; set; }

        public Moeda(string codigo, string nome, string simbolo)
        {
            Codigo = codigo;
            Nome = nome;
            Simbolo = simbolo;
        }
    }
}

