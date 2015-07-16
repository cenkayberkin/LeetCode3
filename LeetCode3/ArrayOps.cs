using System;

namespace LeetCode3
{
	public class ArrayOps
	{
		public ArrayOps ()
		{
		}

		public int FindMin(int[] nums) 
		{
			if (nums.Length == 1) {
				return nums [0];
			}

			int lo = 0;
			int hi = nums.Length - 1;

			int mid = (lo + hi) / 2;

			while (lo <= hi) 
			{
				mid = (lo + hi) / 2;

				if (mid + 1 == nums.Length) {
					if (nums [mid] < nums [mid - 1]) {
						return nums [mid ];	
					} else {
						return nums [mid -1];	
					}
				}

				if (mid == 0) {
					if (nums [mid] < nums [mid + 1]) {
						return nums [mid];

					} else {
						return nums [mid + 1];
					}
				}

				if (nums[mid] < nums[mid -1] && nums[mid] < nums[mid +1]) {
					return nums [mid];
				}

				if (nums[mid] < nums[hi]) {
					// right is sorted.
					// go left.
					hi = mid -1;

				}else
				{
					//left is sorted.
					// go right.
					lo = mid + 1;
				}
			}

			return -1;
		}
	}
}

