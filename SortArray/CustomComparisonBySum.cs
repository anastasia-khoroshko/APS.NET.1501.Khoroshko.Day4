using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    public class CustomComparisonBySumAsc:ICustomComparison
    {
        public int CompareJaggedArray(int[] x, int[] y)
        {
            return x.Sum().CompareTo(y.Sum());
        }
    }

    public class CustomComparisonBySumDec : ICustomComparison
    {
        public int CompareJaggedArray(int[] x, int[] y)
        {
            return (new CustomComparisonBySumAsc()).CompareJaggedArray(y, x);
        }
    }
}
