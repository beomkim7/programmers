using System;
using System.Linq;
public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
            int[] answer = new int[targets.Length];

            for(int i = 0; i < targets.Length; i++)
            {
                for(int j = 0; j < targets[i].Length; j++)
                {                    
                    int min = int.MaxValue;
                    for(int z= 0; z < keymap.Length; z++)
                    {                        
                        if (keymap[z].Contains(targets[i][j]))
                        {
                            int cnt = keymap[z].IndexOf(targets[i][j]);
                            if(min > cnt) min = cnt;
                        }
                    }
                    if (min == int.MaxValue)
                    {
                        answer[i] = -1;
                        break;
                    }
                    else answer[i] += min + 1;
                }
            }

            return answer;
    }
}