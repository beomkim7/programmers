class Solution {
    public int solution(String s) {
        int answer = 0;
        char spell = '\0';
        int count = 0 ;
        
        for(char ch : s.toCharArray()){
            if(count == 0){
                spell = ch;
            }
            
            if(spell == ch){
                count++;
            }else{
                count--;
            }
            
            if(count == 0){
                answer++;
            }
            
        }
        
        if(count > 0){
            answer++;
        }
        
        return answer;
    }
}