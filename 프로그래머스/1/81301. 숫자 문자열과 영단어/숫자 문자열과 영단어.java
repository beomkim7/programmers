class Solution {
    public int solution(String s) {
        int answer = 0;
        String [] change = {"zero","one","two","three","four","five","six","seven","eight","nine"};
        
        for(int i = 0 ; i < change.length ; i++){
           s = s.replaceAll(change[i],i+"");
            
        }
        answer = Integer.parseInt(s);
        return answer;
    }
}