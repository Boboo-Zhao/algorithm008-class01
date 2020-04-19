/*
 * @lc app=leetcode.cn id=26 lang=csharp
 *
 * [26] 删除排序数组中的重复项
 */

// @lc code=start
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length < 2)
        {
            return nums.Length;
        }
        int currIndex = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[currIndex] != nums[i])
            {
                currIndex ++;
                nums[currIndex] = nums[i];
            }
        }
        return currIndex + 1;

    }
}
// @lc code=end

