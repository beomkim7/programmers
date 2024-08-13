import java.util.*;
class Solution {
    public List <Integer> solution(int num, int total) {
        List <Integer> answer = new ArrayList();
        
        int minus = num/2;
        int check = 0;
        if(total % num ==0)check = total / num;
        else check = total / num+1;
        int start = check-minus;
        
        for(int i = start ; i < start+num ; i++){
            answer.add(i);
        }
        
        return answer;
    }
}