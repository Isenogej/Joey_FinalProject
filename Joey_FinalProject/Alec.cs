/*File Name: Alec.cs
*Name: Alec Bender
*email:  benderax@mail.uc.edu
*Assignment Number: Assignment Final Project
*Due Date: 4/29/2025
*Course #/Section:   IS 3050 Section 01
* Semester / Year:   Spring 2025
*Brief Description of the assignment:  In this assignment we are tasked with solving a hard LeetCode probelem to display the test case and the result.

*Brief Description of what this module does: This module outputs the maximum coins you can collect by bursting the balloons wisely.
*Citations: Arrays: https://www.w3schools.com/cs/cs_arrays.php
            Dynamic Programming Tables: https://medium.com/@hanxuyang0826/mastering-dynamic-programming-in-c-leetcode-problems-and-solutions-feacfe5418b6
            Chat GPT: https://chatgpt.com/
 *Anything else that's relevant: NA
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joey_FinalProject
{
    public class Alec
    {
        public int Coins(int[] nums)
        {
            int n = nums.Length;
            int[] balloons = new int[n + 2];
            balloons[0] = 1;
            balloons[n + 1] = 1;

            for (int i = 0; i < n; i++)
            {
                balloons[i + 1] = nums[i];

            }
            int[,] dp = new int[n + 2,n + 2];
            for (int length = 1; length <= n; length++)
            {
                for (int left = 1; left <= n - length + 1; left++)
                {
                    int right = left + length - 1;
                    for (int i = left; i <= right; i++)
                    {
                        dp[left, right] = Math.Max(dp[left, right], dp[left, i - 1] + dp[i + 1, right] + balloons[left - 1] * balloons[i] * balloons[right + 1]);
                    }
                }
            }
            return dp[n, 1];
        }
    }
}