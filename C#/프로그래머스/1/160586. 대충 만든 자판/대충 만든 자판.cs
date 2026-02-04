using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
 int[] answer = new int[targets.Length];

            for(int i = 0;i < targets.Length;i++)
            {
                foreach(char c in targets[i])
                {
                    List<int> keyLst = new List<int>();
                    for(int j = 0;j < keymap.Length; j++)
                    {
                        int index = keymap[j].IndexOf(c);
                        if (index != -1)
                        {
                            keyLst.Add(index + 1);
                        }
                    }
                    if (keyLst.Count == 0)
                    {
                        answer[i] = -1;
                        break;
                    }
                    else answer[i] += keyLst.Min();
                }
            }

            return answer;
    }
}