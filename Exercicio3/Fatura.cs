namespace Exercicio3
{
    public class Fatura
    {
        //private double numero;
        private string descricao; 
        private double quantidade;
        private double preco;


        public double Numero { get; set; }
        //{
        //    get { return numero; }
        //    set { numero = value; }
        //}

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public double Preco
        {
            get { return preco; }   
            set { preco = value; }
        }

        private void ValorTotal(double Preco, double Quantidade)
        {
            double Total = Preco * Quantidade;
            Console.WriteLine($"Valor Total da Fatura: R$ {Total:00.00}");
        }

        public void Imprimir()
        {
            Console.WriteLine("\n| FATURA |\n");
            Console.WriteLine($"Número do produto: {Numero}");
            Console.WriteLine($"Descrição: {Descricao}");
            Console.WriteLine($"Quantidade comprada: {Quantidade}");            
            Console.WriteLine($"Preço: R$ {Preco:00.00}");
            ValorTotal(Preco, Quantidade);
        }
    }
}
