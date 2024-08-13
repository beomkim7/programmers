class Solution {
    public int[][] solution(int n) {
        int[][] answer = new int[n][n];
        
        int left = 0;
        int right = n-1;
        int bottom = 0;
        int top = n-1;
        
        int num = 1;
        while(num<=n*n){
                for(int i = left ; i <= right; i++){
                    answer[left][i] = num;
                    num++;
                }
                bottom++;


                for(int i = bottom ; i <= top ; i++){
                    answer[i][top] = num;
                    num++;
                }
                top--;


                for(int i = right-1 ;i >= left ; i--){
                    answer[right][i] = num;
                    num++;
                }
                right--;


            for(int i = top ; i >= bottom; i--){
                answer[i][left] = num;
                num++;
            }
            left++;
        }   
        return answer;
    }
}