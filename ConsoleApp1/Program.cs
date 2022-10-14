using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Kata
    {
        public static int CountBits(int n)
        {
            string bits = Convert.ToString(n, 2);
            int count = bits.Count(x => x == '1');
            return count;
        }
    }
}
