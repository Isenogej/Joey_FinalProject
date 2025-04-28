/*File Name: Jeff.cs
*Name: Jeff Whitcomb 
*email:  whitcojr@mail.uc.edu
*Assignment Number: Assignment Final Project
*Due Date: 4/29/2025
*Course #/Section:   IS 3050 Section 01
* Semester / Year:   Spring 2025
*Brief Description of the assignment:  In this assignment we are tasked with solving a hard LeetCode probelem to display the test case and the result.

*Brief Description of what this module does: This module outputs the maximum coins you can collect by bursting the balloons wisely.
*Citations: Chat GPT: https://chatgpt.com/
            
 *Anything else that's relevant: NA
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joey_FinalProject
{
    public class Jeff
    {
        

public class Solution
    {
        private Dictionary<string, bool> memo = new Dictionary<string, bool>();

        public bool IsScramble(string s1, string s2)
        {
            if (s1 == s2)
                return true;

            if (s1.Length != s2.Length)
                return false;

            string key = s1 + "_" + s2;
            if (memo.ContainsKey(key))
                return memo[key];

            // Check if s1 and s2 have the same character counts
            int[] letters = new int[26];
            for (int i = 0; i < s1.Length; i++)
            {
                letters[s1[i] - 'a']++;
                letters[s2[i] - 'a']--;
            }
            foreach (int count in letters)
            {
                if (count != 0)
                {
                    memo[key] = false;
                    return false;
                }
            }

            for (int i = 1; i < s1.Length; i++)
            {
                // No swap scenario
                if (IsScramble(s1.Substring(0, i), s2.Substring(0, i)) &&
                    IsScramble(s1.Substring(i), s2.Substring(i)))
                {
                    memo[key] = true;
                    return true;
                }

                // Swap scenario
                if (IsScramble(s1.Substring(0, i), s2.Substring(s2.Length - i)) &&
                    IsScramble(s1.Substring(i), s2.Substring(0, s2.Length - i)))
                {
                    memo[key] = true;
                    return true;
                }
            }

            memo[key] = false;
            return false;
        }
    }

}
}