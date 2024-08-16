class Solution {
    public int solution(int[][] board) {
        int answer = 0;
        
        int[][] check = new int[board.length][board.length];
        
        for(int i = 0 ; i < board.length ; i++){
            for(int j = 0 ; j < board[i].length;j++){
                
                check[i][j] = board[i][j];
                
            }
        }
        
        for(int i = 0 ; i < board.length ; i++){
            for(int j = 0 ; j < board[i].length;j++){
                if(board[i][j]==1){
                    for(int k = -1 ; k <= 1 ; k++){
                        for(int z = -1 ; z <=1 ; z++){
                            int row = i+k;
                            int col = j+z;
                            if(row>=0 && row<board.length && col>=0 && col<board.length){
                                check[row][col] +=1;
                            }
                        }
                    }
                }                  
            }
        }
        
        for(int i = 0 ; i < check.length ; i++){
            for(int j = 0 ; j < check[i].length;j++){
                if(check[i][j]==0){
                    answer++;
                }
            }
        }
        
        
        return answer;
    }
}