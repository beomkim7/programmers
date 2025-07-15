using System;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
int length = targets.Length;
            int[] answer = new int[length];

            for(int i = 0; i < length; i++)
            {
                int sum = 0;                
                for(int j = 0; j < targets[i].Length; j++)//["ABACD", "BCEFD"]	["ABCD","AABB"]
                {
                    char c = targets[i][j];
                    int minV = int.MaxValue;
                    foreach(string st in keymap)
                    {
                        int inV = st.IndexOf(c);
                        if (inV != -1)
                        {                            
                            minV = Math.Min(minV, inV+1);
                        }
                    }
                    if (minV == int.MaxValue)
                    {
                        sum = -1;
                        break;
                    }
                    sum += minV; 
                }
                answer[i] = sum;
            }
            return answer;
    }
}