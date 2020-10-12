using System.Text;
namespace DataStructuresAndAlgorithms.LeetCode
{
    public class ReverseOnlyLetters
    {
        public string ReverseOnlyLettersSol(string S) 
        {
            var i = 0;
            var j = S.Length - 1;
            var output = new StringBuilder();

            while(j >= 0 && i < S.Length)
            {
                if(!IsLetter(S[i]))
                {
                    output.Append(S[i++]);
                    continue;
                }
                if(IsLetter(S[j]))
                {
                    output.Append(S[j--]);
                    i++;
                }
                else
                    j--;
            }
            while(i<S.Length)
                output.Append(S[i++]);

            return output.ToString();
        }
        private bool IsLetter(char character)
        {
            if((character >= 65 && character <= 90) || (character >= 97 && character <= 122))
                return true;
            
            return false;
        }
    }
}
