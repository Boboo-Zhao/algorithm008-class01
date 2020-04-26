/*
 * @lc app=leetcode.cn id=1 lang=csharp
 *
 * [1] 两数之和
 */

// @lc code=start
//两边哈希表
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dic = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dic.ContainsKey(nums[i]))
            {
                if (nums[i] * 2 == target) //如果有重复项，且结果中包含了重复项，则最终答案中比存在此项
                {
                    return new int[] {i, dic[nums[i]]};
                }
            }
            else
            {
                dic.Add(nums[i], i);
            }
        }
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (dic.ContainsKey(complement) && dic[complement] != i)
            {
                return new int[] {i, dic[complement]};
            }
        }
        return new int[] {0, 0};
        
    }
}
// @lc code=end

