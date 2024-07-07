class Solution {
    public long[] solution(int x, int n) {
        long[] answer = new long[n];
        
        for(int i = 1,j = 0 ; i <= n ; i++,j++){
            answer[j] = (long)x*i;
        }
        return answer;
    }
}