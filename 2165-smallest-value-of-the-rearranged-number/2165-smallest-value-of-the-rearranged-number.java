class Solution {
    public long smallestNumber(long num) {
        boolean neg = num < 0;
        num = Math.abs(num);
        int[] count = new int[10];

        while(num > 0){
            count[(int)(num % 10)]++;
            num /= 10;
        }

        long answer = 0;

        if(neg){
            for(int i = 9; i>= 0; i--){
                while(count[i] > 0){
                    answer = answer * 10 + i;
                    count[i]--;
                }
            }
            return -answer;
        }

        if(count[0] > 0){
            for(int i = 1; i < 10; i++){
                if(count[i] > 0){
                    answer =i;
                    count[i]--;
                    break;
                }
            }
        }

        for(int i =0; i < 10; i++){
            while(count[i] > 0){
                answer = answer * 10 + i;
                count[i]--;
            }
        }
        return answer;
    }
}