class Solution {
    public int[] solution(int[] arr) {
        // 배열의 길이가 1인 경우 -1을 반환
        if (arr.length == 1) {
            return new int[]{-1};
        }
        
        // 배열에서 최소값을 찾음
        int min = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if (arr[i] < min) {
                min = arr[i];
            }
        }
        
        // 최소값을 제거한 배열을 만듦
        int[] answer = new int[arr.length - 1];
        int index = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] != min) {
                answer[index++] = arr[i];
            }
        }
        
        return answer;
    }
}
