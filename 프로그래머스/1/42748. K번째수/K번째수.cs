using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
                        int length = commands.GetLength(0);
            int[] answer = new int[length];

            for(int i = 0 ;i < length ; i++)
            {
                int start = commands[i,0]-1;
                int end = commands[i,1]-1;
                int cnt = commands[i,2]-1;

                List<int> check = new List<int>();
                for(int j = start ; j <= end; j++)
                {
                    check.Add(array[j]);
                }
                check = check.OrderBy(x=>x).ToList();
                answer[i] = check[cnt];
            }
            return answer;
    }
}