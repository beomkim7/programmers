using System;

public class Solution {
    public int[] solution(string[] wallpaper) {
            int[] answer = new int[4];
            int answer1 = 0;
            int answer2 = int.MaxValue;
            int answer3 = 0;
            int answer4 = 0;
            bool Fcheck = true;

            while (Fcheck)
            {
                foreach(string s in wallpaper)
                {
                    if (s.IndexOf("#") == -1) answer1++;
                    else 
                    {
                        Fcheck = false;
                        break;
                    }
                    
                }
            }

            while (true)
            {
                int check = 0;
                foreach (string s in wallpaper)
                {                    
                    if (s.Contains("#"))
                    {
                        check = s.IndexOf('#');
                        if (answer2 > check) answer2 = check;
                        check = s.LastIndexOf('#');
                        if (answer4 <= check) answer4 = check + 1;
                    }                    
                }
                break;
            }

            int value3 = 0;
            for(int i = wallpaper.Length - 1; i >= 0; i--)
            {
                if (wallpaper[i].Contains("#")) break;                
                else value3++;
            }


            answer[0] = answer1;
            answer[1] = answer2;
            answer[2] = wallpaper.Length - value3;
            answer[3] = answer4;
            

            return answer;
    }
}