using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class SpiralMatrix
    {
        public IList<int> SpiralOrder(int[][] matrix) 
        {
            var list = new List<int>();
            if(matrix.Length==0)
                return list;
                
            var minI = 0;
            var maxI = matrix.Length-1;
            var minJ = 0;
            var maxJ = matrix[0].Length-1;
            var size = matrix.Length * matrix[0].Length;

            while(CheckLength(size,list.Count))
            {
                RowForward(matrix,minI,minJ,maxJ,list);
                minI++;
                if(!CheckLength(size,list.Count))
                    break;
                Columndown(matrix,maxJ,minI,maxI,list);
                maxJ--;
                if(!CheckLength(size,list.Count))
                    break;
                RowBackward(matrix,maxI,maxJ,minJ,list);
                maxI--;
                if(!CheckLength(size,list.Count))
                    break;
                ColumnUp(matrix,minJ,maxI,minI,list);
                minJ++;
            }
            
            return list;
        }
        private bool CheckLength(int requiredSize, int listSize)
        {
            if(listSize < requiredSize)
                return true;
            return false; 
        }
        private void ColumnUp(int[][] matrix, int column, int end, int start, List<int> list)
        {
            for (int i = end; i >= start; i--)
                list.Add(matrix[i][column]);
        }

        private void RowBackward(int[][] matrix,int row, int end, int start, List<int> list)
        {
            for (int i = end; i >= start; i--)
                list.Add(matrix[row][i]);
        }

        private void Columndown(int[][] matrix, int column, int start, int end, List<int> list)
        {
            for (int i = start; i <= end; i++)
                list.Add(matrix[i][column]);
        }

        private void RowForward(int[][] matrix, int row, int start, int end, List<int> list)
        {
            for(int i = start;i<=end;i++)
                list.Add(matrix[row][i]);
        }
        
    }
}