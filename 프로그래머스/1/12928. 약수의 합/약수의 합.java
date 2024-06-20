import java.util.List;
import java.util.ArrayList;
class Solution {
    public int solution(int n) {
        int answer = 0;
        List <Integer> num = new ArrayList<>();
        for(int i = 1 ; i <= n ; i++){
            if(n%i == 0){
                num.add(i);
            }
        }
        for(int i = 0 ; i < num.size() ; i++){
            answer +=num.get(i);
        }
        return answer;
    }
}