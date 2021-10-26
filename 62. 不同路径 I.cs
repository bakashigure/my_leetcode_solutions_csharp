#if false
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Solution
{
    public int UniquePaths(int m, int n)
    {
        int[,] path = new int[m,n];
        path[0, 0] = 1;
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i > 0 && j > 0) path[i, j] = path[i - 1, j] + path[i, j - 1];
                else if (i > 0) path[i, j] = path[i - 1, j];
                else if (j > 0) path[i, j] = path[i, j - 1];
            }
        }
        return path[m - 1, n - 1];
    }
}

#endif
