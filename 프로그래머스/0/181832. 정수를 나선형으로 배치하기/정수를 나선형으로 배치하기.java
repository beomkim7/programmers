class Solution {
    public int[][] solution(int n) {
        int[][] answer = new int [n][n];
        
        int start = 0;
        int end = n ;
        
        int num = 1;
        
        while(num <=n*n){
            for(int i = start ; i < end ; i++)answer[start][i]=num++;
            
            for(int i = start+1 ; i < end ; i++)answer[i][end-1]=num++;
            
            for(int i = end-2 ; i >= start ; i--)answer[end-1][i]=num++;
            
            for(int i = end-2; i >= start+1 ; i--)answer[i][start]=num++;
            start++;
            end--;
        }
        
        return answer;
    }
}