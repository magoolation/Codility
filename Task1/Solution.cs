using System;

namespace Task1
{
    class Solution
    {
        public int solution(int x)
        {
            int result = 0;
            string binary = Convert.ToString(x, 2);
            for(int i=0; i < binary.Length; i++)
            {
                int count = 0;
                if (binary[i] == '0')
                {
                    for(;i < binary.Length; i++)
                    {                        
                        if (binary[i] != '0')
                        {
                    if (count > result)
                    {
                        result = count;
                    }
                            break;
                        }
                            count++;
                    }
                }
            }

            return result;
        }
    }
}