using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class BackSpaceStringCompare
    {
        public bool BackspaceCompare(string S, string T)
        {
            var s = new StringBuilder();
            var t = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '#' && s.Length != 0)
                {
                    s.Remove(s.Length - 1, 1);
                    continue;
                }
                if(S[i]!='#')
                    s.Append(S[i]);

            }
            for (int i = 0; i < T.Length; i++)
            {
                if (T[i] == '#' && t.Length != 0) 
                {
                    t.Remove(t.Length - 1, 1);
                    continue;
                }
                if(T[i]!= '#')
                    t.Append(T[i]);
            }
            if (s.Length != t.Length)
                return false;

            for (int i = 0; i < s.Length; i++)
                if (s[i] != t[i])
                    return false;

            return true;
        }
    }
}