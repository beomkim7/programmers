class Solution {
    public int solution(String s) {
        int answer = 0;
        boolean check = true ;
        
        for(int i = 0 ; i < s.length() ; i++){
            char ch = s.charAt(i);
            
            if(ch == '-'){
                check = false;
            }else if(ch !='+'){
                answer = answer * 10 + (ch - '0') ;
            }
        }
        
        return check?answer:-1 *answer;
    }
}