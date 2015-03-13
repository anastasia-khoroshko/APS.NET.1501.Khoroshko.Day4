using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    public class CustomComparisonByMaxAsc:ICustomComparison
    {
        public int CompareJaggedArray(int[] x, int[] y)
        {
            return x.Max().CompareTo(y.Max());
        }
    }

    public class CustomComparisonByMaxDec:ICustomComparison
    {
        public int CompareJaggedArray(int[] x, int[] y)
        {
            return (new CustomComparisonByMaxAsc()).CompareJaggedArray(y, x);
        }
    }

}
