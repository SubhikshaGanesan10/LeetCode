public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0){
            return false;
        }
        if(x<10 && x>=0){
            return true;
        }
        int n = x;
        int reverseX = 0;
        while(n>0){
            reverseX = 10 * reverseX + n % 10;
            n/=10;
        }
        if(x == reverseX){
            return true;
        }
        else{
            return false;
        }
    }
}