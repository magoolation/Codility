using System;

namespace Task2
{
class Solution
{
    public int[] solution(int[] N, int K)
    {
        if (K <= 0 || (K > N.Length && N.Length % K == 0))
        {
            return N;
        }

        if (K > N.Length)
        {
            K = K % N.Length;
        }

        int[] result = new int[N.Length];
        Array.Copy(N, result, N.Length);

        Array.Copy(N, N.Length-K, result, 0, K);
            Array.Copy(N, 0, result, K, N.Length - K);

        return result;
    }
}
}