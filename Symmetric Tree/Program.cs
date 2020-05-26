using System;
using System.Collections.Generic;
using System.Linq;
//https://leetcode.com/problems/symmetric-tree/
namespace Symmetric_Tree
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
        public static Boolean IsMirror(TreeNode root)
        {
            if (root == null)
            {
                return true;
            }
            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(root.left);
            q.Enqueue(root.right);
            while (q.Any())
            {
                TreeNode t1 = q.Dequeue();
                TreeNode t2 = q.Dequeue();
                if (t1 == null && t2 == null)
                {
                    continue;
                }
                if (t1 == null || t2 == null)
                {
                    return false;
                }
                if (t1.val != t2.val)
                {
                    return false;
                }
                q.Enqueue(t1.left);
                q.Enqueue(t2.right);
                q.Enqueue(t1.right);
                q.Enqueue(t2.left);
            }
            return true;
        }
        public static Boolean RIsMirror(TreeNode p, TreeNode q)
        {
            if (p == null && q == null)
            {
                return true;
            }
            if (p == null || q == null)
            {
                return false;
            }
            if (p.val == q.val)
            {
                if (RIsMirror(p.left, q.right) && RIsMirror(p.right, q.left))
                    return true;
            }
            return false;
        }
    }
    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            return AppHelper.IsMirror(root);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
