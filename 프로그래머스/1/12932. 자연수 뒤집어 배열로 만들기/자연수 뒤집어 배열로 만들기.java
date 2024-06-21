import java.util.*;

class Solution {
    public int[] solution(long n) {
        // long 타입 숫자를 문자열로 변환
        String nums = Long.toString(n);
        
        // 각 자리수를 역순으로 저장할 배열 초기화
        int[] answer = new int[nums.length()];
        
        // 문자열을 역순으로 순회하며 각 문자를 정수로 변환 후 배열에 저장
        for (int i = 0; i < nums.length(); i++) {
            answer[i] = Character.getNumericValue(nums.charAt(nums.length() - 1 - i));
        }
        
        return answer;
    }
}
