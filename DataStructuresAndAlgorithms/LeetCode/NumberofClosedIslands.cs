namespace DataStructuresAndAlgorithms.LeetCode
{
    public class NumberofClosedIslands
    {
        public int ClosedIsland(int[][] grid) 
        {
            int count = 0;
            bool isCorner = false;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 0)
                    {
                        CheckPoint(grid, i, j, ref isCorner);
                        if (isCorner)
                            isCorner = false;
                        else
                            count++;
                    }
                }
            }
            return count;
        }
        private void CheckPoint(int[][] grid,int i,int j, ref bool corner)
        { 
            if (i < 0 || i >= grid.Length || j < 0 || j >= grid[i].Length || grid[i][j] == 1)
                return;

            if ((i == 0 || i == grid.Length - 1 || j == 0 || j == grid[i].Length - 1) && grid[i][j] == 0)
                corner = true;

            grid[i][j] = 1;
            CheckPoint(grid, i, j + 1, ref corner);
            CheckPoint(grid, i, j - 1, ref corner);
            CheckPoint(grid, i + 1, j, ref corner);
            CheckPoint(grid, i - 1, j, ref corner);
        }
    }
}