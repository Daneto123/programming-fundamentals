using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp37
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            var volume = int.Parse(Console.ReadLine());
            var energy = int.Parse(Console.ReadLine());
            var shugar = int.Parse(Console.ReadLine());
            var neshto = int.Parse(Console.ReadLine());

            var ostavshti = energy - volume;
            var ostavashti2 = neshto - shugar;

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{new string('|', volume)}{new string('.', ostavshti)}|");
            Console.WriteLine($"Energy: |{new string('|', shugar)}{new string('.', ostavashti2)}|");

        }
    }
}
