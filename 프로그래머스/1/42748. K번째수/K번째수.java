import java.util.List;
import java.util.Collections;
import java.util.Arrays;
import java.util.ArrayList;
class Solution {
    public int[] solution(int[] array, int[][] commands) {
        int[] answer = new int[commands.length];
        
        for(int i = 0 ; i < commands.length ; i++){
            
            int[] rtArray = Arrays.copyOfRange(array,commands[i][0]-1,commands[i][1]);
            List<Integer> temp = new ArrayList<>();
            for(int num : rtArray){
                temp.add(num);
            }
            Collections.sort(temp);
            
            answer[i] = temp.get(commands[i][2]-1);
            
        }
        
        
        
        return answer;
    }
}