class Solution {
    public int solution(String s) {
        int answer = 0;
        
        String [] spell = s.split("");
        int i = 0 ;
        int check = 0 ;
        int spellCount = 0;
        while(i<spell.length){
            check = 1 ;
            spellCount = 1 ;
            for(int j = i+1 ; j < spell.length ; j++){
                if(spell[i].equals(spell[j]))check++;
                else check--;
                
                if(check == 0){
                    if(i+1 != spell.length){
                        spellCount++;
                    }
                    break;
                }
                spellCount++;
            }
            answer++;
            i +=spellCount;
        }
        
        return answer;
    }
}