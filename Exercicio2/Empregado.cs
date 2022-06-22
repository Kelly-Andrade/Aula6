namespace Exercicio2
{
    public class Empregado
    {
        private string nome;
        private string cargo;
        private double salario;
        private double novoSalario;

        public string Nome { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }        
        public double NovoSalario { get; set; } 

        public Empregado()
        {
            Console.WriteLine("\nInsira o nome: ");            
            Nome = Console.ReadLine();
            this.nome = Nome;

            Console.WriteLine("Insira o cargo: ");
            Cargo = Console.ReadLine();
            this.cargo = Cargo;

            Console.WriteLine("Insira o salario: ");
            Salario = Convert.ToDouble(Console.ReadLine());
            this.salario = Salario;

            this.novoSalario = NovoSalario;
                                    
            
            Console.WriteLine($"Nome do funcionário: {Nome}\nCargo: {Cargo}");
            ImprimirSalario(Salario);
            
        }

        private void ImprimirSalario(double Salario)
        {
            if (Salario < 0)
            {
                Salario = 0.0;
                Console.WriteLine($"Salário: R$ {Salario:0.00}");
            }
            else
            {
                Console.WriteLine($"Salário: R$ {Salario:00.00}");
                Aumento(Salario);
            }
        }

        private void Aumento(double Salario)
        {
            double perc = 0; 
            double ValorAumento;

            if (Salario > 0 && Salario <= 400.00)
            {
                perc = 0.15;
            }
            else if (Salario > 400.00 && Salario <= 800.00)
            {
                perc = 0.12;
            }
            else if (Salario > 800.00 && Salario <= 1200.00)
            {
                perc = 0.10;
            }
            else if (Salario > 1200.00 && Salario <= 2000.00)
            {
                perc = 0.07;
            }
            else if (Salario > 2000.00)
            {
                perc = 0.04;
            }
            ValorAumento = Salario * perc;
            NovoSalario = Salario + ValorAumento;
            
            
            Console.WriteLine($"Percentual de aumento: {perc*100}%");
            Console.WriteLine($"O aumento será de: R$ {ValorAumento:00.00}");
            Console.WriteLine($"Novo salário com aumento: R$ {NovoSalario:00.00}\n");
        }
    }
}

