class Solution {
    boolean solution(String s) {
        s = s.toUpperCase();
        int count = 0 ;
        for(int i = 0 ; i < s.length() ; i++){
            if(s.charAt(i) == 'P')count++;
            if(s.charAt(i) == 'Y')count--;
        }

        return count == 0;
    }
}