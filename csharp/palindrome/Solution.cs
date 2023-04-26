using System;
using System.Linq;

namespace pally{
    public class Solution {
        public bool IsPalindrome(string s) {
            char[] arr = s.Where(c => (char.IsLetterOrDigit(c))).ToArray(); 
            s = new string(arr).ToLower();
            for(int i = 0; i < s.Length; i++){
                if(s[i] != s[s.Length-i-1]){
                    return false;
                }
            }
            return true;
        }
    }
}  
