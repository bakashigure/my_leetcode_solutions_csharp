#if false
using System.Linq;


public class Solution
{
    public int MinMoves(int[] nums)
    {
        int min = nums.Min();
        int cnt = 0;
        for(int i=0;i<nums.Length;i++)
        {
            cnt += nums[i] - min;
        }
        return cnt;
    }
}
#endif