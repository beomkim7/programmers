using System;

public class Solution {
public string solution(string video_len, string pos, string op_start, string op_end, string[] commands)
        {
            string answer = "";

            int len = ConvertToInt(video_len);
            int now = ConvertToInt(pos);
            int start = ConvertToInt(op_start);
            int end = ConvertToInt(op_end);

            if (now >= start && now < end) now = end;

            foreach (string s in commands)
            {
                if (s == "next")
                {
                    now += 10;
                    if (now > len) now = len;
                    if (now >= start && now < end) now = end;
                }
                else
                {
                    now -= 10;
                    if (now <0) now = 0;
                    if (now >= start && now < end) now = end;
                }
            }

            answer = ConvertToString(now);

            return answer;
        }

        public int ConvertToInt(string s)
        {
            string[] sArr = s.Split(':');

            return int.Parse(sArr[0]) * 60 + int.Parse(sArr[1]);
        }

        public string ConvertToString(int i)
        {
            string min = (i / 60).ToString().PadLeft(2, '0');
            string sec = (i % 60).ToString().PadLeft(2, '0');
            string s = min+sec ;
            return s.Insert(2, ":");
        }
}