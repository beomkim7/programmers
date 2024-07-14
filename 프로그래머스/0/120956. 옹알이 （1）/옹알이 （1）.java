class Solution {
    public int solution(String[] babbling) {
        int answer = 0;
        for(String check : babbling){
            check = check.replace("aya"," ");
            check = check.replace("ye"," ");
            check = check.replace("woo"," ");
            check = check.replace("ma"," ");
            check = check.trim();
            System.out.println(check);
            if(check.isEmpty()){
                answer += 1;                
            }
        }
        return answer;
    }
}