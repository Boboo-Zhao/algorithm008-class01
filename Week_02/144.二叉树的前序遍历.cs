/*
 * @lc app=leetcode.cn id=144 lang=csharp
 *
 * [144] 二叉树的前序遍历
 */

// @lc code=start
/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */

 //递归解法
public class Solution {
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        Helper(root, res);
        return res;
    }
    public void Helper(TreeNode root, List<int> res)
    {
        if (root != null)
        {
            res.Add(root.val);
            if (root.left != null)
            {
                Helper(root.left, res);
            }
            if (root.right != null)
            {
                Helper(root.right, res);
            }
        }
    }
}
// @lc code=end

