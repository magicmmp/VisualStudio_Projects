using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public  class L69_MySqrt
    {
        public static int MySqrt(int x)
        {
            //二分查找求平方根
            if (x <= 1)
                return x;
            int L = 1;
            int H = x;
            int mid;
            while(L<=H)
            {
                mid = L + (H-L)/2;
                int tmp = x / mid;
                if (tmp == mid)
                    return mid;
                else if (tmp < mid)
                    H = mid - 1;
                else
                    L = mid + 1;
            }
            return H;//注意这里返回H，否则有部分结果出错2023-1-5
        }

        public static void Test()
        {
            for(int i=0; i<101;i++)
            {
                int sqrt = L69_MySqrt.MySqrt(i);
                Console.WriteLine("sqrt({0})={1}", i, sqrt);
            }
            Console.ReadKey();
        }
    }
}
/**
 public int mySqrt(int x) {
    if(x <= 1) return x;
    int l = 1, h = x;
    while(l <= h){
        int mid = l + (h - l) / 2;
        int sqrt = x / mid;
        if(sqrt == mid) return mid;
        else if(sqrt < mid) h = mid - 1;
        else l = mid + 1;
    }
    return h;
}
 */
