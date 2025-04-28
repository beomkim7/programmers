using System;
using System.Linq;
public class Solution {
    public int solution(int[] rank, bool[] attendance) {
            var dict = rank.Select((value,index)=>new {value=value,index=index })
                .Where(x => attendance[x.index])
                .OrderBy(x=>x.value);

            int answer = dict.ElementAt(0).index * 10000 + dict.ElementAt(1).index * 100 + dict.ElementAt(2).index;
            return answer;
    }
}