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
            lbloutput.Text = " ";
        }

        protected void Abtn_Click(object sender, EventArgs e)
        {
            lblheader.Text = " ";
            lbldescription.Text = " ";
            lbltstcase.Text = " ";
            lbloutput.Text = " ";
        }

        protected void ADbtn_Click(object sender, EventArgs e)
        {
            lblheader.Text = " ";
            lbldescription.Text = " ";
            lbltstcase.Text = " ";
            lbloutput.Text = " ";
        }

        protected void Jbtn_Click(object sender, EventArgs e)
        {
            lblheader.Text = "87. Scramble String";
            lbldescription.Text = "We can scramble a string s to get a string t using the following algorithm: 1. If the length of the string is 1, stop. 2. If the length of the string is > 1, do the following:" +
                "-Split the string into two non-empty substrings at a random index, i.e., if the string is s, divide it to x and y where s = x + y. - Randomly decide to swap the two substrings or to keep them in the same order. i.e., after this step, s may become s = x + y or s = y + x."
                + "- Apply step 1 recursively on each of the two substrings x and y. Given two strings s1 and s2 of the same length, return true if s2 is a scrambled string of s1, otherwise, return false.";
            lbltstcase.Text = "Test Case 1: s1 = 'great' s2 = 'rgeat'";
            lbloutput.Text = "Test Case 1 Output: true";
        }
    }
}