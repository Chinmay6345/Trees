using System;
using System.Collections.Generic;
//https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/
namespace Construct_Binary_Tree_from_Preorder_and_Inorder_Traversal
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
    public class AppHelper
    {
        Dictionary<Int32, Int32> hMap = new Dictionary<Int32, Int32>();
        Int32 preIndex = 0;
        public TreeNode TreeFromPreAndIn(int[] preorder, int[] inorder)
        {
            for (Int32 i = 0; i < inorder.Length; i++)
            {
                hMap.Add(inorder[i], i);
            }
            return BuildTree(preorder, inorder, 0, inorder.Length - 1);
        }
        public TreeNode BuildTree(Int32[] preorder, Int32[] inorder, Int32 start, Int32 end)
        {
            if (start > end)
            {
                return null;
            }
            TreeNode root = new TreeNode(preorder[preIndex++]);
            if (root == null)
            {
                return null;
            }
            if (start == end)
            {
                return root;
            }
            Int32 index = hMap[root.val];
            root.left = BuildTree(preorder, inorder, start, index - 1);
            root.right = BuildTree(preorder, inorder, index + 1, end);
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
