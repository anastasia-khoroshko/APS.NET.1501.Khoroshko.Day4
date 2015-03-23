using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    public static class MethodsSortArray
    {
        private class Adapter:ICustomComparison
        {
            Func<int[], int[], int> comparer;
            public Adapter(Func<int[], int[], int> comparer)
            {
                this.comparer = comparer;
            }
            public int CompareJaggedArray(int[] x, int[] y)
            {
                return comparer(x,y);
            }
        }

        public static void Sort(int[][] array,Func<int[],int[],int> comparer)
        {
            Adapter adapter = new Adapter(comparer);
            Sort(array,adapter);
        }
        public static void Sort(int[][] array,ICustomComparison ca)
        {
            if (array == null || ca==null || !(ca is ICustomComparison)) throw new ArgumentNullException("Invalid argument");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (ca.CompareJaggedArray(array[i], array[j]) > 0)
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }

        private static void Swap(ref int[] x, ref int[] y)
        {
            int[] temp = x;
            x = y;
            y = temp;
        }
       
    }
}
