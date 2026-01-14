using System;
using System.Collections.Generic;
class Solution {
    public int solution(int[,] maps) {
            int answer = 0;

            int n = maps.GetLength(0);
            int m = maps.GetLength(1);

            int[] dx = { -1, 1, 0, 0 };
            int[] dy = {  0, 0, -1, 1 };

            Queue<int[]> que = new Queue<int[]> { };
            que.Enqueue(new int[]{ 0,0});

            while (que.Count > 0)
            {
                int[] check = que.Dequeue();

                int x = check[0];
                int y = check[1];

                for(int i = 0; i < 4; i++)
                {
                    int nx = x + dx[i];
                    int ny = y + dy[i];
                    if (nx >= 0 && nx < n && ny >= 0 && ny < m)
                        if(maps[nx,ny]==1)
                        {
                            maps[nx, ny] = maps[x,y]+1;
                            que.Enqueue(new int[] { nx, ny });
                        }
                }
            }
            answer = maps[n - 1, m - 1];

            return answer == 1 ? -1:answer;
    }
}