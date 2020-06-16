using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample
{
    class Program
    {
        static void Main(string[] args)
        {

            var moji = new List<String>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("文字列：");
                moji.Add(Console.ReadLine());

            }




            for (int i = 0; i < moji.Count; i++)
            {
                Console.WriteLine(moji[i] + " ");
            }
            








            //List<int> numbers = newList<int>();
            //var numbers = new List<int>();
            //
            //numbers.Add(3);
            //numbers.Add(2);
            //numbers.Add(8);
            //numbers.Add(5);
            //numbers.Add(7);
            //numbers.Add(1);
            //
            //for (int i = 0; i < numbers.Count; i++)
            //{
            //    Console.Write(numbers[i] + " ");
            //}
            //
            //foreach (var num in numbers)
            //{
            //    Console.Write(num+" ");
            //}






        }
    }
}
