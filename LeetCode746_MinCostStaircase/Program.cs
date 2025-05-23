﻿Staircase sc = new Staircase();
var arr = new int[] { 5, 2, 3, 12, 20, 3, 1 };
int min = sc.MinCostClimbingStairs(arr);
Console.WriteLine(min);

public class Staircase
{
    public int MinCostClimbingStairs(int[] cost)
    {
        int n = cost.Length;
        for (int i = 2; i < n; i++)
        {
            cost[i] += Math.Min(cost[i - 1], cost[i - 2]);
        }

        return Math.Min(cost[n - 1], cost[n - 2]);
    }
}



