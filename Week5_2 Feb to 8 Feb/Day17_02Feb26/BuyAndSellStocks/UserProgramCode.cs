using System;
using System.Collections.Generic;
using System.Text;

namespace BuyAndSellStocks
{
    internal class UserProgramCode
    {
        public static int Profit(int[] nums)
        {
            int buy_price = int.MaxValue;
            
            int mp = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                   buy_price=Math.Min(buy_price, nums[i]);
                   int profit = nums[i] - buy_price;
                   mp = Math.Max(mp, profit);
            }
            return mp;
        }
    }
}
       
            
       