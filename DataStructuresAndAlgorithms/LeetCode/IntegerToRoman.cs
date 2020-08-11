using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class IntegerToRoman
    {
        private Dictionary<int, char> valueSymbol;
        private Dictionary<int, int> placeValue;
        public IntegerToRoman()
        {
            valueSymbol = new Dictionary<int, char>
            {
                {1   ,'I'},
                {5   ,'V'},
                {10  ,'X'},
                {50  ,'L'},
                {100 ,'C'},
                {500 ,'D'},
                {1000,'M'}
            };
            placeValue = new Dictionary<int, int>
            {
                {0,1000 },
                {1,100 },
                {2,10 },
                {3,1 },
            };
        }

        public string InttoRoman(int num)
        {
            if (valueSymbol.ContainsKey(num))
                return valueSymbol[num].ToString();

            var strInt = num.ToString().PadLeft(4, '0');
            var output = new StringBuilder();

            for (int i = 0; i < strInt.Length; i++)
            {
                var digit = (strInt[i] - 48);
                if (digit == 0)
                    continue;

                if (digit < 5) LessThanFiveDigit(digit, output, i);

                if(digit == 5)
                    output.Append(valueSymbol[placeValue[i] * 5]);

                if (digit > 5 && digit != 9) 
                {
                    digit -= 5;
                    output.Append(valueSymbol[placeValue[i] * 5]);
                    LessThanFiveDigit(digit, output, i);
                }
                if(digit==9)
                {
                    output.Append(valueSymbol[placeValue[i]]);
                    output.Append(valueSymbol[placeValue[i-1]]);
                }
            }
            return output.ToString();
        }
        private void LessThanFiveDigit(int digit, StringBuilder output, int i)
        {
            var rem = digit % 5;
            if (rem <= 3)
            {
                while (rem-- > 0)
                    output.Append(valueSymbol[placeValue[i]]);
            }
            else
            {
                if (i == 3) output.Append(valueSymbol[1]);
                else output.Append(valueSymbol[placeValue[i]]);
                output.Append(valueSymbol[placeValue[i] * 5]);
            }
        }
    }
}