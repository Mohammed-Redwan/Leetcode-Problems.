public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target && i != j)
                {

                    Console.WriteLine(nums[i] + "it i " + " and this J" + nums[j]);
                    return [i, j];
                }
            }
        }
        return null;
    }
}
