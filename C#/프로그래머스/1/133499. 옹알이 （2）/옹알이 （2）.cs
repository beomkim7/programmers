using System;

public class Solution {
    public int solution(string[] babbling) {
  int answer = 0;
    string[] canSay = { "aya", "ye", "woo", "ma" };

    foreach (string b in babbling)
    {
        string temp = b;
        string prev = "";
        bool isValid = true;

        while (temp.Length > 0)
        {
            bool matched = false;

            foreach (string word in canSay)
            {
                if (temp.StartsWith(word))
                {
                    if (prev == word) // 연속된 발음 금지
                    {
                        isValid = false;
                        break;
                    }

                    temp = temp.Substring(word.Length);
                    prev = word;
                    matched = true;
                    break;
                }
            }

            if (!matched || !isValid)
            {
                isValid = false;
                break;
            }
        }

        if (isValid)
            answer++;
    }

    return answer;
    }
}