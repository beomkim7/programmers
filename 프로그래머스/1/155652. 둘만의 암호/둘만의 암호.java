import java.util.List;
import java.util.ArrayList;
class Solution {
    public String solution(String s, String skip, int index) {
        char[] checks = s.toCharArray();
        char[] skips = skip.toCharArray();
        
        List<Character> ar = new ArrayList<>();
        
        for(int i = 0 ; i <= 25 ; i++){
            ar.add((char)(i+97));
        }
        
        for(char c : skips){
            ar.remove(Character.valueOf(c));
        }
        
        for(int i = 0 ; i < checks.length ; i++){
            int num = ar.indexOf(Character.valueOf(checks[i]))+index;
            num = num % ar.size();
            checks[i] = ar.get(num);
        }
        
        
        String answer = new String(checks);
        return answer;
    }
}