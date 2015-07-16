using System;
using System.Collections;
using System.Collections.Generic;


namespace LeetCode3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TreeNode n6 = new TreeNode (6);
			TreeNode n2 = new TreeNode (2);
			TreeNode n8 = new TreeNode (8);
			TreeNode n0 = new TreeNode (0);
			TreeNode n3 = new TreeNode (3);
			TreeNode n4 = new TreeNode (4);
			TreeNode n5 = new TreeNode (5);
			TreeNode n7 = new TreeNode (7);
			TreeNode n9 = new TreeNode (9);

			n6.left = n2;
			n6.right = n8;
			n2.left = n0;
			n2.right = n4;
			n4.left = n3;
			n4.right = n5;
			n8.left = n7;
			n8.right = n9;

			BstOp o = new BstOp ();
//			Console.WriteLine ("Result " + o.LowestCommonAncestor(n6,n2,n0).val);
			int[] arr = new int[]{ 2,3,1};
			ArrayOps arrayOp = new ArrayOps();
			Console.WriteLine (arrayOp.FindMin(arr));

		}

		public static int SingleNumber(int[] nums) {
			int result = 0;
			foreach (var item in nums) {
				result = result ^ item;	
			}
			return result;
		}

		public static void Test()
		{
			HashSet<string> set = new HashSet<string> ();

			Random r = new Random ();
			int first = r.Next (1, 10000);
			int second = r.Next (1, 10000);

			string f = first.ToString ();
			string s = second.ToString ();

			set.Add (f);
			set.Add (s);

			string test1 = f +  s;
			string test2 = s +  f;

			WordOps o = new WordOps ();

			if (!o.WordBreak(test1,set,0)){
				Console.WriteLine ("failed");
				Console.Write ("f: " + f);
				Console.Write (" s: " + s);
				Console.WriteLine ("test1: " + test1);
				System.Environment.Exit (1);
			}

			if (!o.WordBreak(test2,set,0)){
				Console.WriteLine ("failed");
				Console.Write ("f: " + f);
				Console.Write (" s: " + s);

				Console.WriteLine ("test2: " + test2);
				System.Environment.Exit (1);
			}
		}
	}
}
