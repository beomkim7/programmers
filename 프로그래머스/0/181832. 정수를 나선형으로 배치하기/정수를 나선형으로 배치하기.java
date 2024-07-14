class Solution {
    public int[][] solution(int n) {
        int[][] answer = new int[n][n];
        
        int left = n ; int right = 0 ; int top = 0 ; int bottom = n ;
        int num = 1 ;
        int lastNum = (int)Math.pow(n,2);
        System.out.println(lastNum);
        while(num <= lastNum){
            for(int i = top ; i < bottom ; i++){
                answer[top][i] = num;
                num++;
            }
            bottom--;
            
            for(int i = right+1 ; i < left ; i++){
                answer[i][bottom] = num;
                num++;
            }
            right++;
            
            if(right<=left){
                for(int i = bottom-1 ; i >= top ; i--){
                    answer[bottom][i] = num;
                    num++;
                }
                top++;
                
            }
            if(top<=bottom){
                for(int i = left-2 ; i >= right ; i--){
                    answer[i][right-1]= num;
                    num++;
                }
                left--;
            }
            
        }
        return answer;
    }
}