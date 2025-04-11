class Solution {
    public int countSubarrays(int[] nums) {
        int counter = 0;
        for(int i = 1; i+1 < nums.length; i++){
            if((nums[i-1]+nums[i+1])*2 == nums[i]){
                counter++;
            }
        }
        return counter;
    }
}