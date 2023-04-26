using System;

namespace stocks{
    public class Program {
        public static void Main(string[] args){
            Solution solution = new Solution();
            Console.WriteLine(solution.MaxProfit(new int[]{7,1,5,3,6,4}));
        }
    }
}
