using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();

            System.Console.WriteLine(solution.solution(new int[] {9,3,7,3,9}));
            System.Console.WriteLine(solution.solution(new int[] {9}));
            System.Console.WriteLine(solution.solution(new int[] {} ));
        }
    }
}
