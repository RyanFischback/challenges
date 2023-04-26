#include <iostream>
#include <vector>
#include "twosum.h"

int main(){

    //std::cout << "Hello, World";
    
    std::vector<int> input = {2, 7, 11, 15};
    std::vector<int> input2 = {3, 2, 4};
    std::vector<int> input3 = {3, 3};

    twoSum(input, 9); // 0, 1
    twoSum(input, 6); // 1, 2
    twoSum(input, 6); // 0, 1

    return 0;
}