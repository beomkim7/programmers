class Solution {
    public int[][] solution(int n) {
        int[][] answer = new int [n][n];
        
        int num = 1 ;
        int start = 0 ;
        int end = n ;
        
        while(num <= n*n){
            for(int i = start ; i < end ; i++){
                answer[start][i]=num;
                num++;
            }
            
            for(int i = start+1 ; i < end ; i++){
                answer[i][end-1]=num;
                num++;
            }
            
            for(int i = end-2 ; i >= start ; i--){
                answer[end-1][i]=num;
                num++;
            }
            for(int i = end-2 ; i >= start+1 ; i--){
                answer[i][start]=num;
                num++;
            }
            start++;
            end--;
        }
            
        
        return answer;
    }
}