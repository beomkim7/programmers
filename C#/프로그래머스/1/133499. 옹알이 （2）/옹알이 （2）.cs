using System;

public class Solution {
    public int solution(string[] babbling) {
int answer = 0;
            string[] checkArr = new string[] { "aya", "ye", "woo", "ma" };
            
            
            foreach (string s in babbling)
            {
                string prev = "";
                string temp = s;
                bool possible = true;

                while (temp.Length > 0)
                {
                    bool matched = false;
                    foreach(string st in checkArr)
                    {
                        if (temp.StartsWith(st))
                        {
                            if(prev == st)
                            {
                                possible = false;
                                break;
                            }
                            prev = st;
                            temp = temp.Substring(st.Length);
                            matched = true;
                            break;
                        }
                    }

                    if (!matched)
                    {
                        possible = false;
                        break;
                    }
                }
                if (possible) answer++;

            }


            return answer;
    }
}