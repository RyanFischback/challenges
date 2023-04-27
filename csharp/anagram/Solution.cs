// Given two strings s and t, return true if t is an anagram of s, and false otherwise.

// An Anagram is a word or phrase formed by rearranging the letters of a different word or phrase, typically using all the original letters exactly once.

using System;
using System.Linq;

public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length){return false;}
        char[] s1 = s.ToLower().ToCharArray();
        char[] t1 = t.ToLower().ToCharArray();

        Array.Sort(s1);
        Array.Sort(t1);

        for(int i = 0; i < s1.Length; i++){
            if(s1[i] != t1[i]){return false;}
        }
        return true;
    }
}