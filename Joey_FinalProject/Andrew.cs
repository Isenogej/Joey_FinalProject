/*
File Name:Andrew.cs

* Name:Andrew Moore
* email: moore6aw@mail.uc.edu
* Assignment Number: Final Project
* Due Date: 04/28/2025
* Course #/Section:  IS3050/001
* Semester/Year:  Spring 2025
* Brief Description of the assignment: Making a project that shows our C# code by using buttons

* Brief Description of what this module does. Creating a password checker that checks for the strength of a password using C#.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Joey_FinalProject
{
    public class Andrew
    {
        public int StrongPasswordChecker(string password)
        {
            int n = password.Length;
            bool hasLower = false, hasUpper = false, hasDigit = false;
            List<int> repeats = new List<int>();

            for (int i = 0; i < n;)
            {
                char c = password[i];
                if (char.IsLower(c)) hasLower = true;
                if (char.IsUpper(c)) hasUpper = true;
                if (char.IsDigit(c)) hasDigit = true;

                int j = i;
                while (i < n && password[i] == password[j]) i++;
                int len = i - j;
                if (len >= 3) repeats.Add(len);
            }

            int missingTypes = 0;
            if (!hasLower) missingTypes++;
            if (!hasUpper) missingTypes++;
            if (!hasDigit) missingTypes++;

            if (n < 6)
            {
                return Math.Max(missingTypes, 6 - n);
            }
            else if (n <= 20)
            {
                int replace = 0;
                foreach (int len in repeats)
                {
                    replace += len / 3;
                }
                return Math.Max(missingTypes, replace);
            }
            else
            {
                int overLen = n - 20;
                int replace = 0;
                int[] mods = new int[3];

                foreach (int len in repeats)
                {
                    replace += len / 3;
                    mods[len % 3]++;
                }

                int remainDelete = overLen;

                for (int i = 0; i < 3 && remainDelete > 0; i++)
                {
                    while (mods[i] > 0 && remainDelete >= i + 1)
                    {
                        remainDelete -= i + 1;
                        replace--;
                        mods[i]--;
                    }
                }

                replace -= Math.Min(replace, remainDelete / 3);

                return overLen + Math.Max(missingTypes, replace);
            }
        }
    }
}