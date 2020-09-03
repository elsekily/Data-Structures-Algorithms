using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class SudokuSolver
    {
        private List<char> elements = new List<char>() 
        { '1','2','3','4','5','6','7','8','9' };
        private bool isSolved;
        public void SolveSudoku(char[][] board)
        {
            var lastElement = LastElementIndex(board);
            Recursion(board, lastElement);
        }
        private void Recursion(char[][] board, int[] lastElement)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (board[i][j] == '.')
                    {
                        for (int k = 0; k < 9; k++)
                        {
                            if (CheckElement(board, i, j, elements[k]))
                            {
                                board[i][j] = elements[k];
                                if (lastElement[0] == i && lastElement[1] == j)
                                { 
                                    isSolved = true;
                                    return;
                                }
                                Recursion(board, lastElement);
                                if (!isSolved)
                                    board[i][j] = '.';
                            }
                        }
                        return;
                    }
                }
            }
            Print(board);
        }
        private bool CheckElement(char[][] board, int i, int j, char element)
        {
            for (int k = 0; k < 9; k++)
            {
                if (board[i][k] == element || board[k][j] == element)
                    return false;
            }
            var row = i - i % 3;
            var column = j - j % 3;
            for (int k = row; k <= row + 2; k++) 
            {
                for (int l = column; l <= column+2; l++)
                {
                    if (board[k][l] == element)
                        return false;
                }
            }
            return true;
        }
        private int[] LastElementIndex(char[][] board)
        {
            for (int i = 8; i >= 0; i--)
            {
                for (int j = 8; j >= 0; j--)
                {
                    if (board[i][j] == '.')
                        return new int[] { i, j };
                }
            }
            return new int[] { 0, 0 };
        }
        private void Print(char[][] board)
        {
            foreach (var sm in board)
            {
                foreach (var el in sm)
                {
                    System.Console.Write("{0}\t", el);
                }
                System.Console.WriteLine();
            }
            System.Console.WriteLine();
            System.Console.WriteLine();
        }
    }
 }
