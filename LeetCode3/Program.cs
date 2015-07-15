using System;
using System.Collections;
using System.Collections.Generic;


namespace LeetCode3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
//			TreeNode n1 = new TreeNode (1);
//			TreeNode n3 = new TreeNode (3);
//			TreeNode n5 = new TreeNode (5);
//			TreeNode n7 = new TreeNode (7);
//			TreeNode n10 = new TreeNode (10);
//			TreeNode n15 = new TreeNode (15);
//
//			n7.left = n3;
//			n7.right = n10;
//			n3.left = n1;
//			n3.right = n5;
//			n10.right = n15;
//
//			BstOp o = new BstOp ();
//			Console.WriteLine (o.KthSmallest(n7,6));

			int[] arr = new int[]{ 2,4,2,4,3};
			Console.WriteLine (SingleNumber(arr));

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
