using System;

namespace LeetCode3
{
	 public class ListNode {
		public int val;
		public ListNode next;
		public ListNode(int x) { val = x; }
	 }

	public class ListOp
	{
		public ListOp ()
		{
		}

		public void DeleteNode(ListNode node) {
			if (node == null) {
				return;
			}

			node.val = node.next.val;
			node.next = node.next.next;
		}
	}
}

