/*
 * @lc app=leetcode.cn id=242 lang=csharp
 *
 * [242] 有效的字母异位词
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> dic = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dic.ContainsKey(s[i]))
            {
                dic[s[i]]++;
            }
            else
            {
                dic.Add(s[i], 1);
            }
        }
        for (int j = 0; j < t.Length; j++)
        {
            if (dic.ContainsKey(t[j]))
            {
                if (dic[t[j]] != 1)
                {
                    dic[t[j]]--;
                } 
                else
                {
                    dic.Remove(t[j]);
                }
            }
            else
            {
                return false;
            }      
        }
        return true;

    }
}
// @lc code=end

