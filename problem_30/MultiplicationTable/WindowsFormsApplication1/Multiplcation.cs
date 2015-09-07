using System;
using System.Collections.Generic;
using System.Linq;

namespace MultiplicationTable
{
    internal class Multiplication
    {
        public Multiplication()
        {
        }

        internal List<int[]> Generate(int numberTable)
        {
            IEnumerable<int> range = Enumerable.Range(0, numberTable + 1);
            List<int[]> table = new List<int[]>();

            foreach (int firstNumber in range)
            {
                foreach (int secondNumber in range)
                {
                    int[] line = { firstNumber, secondNumber, firstNumber * secondNumber };
                    table.Add(line);
                }
            }
            return table;
        }

        internal string FormatTable(List<int[]> table)
        {
            var formattedLines = from line in table
                                 select $"{line[0]} x {line[1]} = {line[2]}\n";
            return String.Join("", formattedLines);
        }
    }
}