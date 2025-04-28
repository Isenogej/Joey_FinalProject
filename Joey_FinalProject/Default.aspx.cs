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
            lblheader.Text = "420. Strong Password Checker ";
            lbldescription.Text = "You enter a password that has to be at least 6 characters and at most 20 charaacters, It has to contain at least one lowercase letter and it does not contain three repeating characters in a row for the password to be strong. This code will output a number if it is correct.  ";
            lbltstcase.Text = "jerseymike, 123478, andrew";
            lbloutput.Text = "2, 2, 2";
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