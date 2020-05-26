using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/same-tree/
namespace Same_Tree
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
    }
    public class Solution
    {
        public bool IsSameTree(TreeNode p, TreeNode q)
        {
            return AppHelper.IsSameTree(p, q);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
