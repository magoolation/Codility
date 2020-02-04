using System;

namespace Task3
{

class Solution
{
    public int solution(int[] A)
    {
        int current = 0;
        if (A.Length > 0)
        {
        Array.Sort(A);
    int count = 1;
                current = A[0];
        for(int i=1; i< A.Length; i++)
        {
            if (A[i] != current)
            {
                if (count % 2 != 0)
                {
                    return current;
                }
                count = 0;
                current = A[i];            
            }
            count++;
    }
        }
        
        return current;
    }
}
}