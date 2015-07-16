using System;

namespace LeetCode3
{
	public class TreeNode {
		public int val;
		public TreeNode left;
		public TreeNode right;
		public TreeNode(int x) { val = x; }
	}

	public class BstOp
	{
		public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
		{
			int first = (int)Math.Min (p.val, q.val);
			int second = (int)Math.Max(p.val, q.val);

			return LowestCommonAncestor (root, first, second);
		}

		public TreeNode LowestCommonAncestor(TreeNode root, int p, int q) 
		{
			if (root == null) {
				return null;
			}

			Console.WriteLine (root.val);
			if (root.val <= q && root.val >= p) {
				return root;
			}

			var left = LowestCommonAncestor (root.left, p, q);
			if (left != null) {
				return left;
			} 
			var right = LowestCommonAncestor (root.right,p,q);
			return right;	
		}


		bool found = false;

		public int KthSmallest(TreeNode root, int k) 
		{
			int[] arr = new int[1];
			int[] kArr = new int[1];
			kArr [0] = k;
			KthSmallest (root, kArr, arr);
			return arr [0];
		}

		public void KthSmallest(TreeNode root, int[] k,int[] arr) 
		{
			if (root == null) {
				return ;
			}

			if (found) {
				return;
			}

			KthSmallest (root.left, k,arr);

//			Console.WriteLine (root.val);

			k [0] -= 1;
			if (k [0] == 0) {
				arr [0] = root.val;
				found = true;
				return;
			} 
				
			KthSmallest (root.right, k,arr);

		}
	}
}

