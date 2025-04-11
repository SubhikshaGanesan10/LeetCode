class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer, Integer> d = new HashMap<Integer, Integer>();
        for(int i = 0; ; i++){
            int x = nums[i];
            int y = target - x;
            if(d.containsKey(y)){
                return new int[] {i, d.get(y)};
            }
            d.put(x, i);
        }
    }
}