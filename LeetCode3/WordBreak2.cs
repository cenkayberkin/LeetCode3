using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace LeetCode3
{
	public class WordBreak2
	{
		List<List<string>> finalList= new List<List<string>> ();

		public List<string> WordBreak(string s, ISet<string> wordDict)
		{	
			List<string> tmp = new List<string> ();
			WordBreak (s, wordDict, 0, tmp);
			List<string> result = new List<string> ();

			foreach (var item in finalList) {
				result.Add (string.Join (" ", item));
			}

			return result;
		}

		public void WordBreak(string s, ISet<string> wordDict,int index,List<string> words) 
		{
			if (GetCandidates (s, index, wordDict).Count == 0) {
				if (index == s.Length ) {
//					Console.WriteLine ("sucess");
					var tmp = words.ToList ();
					finalList.Add (tmp);
					return;
				}else {
					words.Clear ();
					return;
				}
			} 

			var list = GetCandidates (s, index, wordDict);
			foreach (var item in list) {
				index = index + item.Length;
				words.Add (item);
				WordBreak (s, wordDict, index,words);
				index -= item.Length;
				words.Remove (item);
			}
		}

		public List<string> GetCandidates(string s, int start,ISet<string> wordDict)
		{
			List<string> result = new List<string> ();

			foreach (var item in wordDict) {
				if (item.Length + start <= s.Length) {
					var newWord = s.Substring (start, item.Length);
					if (item == newWord) {
						result.Add (item);
					}	
				}
			}

			return result.OrderByDescending (a => a.Length).ToList<string> ();
		}
	}
}

