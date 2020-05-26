using System.Collections.Generic;

namespace Invert_a_Btree
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            Queue<TreeNode> queue = new Queue<TreeNode>();
            TreeNode p = root;
            queue.Enqueue(p);
            while (queue.Count != 0)
            {
                TreeNode current = queue.Dequeue();
                var temp = current.left;
                current.left = current.right;
                current.right = temp;
                if (current.left != null) queue.Enqueue(current.left);
                if (current.right != null) queue.Enqueue(current.right);
            }
            return p;
        }
        public TreeNode RInvertTree(TreeNode root)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode right = RInvertTree(root.right);
            TreeNode left = RInvertTree(root.left);
            root.left = right;
            root.right = left;
            return root;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
