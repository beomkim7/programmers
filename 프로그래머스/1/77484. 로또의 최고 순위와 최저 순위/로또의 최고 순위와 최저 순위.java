import java.util.ArrayList;
import java.util.List;
class Solution {
    public List<Integer> solution(int[] lottos, int[] win_nums) {
        
        int match = 7;
        int luck = 7;
        List<Integer> answer = new ArrayList<>();
        
        for(int i = 0 ; i < lottos.length ; i++){
            for(int j =0 ; j < win_nums.length ; j++){
                if(lottos[i] == win_nums[j]){
                    match--;
                    luck--;
                    continue;
                }
            }
            if(lottos[i] == 0){
                luck--;
            }
        }
        
        if(match == 7){
            match = 6;
        }
        if(luck == 7){
            luck = 6;
        }
        answer.add(luck);
        answer.add(match);
        
        return answer;
    }
}