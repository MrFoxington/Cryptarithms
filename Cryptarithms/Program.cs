using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cryptarithms
{
    class Program
    {
        // Solution can't have leading Zeros's. (Left Most digit cant be Zero)
        // All Unique Numbers
        // Base 10 
        static void Main(string[] args)
        {
            Console.WriteLine(args.ToString());
            CryptarithmicPuzzle puzzle = new CryptarithmicPuzzle(args[0]);
        }
    }
}
