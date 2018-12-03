using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_poo_conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            Console.Write("O curso A possui quantos alunos?");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso A:");
            HashSet<int> A = new HashSet<int>();
            for(int i = 0; i < N; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso B possui quantos alunos?");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso B:");
            HashSet<int> B = new HashSet<int>();
            for (int i = 0; i < N; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("O curso C possui quantos alunos?");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os códigos dos alunos do curso C:");
            HashSet<int> C = new HashSet<int>();
            for (int i = 0; i < N; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> Novo = new HashSet<int>();
            Novo.UnionWith(A);
            Novo.UnionWith(B);
            Novo.UnionWith(C);
            Console.Write("Total de alunos: " + Novo.Count);


            Console.ReadLine();
        }
    }
}
