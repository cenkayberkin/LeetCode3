using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;


namespace LeetCode3
{
	public class WordOps
	{
		int maxWord;

		public WordOps ()
		{
			
		}

		public bool wordBreakAnother(string s, ISet<string> dict) {
			// IMPORTANT: Please reset any member data you declared, as
			// the same Solution instance will be reused for each test case.
			if (string.IsNullOrEmpty(s)){return false;}
			bool[,] mp = new bool[s.Length,s.Length];

			for (int i=0;i<s.Length;i++){
				for (int j=i;j<s.Length;j++){
					if (dict.Contains(s.Substring(i,j-i+1))){
						mp[i,j]=true;
					}
				}
			}

			for (int i=0;i<s.Length;i++){
				for (int j=i;j<s.Length;j++){
					for(int k=i;k<j;k++){
						if (!mp[i,j]){
							mp [i, j] = mp [i, k] && mp[k+1,j];
						}
					}
				}
			}

			return mp[0,s.Length -1];
		}

		public bool WordBreak(string s, ISet<string> wordDict)
		{	
			foreach (var item in wordDict) {
				if (item.Length > maxWord) {
					maxWord = item.Length;
				}				
			}
			return WordBreak (s, wordDict, 0); 
		}

		public bool WordBreak(string s, ISet<string> wordDict,int index) 
		{
			if (GetCandidates (s, index, wordDict).Count == 0) {
				if (index == s.Length ) {
					Console.WriteLine ("sucess");
					return true;
				}else {
					return false;
				}

			} 

			var list = GetCandidates (s, index, wordDict);
			foreach (var item in list) {
				index = index + item.Length;
				Console.WriteLine (item);
				if (WordBreak (s, wordDict, index)) {
					return true;
				}
				index -= item.Length;
			}
			return false;
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

//		public List<string> GetCandidates2(string s, int start,ISet<string> wordDict)
//		{
//			List<string> result = new List<string> ();
//
//			int i = 1;
//			while(i <= maxWord && start + i <= s.Length ){
//				if (wordDict.Contains(s.Substring (start, i))) {
//					result.Add (s.Substring (start, i));
//				}
//				i++;
//			}
//			return result.OrderByDescending (a => a.Length).ToList<string> ();
//		}
	}
}

