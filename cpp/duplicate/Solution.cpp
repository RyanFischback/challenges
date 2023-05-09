#include <vector>
#include <unordered_map>

class Solution {
public:
    bool containsDuplicate(std::vector<int>& nums) {
        //2 values twice in nums? return true; else return false;
        std::unordered_map<int, int> map;
        for(int i : nums){
            map[i] = map[i] + 1;
        }
        for(auto i : map){
            if(i.second>=2){
                return true;
            }
        }
        return false;
    }
};