using System;using System.Collections.Generic;using System.Text;

public class Solution {
    public string[] solution(string[] picture, int k) {
            List<string> answer = new List<string>();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < picture.Length; i++)
            {
                for (int j = 0; j < picture[i].Length; j++)
                    for (int z = 0; z < k; z++)
                        sb.Append(picture[i][j]);

                for(int q = 0; q <k;q++)
                    answer.Add(sb.ToString());

                sb.Clear();
            }


            return answer.ToArray();
    }
}