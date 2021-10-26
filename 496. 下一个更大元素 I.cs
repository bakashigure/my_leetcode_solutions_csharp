#if false
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Solution
{
    public int[] NextGreaterElement(int[] nums1, int[] nums2)
    {
        Stack<int> s = new();
        Dictionary<int, int> d = new Dictionary<int, int>();
        int n = nums2.Length;
        for (int i = n - 1; i >= 0; --i)
        {
            int num = nums2[i];
            while (s.Count > 0 && num > s.Peek())
                s.Pop();
            d[num] = s.Count > 0 ? s.Peek() : -1;
            s.Push(num);
        }

        int[] res = new int[nums1.Length];
        for (int i = 0; i < nums1.Length; i++)
            res[i] = d[nums1[i]];
        return res;
    }
}

#endif