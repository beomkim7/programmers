import java.util.*;
class Solution {
    public int solution(String[] babbling) {
        int answer = 0;
        
        String check = "^(aya|ye|woo|ma)+$";
        
        for(int i = 0 ; i < babbling.length ; i++){
            if(babbling[i].matches(check)){
                //Pattern.matches(REGEXP_PATTERN_CHAR, str1);
                answer++;
            }
        }
        
        return answer;
    }
}