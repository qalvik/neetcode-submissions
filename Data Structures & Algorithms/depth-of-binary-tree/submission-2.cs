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
    public int MaxDepth(TreeNode root) {
        if (root == null) return 0;

        var queue = new Queue<TreeNode>();
        var maxD = 0;
        queue.Enqueue(root);
        
        while (queue.Count != 0)
        {
            var size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var el = queue.Dequeue();

                if (el.left != null)
                    queue.Enqueue(el.left);
                if (el.right != null)
                    queue.Enqueue(el.right);
            }
            maxD++;
        }

        return maxD;
    }
}
