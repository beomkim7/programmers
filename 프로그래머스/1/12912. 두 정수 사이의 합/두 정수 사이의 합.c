#include <stdio.h>
#include <stdbool.h>
#include <stdlib.h>


long long solution(int a, int b) {
    long long answer = 0;
    if(a == b){
        return a;
    }
    if(a < b){
        for(a ; a<=b ; a++){
            answer +=a;            
        }
        return answer;
    }
    if(a > b){
        for(b ; b <= a ; b++){
            answer +=b;
        }
        return answer;
    }
    
}