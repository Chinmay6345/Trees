using System;
//https://leetcode.com/problems/diameter-of-binary-tree/
namespace Diameter_of_btree
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
        public static Int32 DiameterBTree(TreeNode root)
        {
            TreeNode p = root;
            if (p == null)
            {
                return 0;
            }
            else
            {
                Int32 left = HeightBTree(p.left);
                Int32 right = HeightBTree(p.right);

                Int32 leftD = DiameterBTree(p.left);
                Int32 rightD = DiameterBTree(p.right);

                Int32 diameter = Math.Max(left + right, Math.Max(leftD, rightD));
                return diameter;
            }
        }
    }
    public class Solution
    {
        public int DiameterOfBinaryTree(TreeNode root)
        {
            return AppHelper.DiameterBTree(root);
        }
    }
}
