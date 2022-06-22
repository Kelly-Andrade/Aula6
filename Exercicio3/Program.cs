namespace Exercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------\nEXERCÍCIO 3\n-----------");

            Fatura compra1 = new Fatura();
            compra1.Numero = 1;
            compra1.Descricao = "Mouse";
            compra1.Quantidade = 3;
            compra1.Preco = 67.50;

            compra1.Imprimir();
        }    
    }
}