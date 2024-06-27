class Solution {
    public int solution(String s) {
        int answer = 0;
        
        int count = 0 ;
        char check = s.charAt(0);
        
        
        for(char c : s.toCharArray()){
            if(count == 0){
                check = c;
                answer++;
            }
            if(check == c){
                count++;
            }else{
                count--;
            }
            
        }
        
        return answer;
    }
}