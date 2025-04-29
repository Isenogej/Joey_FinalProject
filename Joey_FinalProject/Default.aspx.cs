/*
File Name: Default.aspx.cs

*Name: Jeff Whitcomb, Alec Bender, Evan Isenogle, Andrew Moore
*email: whitcojr@mail.uc.edu, moore6aw@mail.uc.edu. benderax@mail.uc.edu, isenogej@mail.uc.edu 
*Assignment Number: Assignment Final Project
*Due Date: 4/29/2025
*Course #/Section: IS 3050 001
* Semester / Year: Spring 2025
*Brief Description of the assignment: Create an aspx webpage with c# to display the hard leet code problems we completed. 

*Brief Description of what this module does. Introduces leetcode as a practice platform for coding, and shows how to use github to push and pull commits among a team. 
*Citations: 
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Joey_FinalProject
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void EVbtn_Click(object sender, EventArgs e)
        {
            lblheader.Text = "65. Valid Number ";
            lbldescription.Text = " ";
            lbltstcase.Text = " ";
            Evan.Solution solution = new Evan.Solution();


            string[] testInputs = { "90" };
            bool[] expectedOutputs = { true };

            string results = "";
            for (int i = 0; i < testInputs.Length; i++)
            {
                bool result = solution.IsNumber(testInputs[i]);
                results += $"Test {i + 1}: Input=\"{testInputs[i]}\" => Result={result} (Expected={expectedOutputs[i]})<br/>";
            }

            lbloutput.Text = results;
        }

        protected void Abtn_Click(object sender, EventArgs e)
        {

            lblheader.Text = "312. Burst Balloons";
            lbldescription.Text = "You are given n ballons, indexed from 0 to n-1. Each balloon is painted with a number on it represented by an array nums. You are asked to burst all the balloons. If you burst the ith balloon, you will get nums[i-1] * nums[i] * nums[i+1] coins. If i-1 or i+1 goes out of the bounds of the array, then treat it as if there is a balloon with a 1 painted on it. Return the maximum coins you can collect by bursting the balloons wisely.";
            lbltstcase.Text = "Test Case 1: [3,1,5,8] ";
           
            Alec alec = new Alec();
            int[] testInput = new int[] { 3, 1, 5, 8 };
            int result = alec.Coins(testInput);
            lbloutput.Text = "Result: " + result.ToString();

        }

        protected void ADbtn_Click(object sender, EventArgs e)
        {
           lblheader.Text = "420. Strong Password Checker ";
            lbldescription.Text = "You enter a password that has to be at least 6 characters and at most 20 charaacters, It has to contain at least one lowercase letter and it does not contain three repeating characters in a row for the password to be strong. This code will output a number if it is correct.  ";
            lbltstcase.Text = "jerseymike";
            Andrew andrew = new Andrew();

            string[] testPasswords = { "jerseymike" };

            int[] expectedOutputs = { 2 };

            string results = "";
            for (int i = 0; i < testPasswords.Length; i++)
            {
                int result = andrew.StrongPasswordChecker(testPasswords[i]);
                results += $"Test {i + 1}: Password=\"{testPasswords[i]}\" => Changes Needed={result} (Expected={expectedOutputs[i]})<br/>";
            }

            lbloutput.Text = results;
        }

        protected void Jbtn_Click(object sender, EventArgs e)
        {
            lblheader.Text = "87. Scramble String";
            lbldescription.Text = "We can scramble a string s to get a string t using the following algorithm: 1. If the length of the string is 1, stop. 2. If the length of the string is > 1, do the following:" +
                "-Split the string into two non-empty substrings at a random index, i.e., if the string is s, divide it to x and y where s = x + y. - Randomly decide to swap the two substrings or to keep them in the same order. i.e., after this step, s may become s = x + y or s = y + x."
                + "- Apply step 1 recursively on each of the two substrings x and y. Given two strings s1 and s2 of the same length, return true if s2 is a scrambled string of s1, otherwise, return false.";
            lbltstcase.Text = "Test Case 1: s1 = 'great' s2 = 'rgeat'";
            
            Jeff.Solution solution = new Jeff.Solution();

            string[,] testCases = { {"great", "rgeat", "True" } };

            string results = "";
            for (int i = 0; i < testCases.GetLength(0); i++)
            {
                string s1 = testCases[i, 0];
                string s2 = testCases[i, 1];
                bool expectedResult = bool.Parse(testCases[i, 2]);
                bool result = solution.IsScramble(s1, s2);
                results += $"Test {i + 1}: Input1=\"{s1}\", Input2=\"{s2}\" => Result={result} (Expected={expectedResult})<br/>";
            }

            lbloutput.Text = results;
        }
    }
}