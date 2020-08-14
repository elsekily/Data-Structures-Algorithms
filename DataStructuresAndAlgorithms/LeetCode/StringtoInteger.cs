using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithms.LeetCode
{
    public class StringtoInteger
    {
        public int MyAtoi(string str)
        {
            var myStr = str.TrimStart();
            
            if (myStr.Length == 0)
                return 0;

            var num = 0;
            var digits = 0;
            var sign = 1;
            
            if (!IsDigitOrSign(myStr[0]))
                return 0;

            foreach (var digit in myStr)
            {
                if ((digits == 0) && (digit == '-'))
                    sign = -1;

                if (!(digit >= 48 && digit < 58) && digits != 0)
                    break;

                checked
                {
                    try
                    {
                        if (digit >= 48 && digit < 58)
                            num = (num * 10) + (digit - 48);
                    }
                    catch
                    {
                        if(sign == 1) return int.MaxValue;
                        return int.MinValue;
                    }
                }
                digits++;
            }
            return num * sign;
        }
        private bool IsDigitOrSign(char x)
        {
            if ((x >= 48 && x < 58) || x == '+' || x == '-')
                return true;
            return false;
        }
    }
}
