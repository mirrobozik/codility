using System;

namespace MiroBozik.Codility.BinaryGap
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("missing input number");
                Console.WriteLine("example: dotnet run 1041");
                return;
            }
            int inputNumber = Convert.ToInt32(args[0]);

            var solution = new Solution();

            var result = solution.solution(inputNumber);

            Console.WriteLine("RESULT: {0}", result);
        }
    }
}
