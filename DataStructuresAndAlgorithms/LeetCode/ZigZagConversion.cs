using System.Data;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class ZigZagConversion
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            var matrix = new StringBuilder[numRows];
            int sMember = 0;
            int row = 0;
            bool dir = true;
            while (sMember < s.Length)
            {
                if (matrix[row] == null)
                    matrix[row] = new StringBuilder();

                matrix[row].Append(s[sMember]);
                sMember++;

                if (row == numRows - 1)
                    dir = false;

                if (row == 0)
                    dir = true;

                if (dir)
                    row++;
                else
                    row--;
            }

            var str = new StringBuilder();
            foreach (var item in matrix)
            {
                str.Append(item);
            }
            return str.ToString();
        }
    }
}
