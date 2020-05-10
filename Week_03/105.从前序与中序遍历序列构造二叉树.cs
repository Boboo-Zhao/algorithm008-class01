/*
 * @lc app=leetcode.cn id=105 lang=csharp
 *
 * [105] 从前序与中序遍历序列构造二叉树
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
public class Solution {
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Helper(preorder,inorder,0,inorder.Length - 1, 0);
    }
    public TreeNode Helper(int[] preorder, int[] inorder,int inStart, int inEnd, int preStart)
    {
        if (preStart >= preorder.Length || inStart > inEnd)
        {
            return null;
        }
         var inIndex = 0;
    for (int i = inStart; i <= inEnd; i++)
    {
        if (inorder[i] == preorder[preStart])
        {
            inIndex = i;
        }
    }
    var root = new TreeNode(preorder[preStart]);
    root.left = Helper(preorder, inorder, inStart, inIndex - 1, preStart + 1);
    root.right = Helper(preorder, inorder, inIndex + 1, inEnd, preStart + inIndex - inStart + 1);
    return root;
    } 
}
// @lc code=end

