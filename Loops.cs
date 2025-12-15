using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second_lab
{
    public class Loops
    {
        public static bool entryDigitInNumber(int value, int c)
        {
            while (value > 0)
            {
                if (value % 10 == c) return true;
                value /= 10;
            }
            return false;
        }

        public static int reverseNumber(int value)
        {
            int count = value.ToString().Length;
            string result = "";
            while (result.Length != count)
            {
                result += (value % 10).ToString();
                value /= 10;
            }
            return Convert.ToInt32(result);
        }

        public static bool isFibbonachi(int value)
        {
            int f = 1;
            int s = 1;
            int newVal = 0;
            Console.Write($"{f}, {s}");
            while (newVal < value)
            {
                newVal = f + s;
                f = s;
                s = newVal;                
                Console.Write($", {newVal}");
                if (value == newVal) return true;
            }
            return false;
        }
    }
}
