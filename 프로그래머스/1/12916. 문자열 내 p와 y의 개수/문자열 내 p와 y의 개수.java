class Solution {
    boolean solution(String s) {
        boolean answer = false;

        // [실행] 버튼을 누르면 출력 값을 볼 수 있습니다.
        System.out.println("Hello Java");
        
        int p = 0;
        int y = 0;
        char [] ch = s.toLowerCase().toCharArray();
        for(char c : ch){
            if(c == 'p'){
                p++;
            }
            if(c == 'y')y++;
        }
        if(p == y){
            answer = true;
        }
        return answer;
    }
}