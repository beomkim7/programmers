using System;
using System.Collections.Generic;

class Solution {
    public int solution(int[,] maps) {
        int n = maps.GetLength(0); // 행 크기
        int m = maps.GetLength(1); // 열 크기
        
        // 이동할 상하좌우 방향 정의 (dx: 행, dy: 열)
        int[] dx = { -1, 1, 0, 0 };
        int[] dy = { 0, 0, -1, 1 };
        
        // BFS를 위한 큐 생성 (int 배열로 x, y 좌표 저장)
        Queue<int[]> queue = new Queue<int[]>();
        
        // 시작점 (0, 0) 추가
        queue.Enqueue(new int[] { 0, 0 });
        
        while (queue.Count > 0) {
            int[] current = queue.Dequeue();
            int x = current[0];
            int y = current[1];
            
            // 4방향 탐색
            for (int i = 0; i < 4; i++) {
                int nx = x + dx[i];
                int ny = y + dy[i];
                
                // 1. 맵 범위 안에 있는지 확인
                if (nx >= 0 && nx < n && ny >= 0 && ny < m) {
                    // 2. 갈 수 있는 길(1)인지 확인
                    if (maps[nx, ny] == 1) {
                        // 이전 칸의 거리 + 1을 현재 칸에 저장
                        maps[nx, ny] = maps[x, y] + 1;
                        queue.Enqueue(new int[] { nx, ny });
                    }
                }
            }
        }
        
        // 상대 팀 진영(n-1, m-1)의 값 확인
        int answer = maps[n - 1, m - 1];
        
        // 도달하지 못한 경우(처음 값인 1 그대로인 경우) -1 반환
        return answer == 1 ? -1 : answer;
    }
}