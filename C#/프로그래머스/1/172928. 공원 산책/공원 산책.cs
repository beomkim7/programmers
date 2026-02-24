using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
int[] answer = new int[2];

            int x = 0, y = 0;

            int maxX = park[0].Length;
            int maxY = park.Length;

            for(int i = 0; i < park.Length;i++)
            {
                if (park[i].Contains("S")) 
                {
                    y = park[i].IndexOf("S");
                    x = i;
                }
            }
            
            foreach(string s in routes)
            {
                string[] sArr = s.Split(' ');
                string direct = sArr[0];
                int count = int.Parse(sArr[1]);

                int dx = x;
                int dy = y;
                bool check = true;

                switch (direct)
                {
                    case "E":
                        for(int i = 0; i < count; i++)
                        {
                            ++dy;
                            if (dy < maxX && park[x][dy] != 'X') continue;
                            else 
                            {
                                dy--;
                                check = !check;
                                break; 
                            }
                        }
                        if (check) y = dy;
                        break;
                    case "W":
                        for (int i = 0; i < count; i++)
                        {
                            --dy;
                            if (dy >= 0 && park[x][dy] != 'X') continue;
                            else
                            {
                                dy++;
                                check = !check;
                                break;
                            }
                        }
                        if (check) y = dy;
                        break;

                    case "S":
                        for (int i = 0; i < count; i++)
                        {
                            ++dx;
                            if (dx < maxY && park[dx][y] != 'X') continue;
                            else
                            {
                                dx--;
                                check = !check;
                                break;
                            }
                        }
                        if (check) x = dx;
                        break;
                    case "N":
                        for (int i = 0; i < count; i++)
                        {
                            --dx;
                            if (dx >= 0 && park[dx][y] != 'X') continue;
                            else
                            {
                                dx++;
                                check = !check;
                                break;
                            }
                        }
                        if (check) x = dx;
                        break;
                }
            }
            answer[0] = x;
            answer[1] = y;
            return answer;
    }
}