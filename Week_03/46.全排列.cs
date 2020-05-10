/*
 * @lc app=leetcode.cn id=46 lang=csharp
 *
 * [46] 全排列
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        backtrack(nums, res, new List<int>());
        return res;
    }

    public void backtrack(int[] nums, List<IList<int>> res, List<int> temp)
    {
        if (temp.Count == nums.Length)
        {
            res.Add(new List<int>(temp));
            return;
        }
        for (int i = 0; i < nums.Length; i++)
        {
            if (temp.Contains(nums[i]))
            {
                continue;
            }
            temp.Add(nums[i]);
            backtrack(nums, res, temp);
            temp.RemoveAt(temp.Count - 1);
        }

    }
}
// @lc code=end

