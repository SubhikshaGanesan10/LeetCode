class Solution {
    public int fib(int n) {
        int[] fibonacci = new int[31];
        fibonacci[0] = 0;
        fibonacci[1] = 1;
        int result = 0;

        if(n == 0){
            result = 0;
        }
        if(n == 1){
            result = 1;
        }

        if(n > 1){
            for(int i = 2; i < fibonacci.length; i++){
                fibonacci[i] = fibonacci[i-1] + fibonacci[i-2];
                if(i == n){
                    result = fibonacci[i];
                }
            } 
        }

        return result;  
    }
}