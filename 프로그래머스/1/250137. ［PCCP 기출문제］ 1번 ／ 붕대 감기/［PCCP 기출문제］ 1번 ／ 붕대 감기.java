class Solution {
    public int solution(int[] bandage, int health, int[][] attacks) {
        int answer = 0 ;
        int maxhp = health;
        
        int beforeT = 0;
        int gethpT;
        
        for(int i = 0 ; i < attacks.length ; i++){
            int time = attacks[i][0];
            int damage = attacks[i][1];
            gethpT = time - beforeT - 1 ;
            beforeT = time;
            health = Math.min(maxhp,health+gethpT*bandage[1]);
            if(gethpT/bandage[0]>0){
                health = Math.min(maxhp,health+gethpT/bandage[0]*bandage[2]);
            }
            health -=damage;
            if(health<=0){
                return -1;
            }
        }
        return health;
    }
}