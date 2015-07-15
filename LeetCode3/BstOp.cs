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

