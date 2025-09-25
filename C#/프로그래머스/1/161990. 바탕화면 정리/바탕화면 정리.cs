using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
int[] answer = new int[4];

            int answer1 = 0;
            int answer2 = int.MaxValue;
            int answer3 = 0;
            int answer4 = 0;

            foreach(string s in wallpaper)
            {
                if (s.Contains("#")) break;
                answer1++;
            }

            foreach(string s in wallpaper)
            {
                if (s.Contains("#"))
                {
                    int check = s.IndexOf('#');
                    if (answer2 > check) answer2 = check;
                    check = s.LastIndexOf("#");
                    if (answer4 <= check) answer4 = check + 1;
                }
            }

            for(int i = wallpaper.Length-1; i >= 0; i--)
            {
                if (wallpaper[i].Contains("#")) break;
                else answer3++;                
            }
            answer[0] = answer1;
            answer[1] = answer2;
            answer[2] = wallpaper.Length - answer3;
            answer[3] = answer4;

            return answer;
    }
}