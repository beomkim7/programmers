using System;

public class Solution {
    public int solution(string[] babbling) {
int answer = 0;
            string[] stArr = new string[] { "aya", "ye", "woo", "ma" };

            for(int i = 0; i < babbling.Length; i++)
            {
                string temp = babbling[i];
                bool isVal = true;
                string prev = "";

                while (temp.Length > 0)
                {                    
                    bool matched = false;

                    foreach(string st in stArr)
                    {
                        if (temp.StartsWith(st))
                        {
                            if(prev == st)
                            {
                                isVal = false;
                                break;
                            }

                            temp = temp.Substring(st.Length);
                            prev = st;
                            matched = true;
                            break;
                        }
                    }
                    if (!isVal || !matched)
                    {
                        isVal = false;
                        break;
                    }
                }
                if (isVal) answer++;
            }

            return answer;
    }
}