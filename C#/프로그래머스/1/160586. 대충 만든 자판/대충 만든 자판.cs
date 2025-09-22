using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
 int[] answer = new int[targets.Length];

            for(int i = 0; i < targets.Length; i++)
            {                
                for(int j = 0; j < targets[i].Length; j++)
                {
                    int check = int.MaxValue;
                    foreach (string s in keymap)
                    {
                        int idx = s.IndexOf(targets[i][j]);
                        if (idx !=-1 && idx < check)
                        {
                            check = idx;                            
                        }
                    }
                    if (check == int.MaxValue)
                    {
                        answer[i] = -1;
                        break;
                    }
                    else answer[i] += check + 1;
                }
            }

            return answer;
    }
}