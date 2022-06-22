namespace Exercicio4
{
    public class Sorteio
    {
        public Sorteio()
        {
            Random random = new Random();
            int numeroSorteado = random.Next(0, 1001);

            bool acertou = false;
            int tentativas = 0;

            Console.WriteLine("Um número entre 0 a 1000 foi sorteado! Tente adivinhá-lo\n");

            while (acertou == false)
            {
                tentativas++;
                Console.Write("> ");
                int palpite = Convert.ToInt32(Console.ReadLine());

                if (palpite == numeroSorteado)
                {
                    Console.WriteLine($"\nVocê acertou! Número de tentativas: {tentativas}");
                    acertou = true;
                }

                else if (palpite > numeroSorteado)
                {
                    Console.WriteLine($"\nO número {palpite} é maior do que o número sorteado. Tente novamente!\n");
                }

                else
                {
                    Console.WriteLine($"\nO número {palpite} é menor do que o número sorteado. Tente novamente!\n");
                }
            }
        }
    }
}
