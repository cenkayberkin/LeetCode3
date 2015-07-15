using System;
using System.Collections;
using System.Collections.Generic;


namespace LeetCode3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			WordOps o = new WordOps ();
			HashSet<string> set = new HashSet<string> ();
			set.Add ("cat");
			set.Add ("cats");
			set.Add ("and");
			set.Add ("sand");
			set.Add ("dog");

			WordBreak2 b = new WordBreak2 ();
			var result = b.WordBreak ("catsanddog", set);

			foreach (var item in result) {
				Console.WriteLine (item);
			}

//			Console.WriteLine (o.WordBreak ("aaaaaaa", set));

//			Console.WriteLine (o.wordBreakAnother ("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaab", set));
//			for (int i = 0; i < 1000; i++) {
//				Test ();
//					
//			}

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
