import java.util.*;
class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        
        int real = 0 ;
        int zero = 0 ;
        Map <Integer,Boolean> num = new HashMap<>();
        
        for(int i = 0 ; i < lottos.length ; i++){
            if(lottos[i] == 0){
                zero++;
                continue;
            }
            num.put(lottos[i],true);
        }
        
        for(int i = 0 ; i < win_nums.length ; i++){
            if(num.containsKey(win_nums[i])){
                real++;
            }
        }
        int maxnum = Math.min(6,7 - (real+zero));
        int minnum = Math.min(6,7 - real);
        
        int[] answer = {maxnum,minnum};
        
        return answer;
    }
}