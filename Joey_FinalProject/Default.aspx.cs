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
using System.Reflection.Emit;
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
            lbldescription.Text = "Given a string s, return whether s is a valid number.\r\n\r\nFor example, all the following are valid numbers: \"2\", \"0089\", \"-0.1\", \"+3.14\", \"4.\", \"-.9\", \"2e10\", \"-90E3\", \"3e+7\", \"+6e-1\", \"53.5e93\", \"-123.456e789\", while the following are not valid numbers: \"abc\", \"1a\", \"1e\", \"e3\", \"99e2.5\", \"--6\", \"-+3\", \"95a54e53\".\r\n\r\nFormally, a valid number is defined using one of the following definitions:\r\n\r\nAn integer number followed by an optional exponent.\r\nA decimal number followed by an optional exponent.\r\nAn integer number is defined with an optional sign '-' or '+' followed by digits.\r\n\r\nA decimal number is defined with an optional sign '-' or '+' followed by one of the following definitions:\r\n\r\nDigits followed by a dot '.'.\r\nDigits followed by a dot '.' followed by digits.\r\nA dot '.' followed by digits.\r\nAn exponent is defined with an exponent notation 'e' or 'E' followed by an integer number.\r\n\r\nThe digits are defined as one or more digits. ";
            lbltstcase.Text = " Test Case 1: '90'   Test Case 2: '45'  Test Case 3: 'G'";
            lbloutput.Text = " Test Case 1 returns: 'true'   Test Case 2 output: 'True'   Test Case 3 output: 'False' ";
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
            lbltstcase.Text = "jerseymike, 123478, andrew";
            lbloutput.Text = "2, 2, 2";
        }

        protected void Jbtn_Click(object sender, EventArgs e)
        {
            lblheader.Text = "87. Scramble String";
            lbldescription.Text = "We can scramble a string s to get a string t using the following algorithm: 1. If the length of the string is 1, stop. 2. If the length of the string is > 1, do the following:" +
                "-Split the string into two non-empty substrings at a random index, i.e., if the string is s, divide it to x and y where s = x + y. - Randomly decide to swap the two substrings or to keep them in the same order. i.e., after this step, s may become s = x + y or s = y + x."
                + "- Apply step 1 recursively on each of the two substrings x and y. Given two strings s1 and s2 of the same length, return true if s2 is a scrambled string of s1, otherwise, return false.";
            lbltstcase.Text = "Test Case 1: s1 = 'great' s2 = 'rgeat'";

            Jeff jeff = new Jeff();
            Jeff.Solution solution = new Jeff.Solution();
            bool result = solution.IsScramble("great", "rgeat");
            lbloutput.Text = "Result: " + result; ;



        }
    }
}