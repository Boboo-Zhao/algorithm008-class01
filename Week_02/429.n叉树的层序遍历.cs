/*
 * @lc app=leetcode.cn id=429 lang=csharp
 *
 * [429] N叉树的层序遍历
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

    public Node(int _val, IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution {
    public IList<IList<int>> LevelOrder(Node root) {
        var res = new List<IList<int>>();
        if (root == null)
        {
            return res;
        }
        var list = new List<Node> {root};
        while (list.Count > 0)
        {
            var tree = new List<Node>();
            var line = new List<int>();
            foreach (var item in list)
            {
                if (item != null && item.children != null)
                {
                    line.Add(item.val);
                    tree.AddRange(item.children);
                }
            }
            res.Add(line);
            list = tree;
        }
        return res;
    }
}
// @lc code=end

