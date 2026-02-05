using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
int[] answer = new int[4];

            int start = 0;
            int second = int.MaxValue;
            int third = 0;
            int forth = 0;

            for (int i = 0; i < wallpaper.Length; i++)            
                if (wallpaper[i].Contains("#"))
                {
                    start = i;
                    break;
                }

            for(int i = 0; i < wallpaper.Length; i++)
            {
                int check = int.MaxValue;
                int check2 = 0;
                if (wallpaper[i].Contains("#"))
                {
                    check = wallpaper[i].IndexOf("#");
                    check2 = wallpaper[i].LastIndexOf("#");
                }
                if (second > check) second = check;
                if (forth < check2) forth = check2;
                

            }
forth += 1;
            for (int i = wallpaper.Length - 1; i >= 0; i--) 
                if (wallpaper[i].Contains("#"))
                {
                    third = i+1;
                    break;
                }
            answer[0] = start;
            answer[1] = second;
            answer[2] = third;
            answer[3] = forth;

            return answer;
    }
}