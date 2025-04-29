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
            lblheader.Text = " ";
            lbldescription.Text = " ";
            lbltstcase.Text = " ";
            lbloutput.Text = " ";
        }

        protected void Jbtn_Click(object sender, EventArgs e)
        {
            lblheader.Text = " ";
            lbldescription.Text = " ";
            lbltstcase.Text = " ";
            lbloutput.Text = " ";
        }
    }
}