using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CensusProgrammingPuzzle
{
    class Calc
    {

        public List<int> ThisIsIt(List<int> census)
        {
            var limit = 100000000;
            var subset = new List<int>();
            var holder = 0;
            foreach (var c in census)
            {
                holder += c;
                subset.Add(c);
                if (holder > limit)
                {
                    holder -= c;
                    subset.Remove(c);
                }

            }
            return subset;
        }

        static int[] arr = { 18897109, 12828837, 9461105, 6371773, 5965343, 5946800, 5582170, 5564635, 5268860, 4552402,
                4335391, 4296250, 4224851, 4192887, 3439809, 3279833, 3095313, 2812896, 2783243, 2710489,
                2543482, 2356285, 2226009, 2149127, 2142508, 2134411};
        // target sum
        static int sum = 100000000;

        static void CheckAllCombinations(int[] subarray, int depth)
        {
            //Console.ReadKey();
            for (int i = depth; i < arr.Length; i++)
            {
                subarray[depth] = arr[i];
                Console.WriteLine("depth = {0}, i = {1}, array = '{2}'  ", depth, i, string.Join(",", subarray.Select(x => x.ToString()).ToArray()));
                int currentSum = subarray.Take(depth + 1).Sum();
                if (currentSum == sum)
                {
                    Console.Write("S = {0} -> yes : ", sum);
                    Console.WriteLine(string.Join(",", subarray.Take(depth + 1)));
                }
                //PrintArray(subarray);
                //Console.ReadKey();
                if (currentSum < sum)
                {
                    CheckAllCombinations(subarray, depth + 1);
                }
            }
        }
    }
}
