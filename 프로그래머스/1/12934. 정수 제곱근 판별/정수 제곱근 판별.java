class Solution {
    public long solution(long n) {
        
        if(Math.pow((int)Math.sqrt(n),2) == n){
            n = (long)Math.pow(Math.sqrt(n)+1,2);
            return n;
        }
        
        return -1;
    }
}