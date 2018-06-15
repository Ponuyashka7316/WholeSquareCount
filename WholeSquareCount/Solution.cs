using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WholeSquareCount
{
    class Solution
    {
        public int WholeSquareCount(int A, int B)
        {
            int count = 0;
            for (int i = 0; i <= Int32.MaxValue; i++)
            {
                if (Enumerable.Range(A, B).Contains((int)Math.Pow(i, 2)))
                    count++;
                else if (Math.Pow(i, 2) > B) return count;
            }
            return count;
        }
    }
}
