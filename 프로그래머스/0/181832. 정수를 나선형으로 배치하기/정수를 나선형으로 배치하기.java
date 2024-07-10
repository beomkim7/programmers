class Solution {
    public int[][] solution(int n) {
        int[][] answer = new int [n][n];
        
        int num = 1 ;
        int left = 0 , right = n-1 , top = 0 , bottom = n-1;
        while(left <= right && top <= bottom){
            for(int i = left ; i <= right ; i++){
                answer[top][i]=num;
                num++;                
            }
            top++;
            
            for(int i = top ; i <= bottom ; i++){
                answer[i][bottom]=num;
                num++;
            }
            bottom--;
            if(top <= bottom){
                for(int i = bottom ; i >= left ;i--){
                    answer[right][i]=num;
                    num++;
                }
                right--;
            }
            if(left <= right){
                for(int i = bottom ; i >= top ; i--){
                    answer[i][left]=num;
                    num++;
                }
                left++;
            if(left == right){
                answer[top][bottom]=num;
                break;
                }
            }
        }
        
        return answer;
    }
}