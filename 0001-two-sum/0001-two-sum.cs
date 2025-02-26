public class Solution {
    public int[] TwoSum(int[] nums, int target) {
         var dict = new Dictionary<int, int>();
        for (int i = 0; ; ++i) {
            int x = nums[i];
            int y = target - x;
            if (dict.ContainsKey(y)) {
                return new int[] { dict[y], i };
            }
            dict[x] = i;
        }
    }
}