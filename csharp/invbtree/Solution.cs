/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
using System;

namespace invbtree{
    public class Solution {
        public TreeNode InvertTree(TreeNode root) {
            if(root != null){
                var left = root.left;
                var right = root.right;
                root.left = right;
                root.right = left;
                InvertTree(root.left);
                InvertTree(root.right);
            }
            return root;
        }
    }
}
