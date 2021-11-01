using System;
using System.Collections.Generic;

namespace ExemplosDeLista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("maria"); // adiciona valores ao final da  lista
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            list.Insert(2, "Marco"); // adiciona valores pela posição indicada
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine("Tamanho da lista: "+list.Count);

            string s1 = list.Find(x => x [0] == 'A'); // espera um predicado como argumento ou seja uma função

            Console.WriteLine("First 'A' "+s1);
            string s2 = list.FindLast(x => x[0] == 'A'); // espera um predicado como argumento ou seja uma função

            Console.WriteLine("Last 'A' "+s2);

            int pos1 = list.FindIndex(x => x[0] =='A'); // pega a primeira posição de um predicado
            Console.WriteLine("First Position 'A': "+pos1);
            int pos2 = list.FindLastIndex(x => x[0] == 'A'); // pega a ultima posição de um predicado
            Console.WriteLine("Last Position 'A': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length ==5);
            Console.WriteLine("----------------");

            foreach (string onj in list2)
            {
                Console.WriteLine(onj);
            }

            //list.Remove("Alex");
            //Console.WriteLine("--------------------------");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            //list.RemoveAt(3); // remove na posição
            //Console.WriteLine("--------------------------");
            //foreach (string obj in list)
            //{
            //    Console.WriteLine(obj);
            //}

            list.RemoveRange(2, 2 ) ; // a partir de tal posição, deve remover 2 elementos
            Console.WriteLine("--------------------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            list.RemoveAll(x => x[0] == 'M'); // remove todos que o predicado indica
            Console.WriteLine("-----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
