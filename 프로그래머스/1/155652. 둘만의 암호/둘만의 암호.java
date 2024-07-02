class Solution {
    public String solution(String s, String skip, int index) {
        StringBuilder answer = new StringBuilder();
        
        for(char c : s.toCharArray()){
            char check = c;
            int idx = 0 ;
            
            while(idx < index){
                check=check=='z'?'a':(char)(check+1);
                if(!skip.contains(String.valueOf(check))){
                    idx +=1;
                }
            }
            answer.append(check);
            
        }
        return answer.toString();
    }
}