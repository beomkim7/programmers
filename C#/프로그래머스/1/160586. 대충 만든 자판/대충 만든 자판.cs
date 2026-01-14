using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
            int[] answer = new int[targets.Length];

            for(int i = 0; i < targets.Length; i++)
            {
                for(int j = 0; j < targets[i].Length; j++)
                {
                    List<int> check = new List<int>();
                    for(int z = 0; z < keymap.Length; z++)
                    {
                        if (keymap[z].Contains(targets[i][j]))
                            check.Add(keymap[z].IndexOf(targets[i][j])+1);
                    }
if (check.Count == 0)
                    {
                        answer[i] = -1;
                        break;
                    }
                    else answer[i] += check.Min();
                }
            }

            return answer;
    }
}