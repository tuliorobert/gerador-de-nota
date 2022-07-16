using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variaveis
            var random = new Random();
            double[,] nota = new double[5, 4];
            double media;

            // Listas
            List<double> aprovados = new List<double>();
            List<double> reprovados = new List<double>();

            // Gerando notas aleatórias
            for (int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    nota[i, j] = random.Next(10);
                }
            }

            // Inicio da lista
            Console.WriteLine("Lista de notas:\n");

            for(int i = 0; i < 5; i++)
            {
                double total = 0;
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Nota do aluno {0}", (i + 1) + ":\n");

                for(int j = 0; j < 4; j++)
                {
                    Console.Write(Math.Round(nota[i, j], 2) + "     ");
                    total += nota[i, j];
                }

                media = (total / 4);
                Console.WriteLine("Media: {0}", Math.Round(media, 1));

                if (media > 5) aprovados.Add(i + 1);
                else reprovados.Add(i + 1);
            }


            // Exibindo a lista de aprovados e reprovados
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("\nAlunos Aprovados: ");
            foreach(double aprovado in aprovados) 
            {
                Console.Write(aprovado + "     ");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Alunos Reprovados: ");
            foreach(double reprovado in reprovados)
            {
                Console.Write(reprovado + "     ");
            }
        }
    }
}