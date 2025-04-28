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
    </form> 
</body>
</html>
