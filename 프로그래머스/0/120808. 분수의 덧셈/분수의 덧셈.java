class Solution {
    public int[] solution(int numer1, int denom1, int numer2, int denom2) {
        int[] answer = new int [2];
        
        int mom = denom1 * denom2;
        int bro = (numer2 * denom1) + (numer1 * denom2);
        int result = check(bro,mom);
        System.out.println(result);
        
        answer[0] = bro/result;
        answer[1] = mom/result;
        return answer;
    }
    
    public int check(int a , int b){
        int temp = 0 ;
        while(b != 0){
            temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    
}