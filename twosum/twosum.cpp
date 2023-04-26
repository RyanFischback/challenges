#include "twosum.h"
#include <iostream>

std::vector<int> twoSum(std::vector<int>& nums, int target){
    std::vector<int> result;
    std::vector<int> firstHalf(nums.begin(), nums.begin() + nums.size() / 2);
    std::vector<int> secondHalf(nums.begin() + nums.size() / 2, nums.end());
    int num1 = 0;

    for(int i = 0; i < nums.size(); i++){
        for(int j = i; j < nums.size() - 1; j++){
            
        }
        if(target - 0 == nums[i]){
            result.push_back(i); // add the index of this value, not the actual value
        }
    }
    return result;
}