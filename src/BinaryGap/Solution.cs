using System;
using System.Linq;

namespace MiroBozik.Codility.BinaryGap
{
    public class Solution
    {
        public int solution(int input)
        {
            Console.WriteLine("input: {0}", input);
            var binary = Convert.ToString(input, 2);
            Console.WriteLine("input (binary): {0}", binary);
            binary = binary.TrimEnd('0');
            
            var gabs = binary.Split(new[] {'1'}, StringSplitOptions.RemoveEmptyEntries);
            if (gabs.Length == 0)
            {
                return 0;
            }
            var max = gabs.Select(g => g.Length).Max();
            return max;
        }
    }
}
