using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ArrayExcercise
{
    class Program
    {
        static void Main(string[]args)
        {
             //losowa liczba 1 do 10 - ok
            Random myRandom = new Random();
            int randomNumber = myRandom.Next(1, 11);
            //Console.WriteLine(randomNumber);
            //Console.ReadLine();
            

            /* //pierwsza próba
            int[] page = new int[100];
            Random myRandom2 = new Random();
            for (int i = 0; i < page.Length; ++i)
                page[i] = myRandom2.Next(10);
            Console.WriteLine(myRandom2);
            Console.ReadLine();
            */


            //Console.WriteLine(String.Join(" " + System.Environment.NewLine, GetRandom()));
            string saveText = String.Join(" " + System.Environment.NewLine, GetRandom());
            //File.WriteAllText(@"C:\Users\Andrzej\source\repos\ArrayExcercise\bin\Debug\net6.0", saveText);
            System.IO.File.WriteAllText("text.txt",saveText);

            string[] sorted = File.ReadAllLines("text.txt");
            Array.Sort(sorted);
            
            for (int i = 0; i < sorted.Length; i++)
            {
                Console.WriteLine(sorted[i]);
                System.IO.File.WriteAllLines("text2.txt", sorted); //wcześniej waliłem głową z WriteAllText

            }
            

        }
        private static Random myRandom = new Random();
        public static List<int> GetRandom()
        {
            return Enumerable.Range(1, 15).OrderBy(_ => myRandom.Next()).ToList();
        }

    }

}