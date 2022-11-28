using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Benvenuto, dichiara quanti nomi inserirai: _");
            int length = int.Parse(Console.ReadLine());
            
            string[] Names = new string[length];
            int i= 0;
            do
            {
                Console.WriteLine($"Inserisci {i+1}° Nome: _");
                string name = Console.ReadLine();
                Names[i] = name;
                i++;
            } while (i < length);

            //Console.WriteLine($"{Names[0]}");
            //Console.ReadLine();

            Console.WriteLine("Ricerca nome: _");
            string NametoFind = Console.ReadLine();

            Console.WriteLine("<><><><><><><><><><>");
            int j;
            for (j=0;j<Names.Length;j++) 
            {
                if (Names[j] == NametoFind)
                {
                    Console.WriteLine($"\nNome trovato: {Names[j]}\nPosizione nell'array: {j}\n");
                }
            }
            Console.WriteLine("<><><><><><><><><><>");
            Console.ReadLine();



        }

       
    }
}
