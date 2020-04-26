/*
 * @lc app=leetcode.cn id=94 lang=csharp
 *
 * [94] 二叉树的中序遍历
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
 //使用递归
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        Helper(root, res);
        return res;
    }
    public void Helper(TreeNode node, List<int> res)
    {
        if (node != null)
        {
            if (node.left != null)
            {
                Helper(node.left, res);
            }
            res.Add(node.val);
            if (node.right != null)
            {
                Helper(node.right, res);
            }
        }
    }
}
// @lc code=end

