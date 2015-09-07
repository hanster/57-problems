using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    using NUnit.Framework;

    [TestFixture]
    class MultiplicationTest
    {
        [Test]
        public void GeneratesTwoTimesTable()
        {
            Multiplication multiplication = new Multiplication();
            List<int[]> twoTimesTable = multiplication.Generate(2);

            List<int[]> expected = new List<int[]>();
            expected.Add(new int[] { 0, 0, 0 });
            expected.Add(new int[] { 0, 1, 0 });
            expected.Add(new int[] { 0, 2, 0 });
            expected.Add(new int[] { 1, 0, 0 });
            expected.Add(new int[] { 1, 1, 1 });
            expected.Add(new int[] { 1, 2, 2 });
            expected.Add(new int[] { 2, 0, 0 });
            expected.Add(new int[] { 2, 1, 2 });
            expected.Add(new int[] { 2, 2, 4 });

            Assert.AreEqual(expected, twoTimesTable);
        }

        [Test]
        public void FormatTables()
        {
            Multiplication multiplication = new Multiplication();
            List<int[]> table = new List<int[]>();
            table.Add(new int[] { 0, 0, 0 });
            table.Add(new int[] { 0, 1, 0 });

            string formatedTable = multiplication.FormatTable(table);

            Assert.AreEqual("0 x 0 = 0\n0 x 1 = 0\n", formatedTable);
        }
    }
}
