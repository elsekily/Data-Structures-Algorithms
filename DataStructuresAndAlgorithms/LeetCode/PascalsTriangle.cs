using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class PascalsTriangle
    {
        public IList<IList<int>> Generate(int numRows)
        {
            var list = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                var subList = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i) subList.Add(1);
                    else subList.Add(list[i - 1][j] + list[i - 1][j - 1]);
                }
                list.Add(subList);
            }
            return list;
        }
    }
}
