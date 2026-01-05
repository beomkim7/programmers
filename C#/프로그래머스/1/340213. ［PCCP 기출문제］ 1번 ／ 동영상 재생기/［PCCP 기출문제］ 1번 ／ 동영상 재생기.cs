using System;

public class Solution {
    public string solution(string video_len, string pos, string op_start, string op_end, string[] commands) {
        string answer = "";
            int len = ConvertStToInt(video_len);
            int i_pos = ConvertStToInt(pos);
            int i_start = ConvertStToInt(op_start);
            int i_end = ConvertStToInt(op_end);

            if (i_pos >= i_start && i_pos <= i_end) i_pos = i_end;
if (i_pos >= len) i_pos = len;
            foreach(string s in commands)
            {
                                if(s == "next") i_pos += 10;                
                else i_pos -= 10;

                if (i_pos < 0) i_pos = 0;
                if (i_pos > len) i_pos = len;

                if (i_pos >= i_start && i_pos <= i_end) i_pos = i_end;
            }
            answer = ConvertToString(i_pos);
            return answer;
        }

        public int ConvertStToInt(string s)
        {
            string[] sArr = s.Split(':');
            int i = int.Parse(sArr[0]) * 60 + int.Parse(sArr[1]);
            return i;
        }

        public string ConvertToString(int i)
        {
            string st = (i / 60).ToString().PadLeft(2, '0') + (i % 60).ToString().PadLeft(2, '0');
            st = st.Insert(2, ":");
            return st;
        }
}