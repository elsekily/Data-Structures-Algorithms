using System;
using System.Collections.Generic;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class FindCommonCharacters
    {
        public IList<string> CommonChars(string[] A)
        {
            var output = new List<string>();
            var listDict = new List<Dictionary<char, int>>();

            for (int i = 0; i < A.Length; i++)
            {
                listDict.Add(new Dictionary<char, int>());
                foreach (var c in A[i])
                {
                    if (listDict[i].ContainsKey(c)) listDict[i][c]++;
                    else listDict[i].Add(c, 1);
                }
            }

            foreach (var c in A[0])
            {
                var flag = true;
                foreach (var item in listDict)
                {
                    if (item.ContainsKey(c) && item[c] > 0) item[c]--;
                    else
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    output.Add(c.ToString());
            }

            return output;
        }
    }
}