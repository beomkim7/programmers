using System;

public class Solution {
public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
        {
            string answer = "";

            int len = toSecond(video_len);
            int now = toSecond(pos);
            int opS = toSecond(op_start);
            int opE = toSecond(op_end);

            now = now >= opS && now <= opE ? opE : now;

            foreach(string s in commands)
            {
                if (s == "next")
                {
                    now = Math.Min(now + 10, len);
                }
                else
                {
                    now = Math.Max(now - 10, 0);
                }
                now = now >= opS && now <= opE ? opE : now;
            }

            answer = ConverTime(now);

            return answer;
        }

        public int toSecond(string s)
        {
            string[] sArr = s.Split(':');

            return (int.Parse(sArr[0])*60) + int.Parse(sArr[1]);
        }
        public string ConverTime(int i)
        {
            return $"{i/60:D2}:{i%60:D2}";
        }
}