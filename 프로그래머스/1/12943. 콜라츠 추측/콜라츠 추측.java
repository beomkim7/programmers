class Solution {
    public int solution(int num) {
        int answer = 0;
        int check = 0;
        while(num != 1){
            check++;
            if(num%2==0){
                num = num/2;
            }
            else if(num%2==1){
                num = num*3+1;
            }
            
            if(check == 500){
                answer = -1;
                return answer;
            }
        }
        answer = check ;
        
        return answer;
    }
}