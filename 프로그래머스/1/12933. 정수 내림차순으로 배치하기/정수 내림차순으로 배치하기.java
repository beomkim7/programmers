import java.util.*;
class Solution {
    public long solution(long n) {
        long answer = 0;
        String[] num = Long.toString(n).split("");
        Arrays.sort(num,Collections.reverseOrder());            
        String nums = new String();
        for(int i = 0 ; i < num.length ; i++){
            nums +=num[i];
        }
        answer = Long.parseLong(nums);
        return answer;
    }
}