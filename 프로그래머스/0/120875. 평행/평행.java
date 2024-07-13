class Solution {
    // 두 점을 연결하는 직선의 기울기를 구하는 함수
    public double slope(int[] p1, int[] p2) {
        return (double)(p2[1] - p1[1]) / (p2[0] - p1[0]);
    }

    // 두 직선이 평행한지 확인하는 함수
    public boolean checkParallel(int[] p1, int[] p2, int[] p3, int[] p4) {
        return slope(p1, p2) == slope(p3, p4);
    }

    public int solution(int[][] dots) {
        // 세 가지 조합에 대해 평행 여부 확인
        if (checkParallel(dots[0], dots[1], dots[2], dots[3])) return 1;
        if (checkParallel(dots[0], dots[2], dots[1], dots[3])) return 1;
        if (checkParallel(dots[0], dots[3], dots[1], dots[2])) return 1;

        return 0;
    }
}
