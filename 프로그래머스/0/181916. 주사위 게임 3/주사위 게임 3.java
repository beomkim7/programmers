import java.util.*;
class Solution {
    public int solution(int a, int b, int c, int d) {
        int answer = 0;
        
        int [] num = new int[]{a,b,c,d};
        Map <Integer,Integer> check = new HashMap<>();
        
        for(int i = 0 ; i < num.length ; i++){
            int count = 1 ;
            
            for(int j = i+1 ; j < num.length ; j++){
                if(num[i]==num[j])count++;
            }
            
            if(!check.containsKey(num[i])){
                check.put(num[i],count);
            }
            if(check.get(num[i]) < count){
                check.put(num[i],count);
            }
            
        }
        
        // for(int i = 0 ; i < check.size() ; i++){
        //         System.out.println(check.get(num[i]));
        //         System.out.println(num[i]);
        // }
        List <Integer> nums = new ArrayList<>();
        switch(check.size()){
            case 1 : answer = 1111*a;
                break;
            case 2 : 
                int big = 0;
                int small = 0;
                
                for(int key : check.keySet()){
                    if(check.get(key)==1 || check.get(key)==3){
                        if(check.get(key)==3){
                            big = key;
                        }
                        if(check.get(key)==1){
                            small = key;
                        }
                        answer = 1;
                        
                    }    
                    else{                        
                        if(!nums.contains(key))nums.add(key);
                    }
                }
                if(answer ==1 ){
                    answer = (int)Math.pow(big*10+small,2);
                }else{
                    answer = (nums.get(0)+nums.get(1))*Math.abs(nums.get(0)-nums.get(1));
                }
                break;
            case 3:
                for(int key : check.keySet()){
                    if(check.get(key)!=2)nums.add(key);
                }
                answer = nums.get(0)*nums.get(1);
                break;
            case 4:
                answer = Math.min(Math.min(a,b),Math.min(c,d));
                break;
        }       
        
        return answer;
    }
}