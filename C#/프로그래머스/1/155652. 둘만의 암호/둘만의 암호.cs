using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public string solution(string s, string skip, int index) {
    string answer = "";
    HashSet<char> skipSet = new HashSet<char>(skip);

    foreach (char ch in s)
    {
        char c = ch;
        int count = 0;

        while (count < index)
        {
            c++;
            if (c > 'z') c = 'a';

            if (!skipSet.Contains(c))
                count++;
        }

        answer += c;
    }

    return answer;
    }
}