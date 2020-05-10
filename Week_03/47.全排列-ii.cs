/*
 * @lc app=leetcode.cn id=47 lang=csharp
 *
 * [47] 全排列 II
 */

// @lc code=start
public class Solution {
    List<IList<int>> res = new List<IList<int>>();
    public IList<IList<int>> PermuteUnique(int[] nums) {
        if (nums.Length == 0)
        {
            return res;
        }

        Array.Sort(nums);
        backtrack(nums, new bool[nums.Length], new List<int>());
        return res;
    }

    public void backtrack(int[] nums, bool[] visited, List<int> trace)
    {
        if (trace.Count == nums.Length)
        {
            res.Add(new List<int>(trace));
            return;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            if (visited[i])
            {
                continue;
            }
            if (i > 0 && nums[i] == nums[i - 1] && visited[i - 1])
            {
                continue;
            }

            trace.Add(nums[i]);
            visited[i] = true;
            backtrack(nums, visited, trace);
            trace.RemoveAt(trace.Count - 1);
            visited[i] = false;
        }
    }
}
// @lc code=end

