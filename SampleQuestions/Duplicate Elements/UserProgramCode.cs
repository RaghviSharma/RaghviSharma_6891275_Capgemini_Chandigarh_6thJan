using System;
using System.Collections.Generic;
using System.Text;

namespace Duplicate_Elements
{
    internal class UserProgramCode
    {
  //      public static int[] res(int[] arr)
  //      {
  //          if (arr.Length <= 1)
  //              return arr;
  //          Array.Sort(arr);
  //          int count = 0;
  //          for(int i=1;i<arr.Length;i++)
  //          {
  //              if (arr[i] != arr[i - 1])
  //                  count++;

  //          }
  //          int[] ans= new int[count];
  //          int idx = 0;
		//	for (int i = 1; i < arr.Length; i++)
		//	{
		//		if (arr[i] != arr[i - 1])
  //              {
  //                  ans[idx++] = arr[i];
  //              }       
		//	}
  //          return ans;
		//}
		public static int[] ToMaintainOrder(int[] arr)
		{
			HashSet<int> result = new HashSet<int>();
			List<int> list = new List<int>();
			foreach (int item in arr)
			{
				if (!result.Contains(item))
				{
					result.Add(item);
					list.Add(item);
				}
			}
			return list.ToArray();
		}
    }
}
