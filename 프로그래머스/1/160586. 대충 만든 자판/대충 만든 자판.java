import java.util.Set;
import java.util.Arrays;
import java.util.HashSet;
class Solution {
    public int[] solution(String[] keymap, String[] targets) {
        int[] answer = new int [targets.length];
        
        Set <String> spell = new HashSet<>(Arrays.asList(keymap));
        spell.remove("");
        
        for(int i = 0 ; i < targets.length ; i++){
            for(int j = 0 ; j < targets[i].length() ; j++){
                int check = Integer.MAX_VALUE;
                for(String s : spell){
                    int num = s.indexOf(targets[i].charAt(j));
                    
                    if(num == -1)continue;
                    else if(num < check)check = num+1 ;                      
                    
                }
                if(check == Integer.MAX_VALUE){
                    answer[i] = -1;
                    break;
                }else{
                    answer[i] +=check;
                }
            }
        }
        
        return answer;
    }
}