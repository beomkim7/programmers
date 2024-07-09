class Solution {
    public int solution(String[] babbling) {
        int answer = 0;
        
        String patturn = "^(aya||ye||woo||ma)+$";
        
        for(String b : babbling){
            if(b.matches(patturn)){
                answer ++;
            }
        }
        
        return answer;
    }
}