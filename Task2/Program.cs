using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            int[] test = new int[] { 1, 2, 3, 4 };

Print(solution.solution(test, 1));
            Print(solution.solution(test, 2));
            Print(solution.solution(test, 3));
Print(solution.solution(test, 4));
Print(solution.solution(test, 5));
Print(solution.solution(test, 8));
Print(solution.solution(test, 10));
Print(solution.solution(test, 256));
    }

    private static void Print(int[] a)
    {
        foreach(var item in a)
        {
            Console.Write(item);
        }
        Console.WriteLine();
    }
}
}