using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
namespace Curso_CS
{
    class Program
    {
        static bool EhPrimo(int valor)
        {
            int numeroDeDivisores = 0;
            foreach (int x in Enumerable.Range(1, valor / 2))
            {
                if (valor % x == 0)
                    numeroDeDivisores++;
                if (numeroDeDivisores > 1)
                    return false;
            }
            return true;
        }
        static void EntradaDeDados()
        {
            String[] entradaVet = Console.ReadLine().Split(' ');
            foreach (int value in System.Linq.Enumerable.Range(0, entradaVet.Length))
            {
                Console.WriteLine(entradaVet[value]); ;
            }

        }
        static void EntradaDeDados2()
        {
            int entrada = int.Parse(Console.ReadLine());
            if (EhPrimo(entrada))
                Console.WriteLine("E primo");
            else
                Console.WriteLine("N é primo");

        }


        void SaidaDeDaddos()
        {
            double x = (1.0 / 3);
            String nome = "Maria";
            double saldo = 123000.012910299129;
            String mesDeSaldo = "Dezembro";
            Console.WriteLine(x.ToString("F10", CultureInfo.InvariantCulture));
            Console.WriteLine("{0} tinha {1:F3} de saldo na sua conta em {2}/2020", nome, saldo, mesDeSaldo);
            Console.WriteLine($"{nome} tinha {saldo:F3} de saldo na sua conta em {mesDeSaldo}/2020");
            Console.WriteLine(nome + " tinha " + saldo.ToString("F3", CultureInfo.InvariantCulture) + " de saldo na sua conta em " + mesDeSaldo + "/2020");

            double a = 5.6;
            int b = (int)a;

            Console.WriteLine(b);
        }
        void LeTriangulos()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            Console.WriteLine(x.CalculaArea());
            Console.WriteLine(y.CalculaArea());
        }
        static void LeFuncionarios()
        {
            Funcionario f1, f2;
            f1 = new Funcionario();
            f2 = new Funcionario();
            f1.Nome = Console.ReadLine();
            f1.Salario = double.Parse(Console.ReadLine());
            f2.Nome = Console.ReadLine();
            f2.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine((f1.Salario + f2.Salario) / 2);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
        }
        static void Contas()
        {
            String titularAux;
            int numeroAux;
            char haveraDepositoIncial;
            double saldoAux = 0;

            Conta a, b;

            // Lê os dados da primeira conta
            Console.WriteLine("Entre com o numero da conta");
            numeroAux = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta");
            titularAux = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? (s/n)");
            haveraDepositoIncial = char.Parse(Console.ReadLine());
            if (haveraDepositoIncial == 's' || haveraDepositoIncial == 'S')
            {
                Console.WriteLine("Entre com o valor do deposito incial");
                saldoAux = double.Parse(Console.ReadLine());
            }

            a = new Conta(numeroAux, titularAux, saldoAux);
            saldoAux = 0;

            //Lê os dados da segunda conta
            Console.WriteLine("Entre com o numero da conta");
            numeroAux = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o titular da conta");
            titularAux = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial? (s/n)");
            haveraDepositoIncial = char.Parse(Console.ReadLine());
            if (haveraDepositoIncial == 's' || haveraDepositoIncial == 'S')
            {
                Console.WriteLine("Entre com o valor do deposito incial");
                saldoAux = double.Parse(Console.ReadLine());
            }

            b = new Conta(numeroAux, titularAux, saldoAux);

            //Imprime as duas contas
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
        static void VetoresObjetos()
        {
            int nQuartos, quarto;
            String nome, email;
            Aluguel[] quartos = new Aluguel[10];
            Console.WriteLine("Quantos quartos vão ser alugados");
            nQuartos = int.Parse(Console.ReadLine());
            foreach (int i in Enumerable.Range(1, nQuartos))
            {
                Console.WriteLine("Digite o numero do {0}° quarto", i);
                quarto = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o nome");
                nome = Console.ReadLine();
                Console.WriteLine("Digite o email");
                email = Console.ReadLine();
                quartos[quarto - 1] = new Aluguel(nome, email, quarto);
            }
            foreach (int i in Enumerable.Range(0, quartos.Length))
            {
                if (quartos[i] != null)
                {
                    Console.WriteLine(quartos[i]);
                }

            }
        }
        static void VetoresEParams()
        {
            int[] vetor = new int[10];
            foreach (int i in Enumerable.Range(1, vetor.Length))
            {
                vetor[i - 1] = i;
            }
            Console.WriteLine(Calculadora.Soma(1, 2.1, 3, 4, 5, 1));
        }
        static void Listas()
        {
            List<string> nomes = new List<string>();
            nomes.Add("Joao");
            nomes.Add("Caio");
            nomes.Add("Luana");
            nomes.Add("Lucio");
            nomes.Add("Debora");

            foreach(string nome in nomes)
            {
                Console.WriteLine(nome);
            }
        }

        static void ListasExercicio()
        {
            List<Func> funcionarios = new List<Func>();
            int aux;
            Console.WriteLine("How many employees will be registered");
            aux = int.Parse(Console.ReadLine());
            foreach (int i in Enumerable.Range(1, aux))
            {
                string name; double salary; int id;
                Console.WriteLine("Id");
                Console.WriteLine("Name");
                Console.WriteLine("Salary");
            }
        }
        static void Main(string[] args)
        {
            


        }

    }
}
