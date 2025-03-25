using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public long solution(string numbers) {
            long answer = 0;
            string[] checkArr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            Dictionary<string, int> dict = checkArr
                                        .Select((key, index) => new { key, index })
                                        .ToDictionary(x => x.key, x => x.index);

            foreach (var pair in dict)
                numbers = numbers.Replace(pair.Key, pair.Value.ToString());
            return long.Parse(numbers);
    }
}