class Solution {
    
        
        public double detail(int[] a , int[] b){
            return (double)(a[1]-b[1])/(a[0]-b[0]);
        }
        
        public boolean check(int[] a, int[] b , int[] c, int[] d){
            return detail(a,b)==detail(c,d);
        }
        
        public int solution(int[][] dots){
            if(check(dots[0],dots[1],dots[2],dots[3]))return 1;
            if(check(dots[0],dots[2],dots[1],dots[3]))return 1;
            if(check(dots[0],dots[3],dots[1],dots[2]))return 1;
            return 0;
            
        }
        
        
    
}