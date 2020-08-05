using System;

namespace DataStructuresAndAlgorithms.ProblemSolving
{
    public class TwoDimensionalArray
    {
        public void Rotate2DArray(int[][] array)
        {
            Printing2DArray(array);
            Console.WriteLine("\n\n\n\n");
            for (int i = array.Length / 2; i < array.Length; i++)
            {
                for (int j = 0; j <= array[i].Length / 2; j++)
                {
                    var temp = array[i][j];
                    array[i][j] = array[j][i];
                    array[j][i] = temp;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j <= array[i].Length / 2; j++)
                {
                    var temp = array[i][j];
                    array[i][j] = array[i][array.Length - 1 - j];
                    array[i][array.Length - 1 - j] = temp;
                }
            }
            Printing2DArray(array);
        }
        public int[][] Rotate2DArrayWithSpaceComplexitityON(int[][] array)
        {
            //Space O(N), Complexitity O(N)
            int[][] aux = new int[array.Length][];
            for (int i = 0; i < array.Length; i++)
            {
                aux[i] = new int[array[0].Length];
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    aux[i][j] = array[array[i].Length - 1 - j][i];
                }
            }
            return aux;
        }
        public void Printing2DArray(int[][] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0}\t", array[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
