using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //最长回文子串
    //给你一个字符串 s，找到 s 中最长的回文子串。
    //如果字符串的反序与原始字符串相同，则该字符串称为回文字符串。
    public class L5_longestPalindrome { 
        /**
         * 动态规划
         * 我们定义 dp[i][j] 的意思为字符串区间 [i, j] 是否为回文串，
         * 那么我们分三种情况：
            1. 当 i == j 时，那么毫无疑问 dp[i][j] = true；
            2. 当 i + 1 == j 时，那么 dp[i][j] 的值取决于 s[i] == s[j]；
            3. 当 i + 1 < j 时，那么 dp[i][j] 的值取决于 dp[i + 1][j - 1] && s[i] == s[j]。
         根据以上的动态转移方程，我们的问题即可迎刃而解，时间复杂度的话显而易见，也是 O(n^2)。
         */
        public string LongestPalindrome(string s)
        {
            int len = s.Length;
            if (len <= 1) return s;
            int st = 0, end = 0;
            bool[,] dp = new bool[len,len];//数组保留前面的计算结果
            for (int i = 0; i < len; i++)
            {
                dp[i,i] = true;
                for (int j = 0; j < i; j++)
                {
                    if (j + 1 == i)
                    {
                        dp[j,i] = s[j] == s[i];
                    }
                    else
                    {
                        dp[j,i] = dp[j + 1,i - 1] && s[j] == s[i];
                    }
                    if (dp[j,i] && i - j > end - st)
                    {
                        st = j;
                        end = i;
                    }
                }
            }
            return s.Substring(st, end-st + 1);
        }

        public static void Test() //测试
        {
            L5_longestPalindrome l5= new L5_longestPalindrome();
            string s = "";
            s = "babad";
            Console.WriteLine(s+"->"+ l5.LongestPalindrome(s));
            
            s = "cbbd";
            Console.WriteLine(s + "->" + l5.LongestPalindrome(s));
        }
    }
}