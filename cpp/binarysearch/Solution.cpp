#include <vector>

class Solution {
public:
    int search(std::vector<int>& nums, int target) {
        int left = 0;
        int right = nums.size() - 1;
        while(left <= right){
            int tmp = left + (right - left) / 2;
            if(nums[tmp] < target){
                left = tmp + 1;
            } else if (nums[tmp] > target){
                right = tmp - 1;
            } else{
                return tmp;
            }
        }
        return -1;
    }
};