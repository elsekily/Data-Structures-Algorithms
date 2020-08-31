using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    class LongestCommonPrefix
    {
        public string MyLongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0 || strs == null)
                return "";

            var output = new StringBuilder();
            output.Append(strs[0]);
            for (int i = 1; i < strs.Length && output.Length != 0; i++)
            {
                if(strs[i].Length < output.Length)
                    output.Remove(strs[i].Length, output.Length - strs[i].Length);

                for (int j = 0; j < output.Length; j++)
                {
                    if (output[j] != strs[i][j])
                    {
                        output.Remove(j, output.Length - j);
                        break;
                    }
                }
            }
      
            return output.ToString();
        }
    }
}
