using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    public class CustomComparisonByMinAsc:ICustomComparison
    {
        public int CompareJaggedArray(int[] x, int[] y)
        {
            return x.Min().CompareTo(y.Min());
        }
    }
    public class CustomComparisonByMinDec : ICustomComparison
    {
        public int CompareJaggedArray(int[] x, int[] y)
        {
            return (new CustomComparisonByMinAsc()).CompareJaggedArray(y, x);
        }
    }
}
