/*
 * @lc app=leetcode.cn id=589 lang=csharp
 *
 * [589] N叉树的前序遍历
 */

// @lc code=start
/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<int> Preorder(Node root) {
        if (root == null)
        {
            return new int[]{};
        }
        List<int> res = new List<int>();
        Helper(root, res);
        return res;
    }
    public void Helper(Node root, List<int> res)
    {
        res.Add(root.val);
        if (root.children != null)
        {
            HelperChilds(root.children, res);
        }      
    }
    public void HelperChilds(IList<Node> root, List<int> res)
    {
        foreach (var item in root)
        {
            Helper(item, res);
        }
    }
}
// @lc code=end

