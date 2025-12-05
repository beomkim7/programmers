using System;using System.Linq;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
int length = targets.Length;
            int[] answer = new int[length];

            for(int i = 0; i < length; i++)
            {                
                for (int j = 0; j < targets[i].Length; j++)
                {
                    int min = int.MaxValue;
                    int num = 0;
                    for (int k = 0; k < keymap.Length; k++)
                    {
                        if (keymap[k].Contains(targets[i][j]))
                        {
                            num = keymap[k].IndexOf(targets[i][j]);
                            if (min > num) min = num;
                        }
                    }
                    answer[i] += min + 1;
                    if (min == int.MaxValue)
                    {
                        answer[i] = -1;
                        break;
                    }
                }     
                
            }

            return answer;
    }
}