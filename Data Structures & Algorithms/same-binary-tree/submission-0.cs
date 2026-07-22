/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode q) {
        if (p == null && q == null)
            return true;
        
        var stack1 = new Stack<TreeNode>();
        var stack2 = new Stack<TreeNode>();

        stack1.Push(p);
        stack2.Push(q);

        while (stack1.Count > 0 && stack2.Count > 0)
        {
            var el1 = stack1.Pop();
            var el2 = stack2.Pop();

            if (el1?.val != el2?.val)
                return false;

            if (el1.right != null && el2.right != null)
            {
                stack1.Push(el1.right);
                stack2.Push(el2.right);
            }
            else if (!(el1.right == null && el2.right == null))
                return false;

            if (el1.left != null && el2.left != null)
            {
                stack1.Push(el1.left);
                stack2.Push(el2.left);
            }
            else if (!(el1.left == null && el2.left == null))
                return false;
        }

        return true;
    }
}
