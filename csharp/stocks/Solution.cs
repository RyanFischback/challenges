using System;
namespace stocks{
    public class Solution {
        public int MaxProfit(int[] prices) {
            int start = 0;
            int maxProfit = 0;
            for(int end = 0; end < prices.Length; end++){
                var left = prices[start];
                var right = prices[end];
                if(left < right){
                    maxProfit = Math.Max(right - left, maxProfit);
                }else{
                    start = end;
                }
            }
            return maxProfit;
        }
    }
}
