class Solution {
    public int solution(int[] common) {
        int answer = 0;
        
        if (common.length < 2) {
            throw new IllegalArgumentException("배열의 길이는 적어도 2 이상이어야 합니다.");
        }
        
        // 첫 번째 공차나 공비를 구합니다.
        int diff = common[1] - common[0];
        int ratio = 0;
        if (common[0] != 0) {
            ratio = common[1] / common[0];
        }
        
        // 등차수열인지 확인합니다.
        boolean isArithmetic = true;
        for (int i = 1; i < common.length; i++) {
            if (common[i] - common[i - 1] != diff) {
                isArithmetic = false;
                break;
            }
        }
        
        if (isArithmetic) {
            // 등차수열인 경우
            answer = common[common.length - 1] + diff;
        } else {
            // 등비수열인지 확인합니다.
            boolean isGeometric = true;
            for (int i = 1; i < common.length; i++) {
                if (common[i - 1] == 0 || common[i] / common[i - 1] != ratio) {
                    isGeometric = false;
                    break;
                }
            }
            
            if (isGeometric) {
                // 등비수열인 경우
                answer = common[common.length - 1] * ratio;
            } else {
                throw new IllegalArgumentException("입력된 배열은 등차수열 또는 등비수열이 아닙니다.");
            }
        }
        
        return answer;
    }
}
