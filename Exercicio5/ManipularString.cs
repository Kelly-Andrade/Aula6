namespace Exercicio5
{
    public class ManipularString
    {
        public void Abreviar()
        {
            Console.Write("Digite o nome completo: ");
            string nome = Console.ReadLine();
            string[] nomes = nome.Split(' ');

            string abreviado = "";

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i].Length > 2)
                    nomes[i] = nomes[i].Substring(0, 1) + ".";
                abreviado = abreviado + nomes[i] + " ";
            }
            Console.WriteLine("\nAbreviatura: " + abreviado);
        }

        public void Inverter()
        {
            Console.Write("\nInsira uma palavra ou frase para inverter: ");
            string normal = Console.ReadLine();
            string invertido = new string(normal.Reverse().ToArray());
            Console.WriteLine("\nInvertido: "+ invertido);
        }

        public void Contar()
        {
            Console.WriteLine("\nInsira uma palavra ou frase para contar as vogais e consoantes: ");
            string frase = Console.ReadLine();
            int quantidadeTotal = frase.Count();
            int quantidadeVogais = frase.Count(x => (x == 'a') || (x == 'e') || (x == 'i') || (x == 'o') || (x == 'u'));
            int quantidadeConsoantes = quantidadeTotal - quantidadeVogais;
            Console.WriteLine("\nQuantidade de vogais: " + quantidadeVogais);
            Console.WriteLine("Quantidade de consoantes: " + quantidadeConsoantes);
        }
    }
}
