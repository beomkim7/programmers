class Solution {
    public int solution(int[][] lines) {
        int answer = 0;
        int[] check = new int [201];
        
        for(int[] line : lines){
            int start = line[0]+100;
            int end = line[1]+100;
            
            for(int i = start ; i < end ; i++){
                check[i] +=1;
            }
        }
       
        for(int i = 0 ; i < check.length ; i++){
            if(check[i]>1){
                answer++;
            }
        }
        
        return answer;
    }
}