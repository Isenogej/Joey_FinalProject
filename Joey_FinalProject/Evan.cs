/* 
* File Name: Evan.cs
*Name: Evan Isenogle 
*email:  isenogej@mail.uc.edu
*Assignment Number: Assignment Final Project 
*Due Date: 04-29-2025
*Course #/Section:   Is 3050 (001)
* Semester / Year:   Spring 2025
*Brief Description of the assignment:  Final Project using Leet code to try out 'Hard' C# problems while using Github to collaborate our changes together.

*Brief Description of what this module does. This module is geared to teach us how to collaborate on group projects in Visual studio using Git hub. 
*Citations: Chatgpt.Com ( inserted code into Chat gpt for code checking and demonstrations)
*Anything else that's relevant:
*
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joey_FinalProject
{
    public class Evan
    {
        public class Solution
        {
            public bool IsNumber(string s)
            {
                s = s.Trim();
                if (s.Length == 0) return false;

                bool seenDigit = false;
                bool seenDot = false;
                bool seenE = false;

                for (int i = 0; i < s.Length; i++)
                {
                    char c = s[i];

                    if (char.IsDigit(c))
                    {
                        seenDigit = true;
                    }
                    else if (c == '+' || c == '-')
                    {
                        if (i > 0 && s[i - 1] != 'e' && s[i - 1] != 'E')
                        {
                            return false;
                        }
                    }
                    else if (c == '.')
                    {
                        if (seenDot || seenE)
                        {
                            return false;
                        }
                        seenDot = true;
                    }
                    else if (c == 'e' || c == 'E')
                    {
                        if (seenE || !seenDigit)
                        {
                            return false;
                        }
                        seenE = true;
                        seenDigit = false; 
                    }
                    else
                    {
                        return false;
                    }
                }

                return seenDigit;
            }
        }

    }
}