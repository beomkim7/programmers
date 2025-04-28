using System;
using System.Text;
public class Solution {
    public string[] solution(string[] picture, int k) {
            string[] answer = new string[picture.Length*k];
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < picture.Length; i++)
            {
                for (int j = 0; j < picture[i].Length; j++) sb.Append(picture[i][j], k);
                for (int z = 0; z < k; z++) answer[i * k + z] = sb.ToString();
                sb.Clear();
            }

            return answer;
    }
}