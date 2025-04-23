using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
public int solution(int a, int b, int c, int d)
{
    int[] nums = { a, b, c, d };
    var dict = nums.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count());

    switch (dict.Count)
    {
        case 1:
            return 1111 * dict.Keys.First();
        case 2:
            if (dict.Values.Max() == 3)
            {
                int p = dict.First(x => x.Value == 3).Key;
                int q = dict.First(x => x.Value == 1).Key;
                return (int)Math.Pow(10 * p + q, 2);
            }
            else
            {
                var keys = dict.Keys.ToArray();
                return (keys[0] + keys[1]) * Math.Abs(keys[0] - keys[1]);
            }
        case 3:
            return dict.Where(x => x.Value == 1).Select(x => x.Key).Aggregate(1, (acc, x) => acc * x);
        case 4:
            return dict.Keys.Min();
    }

    return 0; // fallback (should never happen)
}

}