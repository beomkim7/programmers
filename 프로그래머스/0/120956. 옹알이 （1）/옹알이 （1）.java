class Solution {
    public int solution(String[] babbling) {
        int answer = 0;
        
        String [] check = {"aya", "ye", "woo", "ma"};
        
        for(String st : babbling){
            for(String ch : check){
                st = st.replace(ch," ");
                st = st.trim();
            }
            if(st.equals("")){
                answer++;
            }
        }
        
        return answer;
    }
}