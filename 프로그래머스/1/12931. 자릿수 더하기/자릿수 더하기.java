import java.util.*;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        while(true){
            if(n%10 != 0)answer +=n%10;
            if(n < 10)break;
            n /=10;
        }
        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        System.out.println("Hello Java");

        return answer;
    }
}