using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
int[] answer = new int[4];
            int xMin = 0;
            int yMin = int.MaxValue;

            int xMax = 0;
            int yMax = 0;

            bool firstV = true;
            for(int i = 0; i <wallpaper.Length;i++)
            {
                int check = wallpaper[i].IndexOf('#');
                
                int yMaxcheck = wallpaper[i].LastIndexOf('#')+1;
                if (check == -1 && firstV)
                {
                    xMin++;                    
                }else firstV = false;
                if (check != -1 && check < yMin) yMin = check;
                if (check != -1) xMax = i+1;
                if (check != -1 && yMaxcheck > yMax) yMax = yMaxcheck;
            }

            answer[0] = xMin;
            answer[1] = yMin;
            answer[2] = xMax;
            answer[3] = yMax;

            return answer;
    }
}