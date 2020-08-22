using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var list = new List<IList<int>>();
            if (numRows == 0)
                return list;
            
            list.Add(new List<int>() { 1 });
            if (numRows == 1)
                return list;
            
            list.Add(new List<int>() { 1, 1 });
            if (numRows == 2)
                return list;

            for (int i = 2; i < numRows; i++)
            {
                var subList = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0) subList.Add(1);
                    if (j == i) subList.Add(1);
                    if (j != 0 && j != i) subList.Add(list[i - 1][j] + list[i - 1][j - 1]);
                }
                list.Add(subList);
            }
            return list;
        }
    }
}
