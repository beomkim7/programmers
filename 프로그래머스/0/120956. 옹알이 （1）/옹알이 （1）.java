class Solution {
    public int solution(String[] babbling) {
        int answer = 0;
        
        String [] check = {"aya", "ye", "woo", "ma"};
        
        for(String b : babbling){
            for(String c : check){
                b = b.replace(c,"1");
                b = b.replace("1"," ");
                b = b.trim();
            }
            if(b.isEmpty()){
                answer++;
            }
        }
        
        return answer;
    }
}