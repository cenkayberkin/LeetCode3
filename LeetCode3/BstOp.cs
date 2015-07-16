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
		TreeNode root;

		public void AddToBst(int num)
		{
			if (root == null) {
				root = new TreeNode (num);
			} else {
				var newNode = new TreeNode (num);
				AddToBst (root, newNode);
			}
		}

		public void AddToBst(TreeNode root, TreeNode newNode)
		{
			if (root == null) {
				return;
			}

			if (root.val <= newNode.val) {
				if (root.right == null) {
					root.right = newNode;	
				} else {
					AddToBst (root.right, newNode);
				}

			} else {
				if (root.left == null) {
					root.left = newNode;
				} else {
					AddToBst (root.left, newNode);
				}
			}

		}

		public TreeNode SortedArrayToBST(int[] nums)
		{
			SortedArrayToBST (nums, 0, nums.Length -1);
			return root;
		}

		public void SortedArrayToBST(int[] nums,int lo,int hi) 
		{
			if (lo > hi) {
				return;
			}

			int mid = (lo + hi) / 2;
			this.AddToBst (nums[mid]);

			SortedArrayToBST (nums, lo, mid - 1);
			SortedArrayToBST (nums, mid +1, hi);

		}

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

