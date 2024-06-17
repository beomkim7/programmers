import java.util.List;
import java.util.ArrayList;
import java.util.HashSet;
import java.util.Set;
class Solution {
    public List<Integer> solution(int[] lottos, int[] win_nums) {
        Set<Integer> count = new HashSet<>();
        
        for(int num : win_nums){
            count.add(num);
        }
        
        int match = 0;
        int zero = 0;
        
        for(int lotto : lottos){
            if(lotto == 0){
                zero++;
            }
            if(count.contains(lotto)){
                match++;
            }
        }
        
        int finalZero = realNum(zero+match);
        int finalmatch = realNum(match);
        
        List<Integer> answer = new ArrayList<>();
        answer.add(finalZero);
        answer.add(finalmatch);
        
        return answer;
    }
    private int realNum(int number){
        switch(number){
            case 6 : return 1;
            case 5 : return 2;
            case 4 : return 3;
            case 3 : return 4;
            case 2 : return 5;
            default: return 6;
        }
    }
}

