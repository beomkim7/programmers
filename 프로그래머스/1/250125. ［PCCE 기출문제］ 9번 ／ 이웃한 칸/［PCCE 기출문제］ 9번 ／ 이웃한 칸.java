class Solution {
    public int solution(String[][] board, int h, int w) {
        int answer = 0;

        String now = board[h][w];
        
        int[] dh = {0,1,-1,0};
        int[] dw = {1,0,0,-1};
        
        int maxh = board.length;
        
        for(int i = 0 ; i<dh.length ; i++){
            int nh = dh[i]+h;
            int nw = dw[i]+w;
            if( nh>=0 && nw>=0 && nh < board.length && nw < board.length && now.equals(board[nh][nw])){
                answer++;
            }
        }
        
        return answer;
    }
}