import java.util.HashMap;
class Solution {
    public int[] solution(String[] keymap, String[] targets) {
        int[] answer = new int [targets.length];
        
        HashMap<Character,Integer> map = new HashMap<>();
        
        for(int i = 0 ; i < keymap.length ; i++){
            for(char ch : keymap[i].toCharArray()){
                int min = keymap[i].indexOf(ch)+1;
                if(!map.containsKey(ch) || map.get(ch)>min){
                    map.put(ch,min);                
                }
            }
        }
        
        for(int i = 0 ; i < targets.length ; i++){
            int num = 0;
            for(char ch : targets[i].toCharArray()){
                if(map.containsKey(ch)){
                    num +=map.get(ch);
                }else{
                    num = -1;
                    break;
                }
            }
            answer[i] +=num;
        }
        
        return answer;
    }
}