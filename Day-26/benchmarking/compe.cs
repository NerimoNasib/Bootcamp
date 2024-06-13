using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;


public class Solution
{
    public int[] nums = [2,7,11,15,3,4,5,6,3,1,2,3,4,6,7,4,2,7,1,19,4,5,6,7,19,12,7,2,3,6,1,2,1,8,9,1,1,3,4,5,2,11,23,24,262,11436,34,634,12,24,90,23,24,25,46,11,9,0,1,2,3,6];
    public int target = 9;
    [Benchmark]
    public int[] TwoSum()
    {
        Dictionary<int, int> map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            map[nums[i]] = i;
        }
        return new int[0];
    }
    [Benchmark]
    public int[] TwoSumBruteForce()
    {
        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                    return new int[] { i, j };
            }
        }
        return null;
    }
}