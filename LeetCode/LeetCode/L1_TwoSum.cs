using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    /**
     * 给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 target  
     * 的那 两个 整数，并返回它们的数组下标。
     * **/
    //已通过测试
    public class L1_TwoSum
    {
        //以下方法比较节省内存，不用把数据存到字典中
        public int[] TwoSum(int[] nums, int target)
        {
            for(int i=0;i<nums.Length-1;i++)
            for(int j=i+1;j<nums.Length;j++)
            {
                    if (nums[i] + nums[j]==target)
                        return new int[] {i,j};
            }
            return null;
        }
        //使用字典的方法也测试通过，只是没有快多少。
        public int[] TwoSum2(int[] nums, int target)
        {
            Dictionary<int,int> dic= new Dictionary<int,int>();
            int idx;
            for(int i=0;i<nums.Length;i++)
            {
                if (dic.TryGetValue(target - nums[i],out idx))
                {
                    return new int[] {idx,i};
                }
                else
                {
                    //把值和下标存入字典
                    //注意下标赋值方式如果还没有该键，则会添加该键值对，如果已存在该键，则会修改对应的值
                    dic[nums[i]] = i;
                }
            }

            return null;
        }
    }
}

/**

class Solution {
    public int[] twoSum(int[] nums, int target) {
        HashMap<Integer,Integer> map=new HashMap<>();
    	for(int i=0;i<nums.length;i++)
    	{
    		Integer idx=map.get(target-nums[i]);
    		if(idx!=null)
    			return new int[]{idx,i};
    		map.put(nums[i], i);
    	}

		return null;
    }
}

**/