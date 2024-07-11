class Solution {
    public int[][] solution(int n) {
        int[][] answer = new int [n][n];
        int num = 1 ;
        int right = 0 ; int left = n-1 ; int top = 0 ;int bottom = n-1;
        
        while(num <= n*n){
            for(int i = right ; i <= left ; i++){
                answer[top][i] = num;
                num++;
            }
            top++;
            
            for(int i = top ; i <= left ; i++){
                answer[i][left] = num;
                num++;
            }
            left--;
            if(right<=left){
                for(int i = left ; i >= right ; i--){
                    answer[bottom][i] =num;
                    num++;
                }
                bottom--;
            }
            
            if(top<=bottom){
                for(int i = bottom ; i >= top ; i--){
                    answer[i][right] = num;
                    num++;
                }
                right++;
            }
            
            
        }
        
        return answer;
    }
}