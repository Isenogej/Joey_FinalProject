<!--
File Name: Default.aspx

*Name: Jeff Whitcomb, Alec Bender, Evan Isenogle, Andrew Moore
*email: whitcojr@mail.uc.edu, moore6aw@mail.uc.edu. benderax@mail.uc.edu, isenogej@mail.uc.edu
*Assignment Number: Assignment Final Project
*Due Date: 4/29/2025
*Course #/Section: IS 3050 001
* Semester / Year: Spring 2025
*Brief Description of the assignment: Create an aspx webpage with c# to display the hard leet code problems we completed. 

*Brief Description of what this module does. Introduces leetcode as a practice platform for coding, and shows how to use github to push and pull commits among a team. 
*Citations: 
-->
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Joey_FinalProject.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div >
           <div class="headerintro">
            <asp:Label ID="lblname" runat="server" Text="Group Name : Joey "></asp:Label>
             </div>
           
          <div class="body">
           <asp:Label ID="lblbody" runat="server" Text="We are group 6 and this is our final project, Here are the 'Hard' Problems we solved to prove ourselves "></asp:Label>
          </div>
            <br />
        <div class="buttons">
        <asp:Button ID="Evanbtn" runat="server" Text="Evan " OnClick="EVbtn_Click" />
        <asp:Button ID="Alecbtn" runat="server" Text="Alec" OnClick="Abtn_Click" />
        <asp:Button ID="Andrewbtn" runat="server" Text="Andrew" OnClick="ADbtn_Click" />
        <asp:Button ID="Jeffbtn" runat="server" Text="Jeff" OnClick="Jbtn_Click" />
        </div>
        
        
        </div>
        <div class="lblheader">
         <asp:Label ID="lblheader" runat="server" Text=""></asp:Label> 
         </div>

        <br />

        <div class="lbldescription">
        <asp:Label ID="lbldescription" runat="server" Text=""></asp:Label> 
        </div>
            
            <br />
        <div class="lbltstcase">
            <asp:Label ID="lbltstcase" runat="server" Text=""></asp:Label>

        </div>
            
            <br />
        <div class="lbloutput">
            <asp:Label ID="lbloutput" runat="server" Text=""></asp:Label> 

        </div>
            
            
         
    </form> 
</body>
</html>
