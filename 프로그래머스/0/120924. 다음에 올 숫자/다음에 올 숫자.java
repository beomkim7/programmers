class Solution {
    public int solution(int[] common) {
        int answer = 0;
        
        int plus = common[1]-common[0];
        int multi = 0;
        if(common[0] !=0){
            multi = common[1]/common[0];
        }
        
        boolean check = false;
        
        for(int i = 1 ; i < common.length ; i++){
            if(common[i] - common[i-1] != plus){
                check = true;
                break;
            }
        }
        
        if(check)answer = common[common.length-1] * multi;
        else answer = common[common.length-1] +plus;
        
        
        
        return answer;
    }
}