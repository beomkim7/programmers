class Solution {
    public int solution(int[][] lines) {
        int answer = 0;
        int [] temp = new int [201];
        for(int[] ch : lines){
            int start = ch[0]+100;
            int end = ch[1]+100;
            for(int i = start ; i < end ; i++){
                temp[i] +=1;                
            }            
        }
        
        for( int i = 0 ; i < temp.length ; i++){
            if(temp[i]>1){
                answer +=1;
            }
        }
        
        return answer;
    }
}