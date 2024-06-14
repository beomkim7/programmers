import java.util.ArrayList;
import java.util.List;
class Solution {
    public int[] solution(int[] answers) {
        
        int[] score0={1, 2, 3, 4, 5};
        int[] score1={2, 1, 2, 3, 2, 4, 2, 5};
        int[] score2={3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        
        int[] scores = new int[3];
        
        
        for(int j =0 ; j < answers.length ; j++){
            if(answers[j]==score0[j%score0.length])scores[0]++;
            if(answers[j]==score1[j%score1.length])scores[1]++;
            if(answers[j]==score2[j%score2.length])scores[2]++;
        }
        
        
        int maxscore = Math.max(scores[0],Math.max(scores[1],scores[2]));
        
        List<Integer> bestPeopls = new ArrayList<>();
        for(int i = 0 ; i < scores.length ; i++){
            if(maxscore == scores[i])bestPeopls.add(i+1);
        }
        
        int[] answer = new int[bestPeopls.size()];
        for(int i = 0 ; i < answer.length ; i++){
            answer[i]=bestPeopls.get(i);
        }
        
        return answer;
    }
}