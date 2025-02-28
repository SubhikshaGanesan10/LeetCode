using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter array:");
            int[] nums = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

            Console.WriteLine("Enter the target value:");
            int target = int.Parse(Console.ReadLine());

            int[] result = TwoSum(nums, target);

            Console.WriteLine("Indices: " + string.Join(", ", result));
            Console.ReadLine();

        }

        public static int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; ; i++)
            {
                int x = nums[i];
                int y = target - x;
                if (dict.ContainsKey(y))
                {
                    return new int[] { dict[y], i };
                }
                dict[x] = i;

            }

        }
    }
}
