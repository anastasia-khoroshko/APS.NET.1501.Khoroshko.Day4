using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using SortArray;

namespace TestSortArray
{
    [TestClass]
    public class TestSort
    {
        private ICustomComparison ca;
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
            ca = new CustomComparisonBySumAsc();
            Assert.ReferenceEquals(MethodsSortArray.Sort(a,ca), b);
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
            ca = new CustomComparisonBySumDec();
            Assert.ReferenceEquals(MethodsSortArray.Sort(a, ca), b);
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
            ca = new CustomComparisonByMaxAsc();
            Assert.ReferenceEquals(MethodsSortArray.Sort(a, ca), b);
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
            ca = new CustomComparisonByMaxDec();
            Assert.ReferenceEquals(MethodsSortArray.Sort(a, ca), b);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSortException()
        {
            int[][] a = null;
            MethodsSortArray.Sort(a, ca);
        }
    }
}
