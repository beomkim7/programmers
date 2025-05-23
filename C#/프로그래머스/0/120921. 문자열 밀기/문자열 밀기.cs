using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(string A, string B)         {
            int answer = 0;
            if (A == B) 
                return answer;
            while (answer < A.Length)
            {
                
                List<char> index = A.ToCharArray().ToList();
                char save = index[A.Length - 1];
                index.RemoveAt(A.Length - 1);
                index.Insert(0, save);
                A = new string(index.ToArray());
                answer++;
                if (A == B) break;

            }
        if (A != B) answer = -1;
            return answer;
        }
}