using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution {
    public int[] solution(int[] numbers) {
            List<int> answer = new List<int>();
            
            for(int i = 0; i < numbers.Length -1 ; i++)
                for(int j = i+1; j < numbers.Length; j++)
                {
                    int num = numbers[i] + numbers[j];
                    if(!answer.Contains(num)) answer.Add(num);
                }

            answer = answer.OrderBy(x=>x).ToList();
            return answer.ToArray();
    }
}