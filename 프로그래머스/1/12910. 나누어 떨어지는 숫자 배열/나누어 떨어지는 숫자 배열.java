import java.util.ArrayList;
import java.util.Collections;

class Solution {
    public int[] solution(int[] arr, int divisor) {
        ArrayList<Integer> list = new ArrayList<>();
        
        // 주어진 배열을 순회하며 나누어 떨어지는 값을 리스트에 추가
        for(int num : arr) {
            if(num % divisor == 0) {
                list.add(num);
            }
        }
        
        // 나누어 떨어지는 값이 없으면 -1을 반환
        if (list.isEmpty()) {
            return new int[]{-1};
        }
        
        // 리스트를 정렬
        Collections.sort(list);
        
        // 리스트를 배열로 변환하여 반환
        int[] answer = new int[list.size()];
        for(int i = 0; i < list.size(); i++) {
            answer[i] = list.get(i);
        }
        
        return answer;
    }
}
