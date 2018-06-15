using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeSquareCount
{

   

    class Program
    {
        static void Main(string[] args)
        {
            int A = 4;
            int B = 17;
            Solution sln = new Solution();
            Console.WriteLine("Answer: "+sln.WholeSquareCount(A,B));
            Console.ReadKey();

        }
    }
}
