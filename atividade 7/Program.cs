using System;

namespace IdadeVotarHabilitacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o ano de nascimento:");
            int anoNascimento = int.Parse(Console.ReadLine());

            // Calcula a idade da pessoa com base no ano atual
            int idade = DateTime.Now.Year - anoNascimento;

            Console.WriteLine($"Idade: {idade}");

            // Verifica se a pessoa tem idade suficiente para votar e obter a CNH
            if (idade >= 16)
            {
                Console.WriteLine("Você já pode votar!");
            }
            else
            {
                Console.WriteLine("Você ainda não pode votar!");
            }

            if (idade >= 18)
            {
                Console.WriteLine("Você já pode obter a CNH!");
            }
            else
            {
                Console.WriteLine("Você ainda não pode obter a CNH!");
            }
        }
    }
}

