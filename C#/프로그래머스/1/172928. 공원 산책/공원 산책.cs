using System;

public class Solution {
    public int[] solution(string[] park, string[] routes) {
int[] answer = new int[2];

            int MaxGaro = park[0].Length-1;
            int MaxSero = park.Length-1;

            for(int i = 0; i < park.Length; i++)
            {
                if (park[i].Contains('S'))
                {
                    answer[0] = i;
                    answer[1] = park[i].IndexOf('S');
                }
            }

            for(int i = 0; i < routes.Length; i++)
            {
                string[] routeArr = routes[i].Split(' ');
                string direction = routeArr[0];
                int cnt = int.Parse(routeArr[1]);
                bool check = true;

                int nowGaro = answer[1];
                int nowSero = answer[0];
                switch (direction)
                {
                    case "E":
                        if (nowGaro + cnt > MaxGaro) break;
                        while (cnt > 0)
                        {
                            nowGaro++;
                            cnt--;
                            if (park[nowSero][nowGaro] == 'X')
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check) answer[1] = nowGaro;
                        break;
                    case "W":
                        if (nowGaro - cnt < 0) break;
                        while (cnt > 0)
                        {
                            nowGaro--;
                            cnt--;
                            if (park[nowSero][nowGaro] == 'X')
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check) answer[1] = nowGaro;
                        break;
                    case "S":
                        if (nowSero + cnt > MaxSero) break;
                        while (cnt > 0)
                        {
                            nowSero++;
                            cnt--;
                            if (park[nowSero][nowGaro] == 'X')
                            {
                                check = false;
                                break;
                            }
                        }
                        if (check) answer[0] = nowSero;
                        break;
                    case "N":
                        if (nowSero - cnt < 0) break;
                        while (cnt > 0)
                        {
                            nowSero--;
                            cnt--;
                            if (park[nowSero][nowGaro] == 'X')
                            {
                                check = false;
                                break;
                            }
                        }
                        if(check)answer[0] = nowSero;
                        break;

                }
            }

            return answer;
    }
}