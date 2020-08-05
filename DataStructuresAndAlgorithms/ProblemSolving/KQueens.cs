using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.ProblemSolving
{
    public class KQueens
    {
        private int[] array;
        public KQueens(int size)
        {
            array = new int[size];
        }

        public List<int[]> PrintSolutions()
        {
            var list = new List<int[]>();
            Recursion(0, list);
            return list;
        }
        private void Recursion(int column, List<int[]> list)
        {
            if (column == array.Length)
            {
                list.Add((int[])array.Clone());
                return;
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                array[column] = i + 1;
                if (Check(column))
                    Recursion(column+1, list);
            }
        }
        private bool Check(int column)
        {
            for (int i = column - 1; i >= 0; i--)
            {
                if (array[column] == array[i])//checking rows
                    return false;

                if (Math.Abs(column - i) == Math.Abs(array[column] - array[i]))//checking diagonals
                    return false;
            }
            return true;
        }
        public void Visualizer(List<int[]> list)
        {
            char[] a = new char[this.array.Length];
            foreach (var item in list)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    a[i] = (char)(item[i] + 48);
                }
                ChessBoard2DConsole(a);
            }
        }
        private void ChessBoard2DConsole(char[] array)
        {
            Console.WriteLine("\n");
            Console.Write("\t |");
            for (int i = 0; i < array.Length; i++)
                Console.Write("{0}|", i + 1);

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\t{0}|", i + 1);
                for (int j = 0; j < array.Length; j++)
                {
                    ChangeBackGroundColor(i, j);
                    if (i + 48 == ((int)array[j]) - 1)
                    {
                        Console.Write("*");
                    }

                    else
                    {
                        Console.Write(" ");
                    }
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("|");
                }
                Console.WriteLine();
            }
        }
        private void ChangeBackGroundColor(int i, int j)
        {
            if (i % 2 == 0)
            {
                if (j % 2 == 0)
                    Console.BackgroundColor = ConsoleColor.White;
                else
                    Console.BackgroundColor = ConsoleColor.Green;
            }
            else
            {
                if (j % 2 == 0)
                    Console.BackgroundColor = ConsoleColor.Green;
                else
                    Console.BackgroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor = ConsoleColor.Black;

        }
    }
}
