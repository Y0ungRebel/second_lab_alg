using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace second_lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1st
            Console.WriteLine($"Указанная цифра входит в заданное число: {Loops.entryDigitInNumber(324, 3)}");
            //var result = Loops.entryDigitInNumber(324, 3);

            //2nd
            Console.WriteLine($"{Loops.reverseNumber(32452)}");

            //3rd
            Console.WriteLine($"Числом Фиббоначи: {Loops.isFibbonachi(55)}");
        }
    }
}
