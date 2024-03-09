using System;
using System.Collections.Concurrent;
using System.Collections.Specialized;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace ExercicioSala
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("informe a quantidade de nomes: ");
            int t = Convert.ToInt32(Console.ReadLine());
            string[] nomes = new string[t];

            for (int i = 1; i <= nomes.Length; i++)
            {
                int b = 0;
                Console.WriteLine("informe o " + i + " nome: ");
                string ap = Convert.ToString(Console.ReadLine()); 

                nomes[b] = ap;
                b++;


            }
            int p = 0;
            while (p != 2)
            {
                Console.WriteLine("Deseja buscar nome pela posição?:\n 1.sim 2.nao");
                p = Convert.ToInt32(Console.ReadLine());
                if (p == 1)
                    Buscanome(nomes);
            }


        }

        static void Buscanome(string[] nomes)
        {
            Console.WriteLine("informe a posição: ");
            int po = Convert.ToInt32(Console.ReadLine());
           
            if (nomes.Length>0 && po<= nomes.Length)
            {

                Console.WriteLine("nome: " + nomes[po]);
            }
            else
                Console.WriteLine("busca fora do range do vetor.");
        }

    }

}

