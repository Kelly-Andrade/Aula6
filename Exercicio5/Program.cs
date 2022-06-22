namespace Exercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------\nEXERCÍCIO 4\n-----------\n");

            ManipularString manipular = new ManipularString();
            manipular.Abreviar();

            manipular.Inverter();

            manipular.Contar();  
        }
    }
}