class Solution {
    public int solution(String[] babbling) {
        int answer = 0;
        
        for(String ch : babbling){
            ch = ch.replace("aya"," ");
            ch = ch.replace("ye"," ");
            ch = ch.replace("woo"," ");
            ch = ch.replace("ma"," ");
            ch = ch.trim();
            
            if(ch.equals("")){
                answer += 1;
                
            }
            
        }
        
        return answer;
    }
}