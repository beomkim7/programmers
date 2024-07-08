class Solution {
    public String solution(String s) {
        String answer = "";
        
        String [] num = s.split(" ");
        
        int max,min,n;
        min = max = Integer.parseInt(num[0]);
        for(int i = 0 ; i < num.length ; i++){
            n = Integer.parseInt(num[i]);
            if(min > n)min = n;
            if(max < n)max = n;
        }
        answer = min + " " + max;
        return answer;
    }
}