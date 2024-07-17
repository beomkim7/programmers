class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        
        int mom = numer1*denom2 + numer2*denom1;
        int bro = denom1 * denom2;
        int result = cal(mom,bro);
        
        int[] answer = {mom/result,bro/result};
        return answer;
    }
    
    public int cal(int a , int b){
        int temp = 0;
        while(b != 0){
            temp = b;
            b = a % b;
            a= temp;
        }
        return a;
    }
}