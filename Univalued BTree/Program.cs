using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//https://leetcode.com/problems/univalued-binary-tree/
namespace Univalued_BTree
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
        public static Boolean IsUnivalTree(TreeNode root)
        {
            if (root == null)
            {
                return false;
            }
            List<Int32> lst = new List<Int32>();
            Queue<TreeNode> q = new Queue<TreeNode>();
            TreeNode p = root;
            lst.Add(p.val);
            q.Enqueue(p);
            while (q.Count != 0)
            {
                p = q.Dequeue();
                lst.Add(p.val);
                if (p.left != null)
                {
                    q.Enqueue(p.left);
                }
                if (p.right != null)
                {
                    q.Enqueue(p.right);
                }
            }
            return lst.All(g => g == lst.First());
        }
    }
    public class Solution
    {
        public bool IsUnivalTree(TreeNode root)
        {
            return AppHelper.IsUnivalTree(root);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
