class Solution {
    
    public double check(int[] a,int[] b){
        return (double)(a[1]-b[1])/(a[0]-b[0]);
    }
    
    public int solution(int[][] dots) {
        int answer = 0;
        
        if(check(dots[0],dots[1])==check(dots[2],dots[3]))return 1;
        if(check(dots[0],dots[2])==check(dots[1],dots[3]))return 1;
        if(check(dots[0],dots[3])==check(dots[1],dots[2]))return 1;
        
        return answer;
    }
}