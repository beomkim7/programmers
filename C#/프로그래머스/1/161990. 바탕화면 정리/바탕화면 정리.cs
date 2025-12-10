using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
        int[] answer = new int[4];

            int minX = int.MaxValue;
            int minY = int.MaxValue;

            int maxX = 0;
            int maxY = 0;

            for(int i = 0; i < wallpaper.Length; i++)
            {
                int start = wallpaper[i].IndexOf('#');
                int end = wallpaper[i].LastIndexOf('#');

                if(start != -1)
                {
                    minX = Math.Min(minX, i);
                    minY = Math.Min(minY, start);

                    maxX = Math.Max(maxX, i + 1);
                    maxY = Math.Max(maxY, end + 1);
                }
            }

            answer[0] = minX;
            answer[1] = minY;
            answer[2] = maxX;
            answer[3] = maxY;

            return answer;
    }
}