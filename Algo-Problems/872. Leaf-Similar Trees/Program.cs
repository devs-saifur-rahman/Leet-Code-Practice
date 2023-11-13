using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _872.Leaf_Similar_Trees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int?[] ar1 = { 3, 5, 1, 6, 2, 9, 8, null, null, 7, 4 };
            int?[] ar2 = { 3, 5, 1, 6, 7, 4, 2, null, null, null, null, null, null, 9, 8 };

            TreeNode root1 = CreateTree(ar1);
            TreeNode root2 = CreateTree(ar2);

            bool k = LeafSimilar(root1, root2);
            Console.ReadLine();
        }

        public static List<int> ExtractLeafNodes(TreeNode root, List<int> leafNodes)
        {
            if (root.left == null && root.right == null)
            {
                leafNodes.Add(root.val);
            }
            
            if (root.left != null)
            {
                leafNodes = ExtractLeafNodes(root.left, leafNodes);
            }
            
            if (root.right != null)
            {
                leafNodes = ExtractLeafNodes(root.right, leafNodes);
            }
            return leafNodes;
        }

        public static bool LeafSimilar(TreeNode root1, TreeNode root2)
        {
            List<int> leafNodes1 = new List<int>();
            List<int> leafNodes2 = new List<int>();
            leafNodes1 = ExtractLeafNodes(root1, leafNodes1);
            leafNodes2 = ExtractLeafNodes(root2, leafNodes2);

            return leafNodes1.SequenceEqual(leafNodes2);
        }


        public static TreeNode CreateTree(int?[] arr)
        {
            if (arr == null || arr.Length == 0 || arr[0] == null)
                return null;

            TreeNode root = new TreeNode((int)arr[0]);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            bool skipLeft = false;

            for (int i = 1; i < arr.Length; i++)
            {
                TreeNode current = queue.Peek();
                if (current.left == null && !skipLeft)
                {
                    if (arr[i] != null)
                    {
                        current.left = new TreeNode((int)arr[i]);
                        queue.Enqueue(current.left);
                    }
                    else
                    {
                        skipLeft = true;
                    }
                }
                else if (current.right == null)
                {
                    if (arr[i] != null)
                    {
                        current.right = new TreeNode((int)arr[i]);
                        queue.Enqueue(current.right);
                    }
                    skipLeft = false;
                    queue.Dequeue();
                }
            }

            return root;
        }
    }




    //Definition for a binary tree node.
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


}
