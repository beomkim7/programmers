import java.util.*;
class Solution {
    public int solution(int n) {
        int answer = 0;
        
        ArrayList<Integer> nums = new ArrayList<>();
        
        for(int i = 1 ; i < n ; i++){
            if(n % i ==1){
                nums.add(i);
            }
        }
        
        answer = nums.get(0);
        
        return answer;
    }
}