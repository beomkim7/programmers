class Solution {
    
    
    public double bool(int [] a , int [] b){
        return (double)(a[1]-b[1])/(a[0]-b[0]);
    }
    
    public int solution(int[][] dots) {
        int answer = 0;
        if(bool(dots[0],dots[1])==bool(dots[2],dots[3]))answer = 1;
        if(bool(dots[0],dots[2])==bool(dots[1],dots[3]))answer = 1;
        if(bool(dots[0],dots[3])==bool(dots[1],dots[2]))answer = 1;
        
        return answer;
        
    }
}