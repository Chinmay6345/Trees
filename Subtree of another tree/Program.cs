using System;
//https://leetcode.com/problems/subtree-of-another-tree/
namespace Subtree_of_another_tree
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


    public static class AppHelper
    {
        public static Boolean IsSameTree(TreeNode root, TreeNode root1)
        {
            TreeNode p = root;
            TreeNode q = root1;
            if (p == null && q == null)
            {
                return true;
            }
            if (p != null && q != null)
            {
                if (p.val == q.val && IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right))
                {
                    return true;
                }
            }
            return false;
        }
        public static Boolean IsSubtree(TreeNode s, TreeNode t)
        {
            if (t == null)
                return true;
            if (s == null)
                return false;
            if (IsSameTree(s, t))
                return true;
            return IsSubtree(s.left, t) || IsSubtree(s.right, t);
        }
    }

    public class Solution
    {
        public bool IsSubtree(TreeNode s, TreeNode t)
        {
            return AppHelper.IsSubtree(s, t);
        }
    }
}
