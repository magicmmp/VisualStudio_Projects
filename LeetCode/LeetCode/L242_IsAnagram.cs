using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class L242_IsAnagram
    {
        /**
         * 字符串只包含小写字符，总共有 26 个小写字符。可以用 Hash Table 来映射字符与出现次数，
         * 因为键值范围很小，因此可以使用长度为 26 的整型数组对字符串出现的字符进行统计，
         * 比较两个字符串出现的字符数量是否相同。
         */
        public bool IsAnagram(string s, string t)
        {
            if(s.Length!=t.Length)
            {
                return false;
            }
            int[] counts= new int[26];
            for(int i=0;i<s.Length;i++)
            {
                counts[s[i]-'a']++;
            }
            for (int i = 0; i < t.Length; i++)
            {
                counts[t[i] - 'a']--;
            }
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] != 0)
                    return false;
            }
            return true;
        }
    }
}

