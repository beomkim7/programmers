using System;
using System.Linq;
public class Solution {
    public int[] solution(string s) {
int length = s.Length;
            int[] answer = new int[length];
            char[] check = new char[s.Length];

            for(int i = 0; i < length; i++)
            {                
                int num = 1;
                if (check.Contains(s[i]))
                    for (int j = i - 1; j >= 0; j--) 
                    {
                        if (s[i] == s[j])
                        {
                            answer[i] = num;
                            break;
                        }num++;
                    }
                else answer[i] = -1;
                check[i] = s[i];
            }

            return answer;
    }
}