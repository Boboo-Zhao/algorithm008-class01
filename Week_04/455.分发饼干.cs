/*
 * @lc app=leetcode.cn id=455 lang=csharp
 *
 * [455] 分发饼干
 */

// @lc code=start
public class Solution {
    public int FindContentChildren(int[] g, int[] s) {
        if (g.Length == 0 || s.Length == 0)
        {
            return 0;
        }
        Array.Sort(g);
        Array.Sort(s);
        int child = 0, cookie = 0;
        while (child < g.Length && cookie < s.Length)
        {
            if (s[cookie] >= g[child])
            {
                child++;
            }
            cookie++;
        }
        return child;

    }
}
// @lc code=end

