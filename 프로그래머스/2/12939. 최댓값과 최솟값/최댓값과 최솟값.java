import java.util.*;
class Solution {
    public String solution(String s) {
        String answer = "";
        
        ArrayList<Integer> num = new ArrayList<>();
        
        String [] nums = s.split(" ");
        for(int i = 0, j = 1 ; i < nums.length ; i++,j++){
            if(!nums[i].equals("-")){
                num.add(Integer.parseInt(nums[i]));
            }else{
                num.add(Integer.parseInt(nums[i]+nums[j]));
                i = j ;
            }
        }
        Collections.sort(num);
        
        answer = num.get(0)+" "+num.get(num.size()-1);
        
        return answer;
    }
}