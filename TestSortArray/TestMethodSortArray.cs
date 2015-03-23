using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SortArray;

namespace TestSortArray
{
    [TestClass]
    public class TestSort
    {
        //private ICustomComparison ca;
        [TestMethod]
        public void TestSortBySumIncrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[0] = new int[] { 2, 11, 0, -4 };
            b[1] = new int[] { 1, 2, 9 };
            b[2] = new int[] { 20, 6, 12, -5, 7 }; 
            //ca = new CustomComparisonBySumAsc();
            MethodsSortArray.Sort(a,(x,y)=>x.Sum().CompareTo(y.Sum()));
            Assert.ReferenceEquals(a, b);
        }
        [TestMethod]
        public void TestSortBySumDecrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[2] = new int[] { 2, 11, 0, -4 };
            b[1] = new int[] { 1, 2, 9 };
            b[0] = new int[] { 20, 6, 12, -5, 7 };
            //ca = new CustomComparisonBySumDec();
            MethodsSortArray.Sort(a, (x, y) => y.Sum().CompareTo(x.Sum()));
            Assert.ReferenceEquals(a, b);
        }

        [TestMethod]
        public void TestSortByMaxElemIncrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[0] = new int[] { 1, 2, 9 };
            b[1] = new int[] { 2, 11, 0, -4 };
            b[2] = new int[] { 20, 6, 12, -5, 7 };
            //ca = new CustomComparisonByMaxAsc();
            MethodsSortArray.Sort(a, (x, y) => x.Max().CompareTo(y.Max()));
            Assert.ReferenceEquals(a, b);
        }

        [TestMethod]
        public void TestSortByMaxElemDecrease()
        {
            int[][] a = new int[3][];
            a[0] = new int[] { 20, 6, 12, -5, 7 };
            a[1] = new int[] { 1, 2, 9 };
            a[2] = new int[] { 2, 11, 0, -4 };
            int[][] b = new int[3][];
            b[2] = new int[] { 1, 2, 9 };
            b[1] = new int[] { 2, 11, 0, -4 };
            b[0] = new int[] { 20, 6, 12, -5, 7 };
            //ca = new CustomComparisonByMaxDec();
            MethodsSortArray.Sort(a, (x, y) => y.Max().CompareTo(x.Max()));
            Assert.ReferenceEquals(a, b);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSortException()
        {
            int[][] a = null;
            MethodsSortArray.Sort(a, (x, y) => x.Sum().CompareTo(y.Sum()));
        }
    }
}
