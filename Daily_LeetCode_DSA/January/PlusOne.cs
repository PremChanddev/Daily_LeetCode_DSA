using System;
using System.Collections.Generic;
using System.Text;

namespace Daily_LeetCode_DSA.January
{
    internal class PlusOne
    {
        public static int[] PlusOneMethod(int[] digits)
        {
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                if (digits[i] < 9)
                {
                    digits[i]++;
                    return digits;
                }
                digits[i] = 0;
            }
            int[] newNumber = new int[digits.Length + 1];
            newNumber[0] = 1;
            return newNumber;
        }
    }
}
