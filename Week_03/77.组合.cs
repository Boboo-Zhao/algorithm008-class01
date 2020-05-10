/*
 * @lc app=leetcode.cn id=77 lang=csharp
 *
 * [77] 组合
 */

// @lc code=start
public class Solution {
    public IList<IList<int>> Combine(int n, int k) {
        List<IList<int>> res = new List<IList<int>>();
        backtrack(n, k, res, new List<int>(), 1);
        return res;
    }

    public void backtrack(int n, int k, List<IList<int>> res, List<int> temp, int index)
    {
        if (temp.Count == k)
        {
            res.Add(new List<int>(temp));
            return;
        }
        for (int i = index; i <= n; i++)
        {
            temp.Add(i);
            backtrack(n, k, res, temp, i + 1);
            temp.RemoveAt(temp.Count - 1);
        }
    }
}
// @lc code=end

