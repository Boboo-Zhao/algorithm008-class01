/*
 * @lc app=leetcode.cn id=189 lang=csharp
 *
 * [189] 旋转数组
 */

// @lc code=start
//暴力解法
public class Solution {
    public void Rotate(int[] nums, int k) {
        int temp, previous;
        for (int i = 0; i < k; i++)
        {
            previous = nums[nums.Length - 1];
            for (int j = 0; j < nums.Length; j++)
            {
                temp = nums[j];
                nums[j] = previous;
                previous = temp;
            }
        }

    }
}
// @lc code=end

