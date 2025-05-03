public class Solution {
    public int MajorityElement(int[] nums) {

        int count = 0;
        int returnNum = 0;
        foreach (int num in nums)
        {
            if (count == 0)
                returnNum = num;
            
            count += (returnNum == num)? 1 : -1;
        }
        return returnNum;


        // int mostRepeatingNum = 0;    // before search for boyer-moore algorithm 
        // int repeatingCurrentNum;
        // int returnedNum = nums[0];
        // for (int i = 0; i < nums.Length; i++)
        // {
        //     repeatingCurrentNum = 0;
        //     for (int j = 1; j < nums.Length; j++)
        //     {
        //         if (i != j && nums[i] == nums[j])
        //         {
        //             repeatingCurrentNum++;
        //         }
        //     }
        //     if (mostRepeatingNum < repeatingCurrentNum)
        //     {
        //         mostRepeatingNum = repeatingCurrentNum;
        //         returnedNum = nums[i];
        //     }

        // }
        // return returnedNum;
    }
}