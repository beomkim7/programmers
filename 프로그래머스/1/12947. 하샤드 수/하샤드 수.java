class Solution {
    public boolean solution(int x) {
        boolean answer = true;
        String [] num = Integer.toString(x).split("");
        int number = 0 ;
        for(int i = 0 ; i < num.length ; i++){
            number += Integer.parseInt(num[i]);
        }
        
        if(x % number != 0){
            answer = false;
        }
        
        return answer;
    }
}