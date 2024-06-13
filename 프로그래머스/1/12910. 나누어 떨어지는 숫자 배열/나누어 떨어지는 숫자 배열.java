import java.util.*;


class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<Integer> list = new ArrayList<Integer>();
        Arrays.sort(arr);
        
        for(int num : arr){
            if(num % divisor == 0 ){
                list.add(num);
            }
        }
        
        int listSize = list.size();
        
        if(listSize == 0){
            int[] answer = {-1};
            return answer;
        }
        
        int[] answer = new int[listSize];
        for(int i = 0 ; i < listSize ; i++){
            answer[i]=list.get(i);            
        }
        return answer;
    }
}
