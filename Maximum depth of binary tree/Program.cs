using System;
//https://leetcode.com/problems/maximum-depth-of-binary-tree/
namespace Maximum_depth_of_binary_tree
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
        public static Int32 HeightBTree(TreeNode root)
        {
            Int32 height = 0;
            TreeNode p = root;
            if (p == null)
            {
                return 0;
            }
            else
            {
                Int32 left = HeightBTree(p.left);
                Int32 right = HeightBTree(p.right);
                if (left > right)
                {
                    height = left + 1;
                }
                else
                    height = right + 1;
            }
            return height;
        }
    }

    public class Solution
    {
        public int MaxDepth(TreeNode root)
        {
            return AppHelper.HeightBTree(root);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
