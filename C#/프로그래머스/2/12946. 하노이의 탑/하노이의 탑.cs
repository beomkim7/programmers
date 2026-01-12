using System;
using System.Collections.Generic;
public class Solution {
List<int[]> moveList = new List<int[]>();

    public int[][] solution(int n) {
        // n개를 1번 기둥(from)에서 3번 기둥(to)으로, 2번(via)을 거쳐서 이동
        Hanoi(n, 1, 3, 2);
        return moveList.ToArray();
    }

    private void Hanoi(int n, int from, int to, int via) {
        // 원판이 1개뿐이라면 그냥 바로 목적지로 옮기면 끝
        if (n == 1) {
            moveList.Add(new int[] { from, to });
            return;
        }

        // 1단계: 맨 아래 큰 거 하나 빼고, 나머지 (n-1)개를 경유지(via)로 치움
        Hanoi(n - 1, from, via, to);

        // 2단계: 맨 아래 있던 큰 원판을 목적지로 옮김 (기록)
        moveList.Add(new int[] { from, to });

        // 3단계: 경유지에 치워뒀던 (n-1)개를 다시 목적지(to)로 가져옴
        Hanoi(n - 1, via, to, from);
    }
}