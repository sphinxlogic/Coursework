<%-- Fig. 22.18: WebControls.aspx --%>
<%-- Registration form that demonstrates web controls. --%>
<%@ Page Language="C#" AutoEventWireup="true"
   CodeFile="WebControls.aspx.cs" Inherits="WebControls" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" 
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Web Controls Demonstration</title>
      <style type="text/css">
         .style1
      {
         color: #006699;
      }
      .style2
      {
         width: 100%;
      }
   </style>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h3>This is a sample registration form.</h3>
      <p><i>Please fill in all fields and click Register.</i></p>
      <p>
         <asp:Image ID="userInformationImage" runat="server" 
           ImageUrl="~/Images/user.png" />&nbsp;
         <span class="style1">Please fill out the fields below.</span>
      </p>
      <table class="style2">
         <tr>
            <td valign="top" style="width: 225px">
               <asp:Image ID="firstNameImage" runat="server"
                  ImageUrl="~/Images/fname.png" />
               <asp:TextBox ID="firstNameTextBox" runat="server">
               </asp:TextBox>
            </td>
            <td valign="top">
               <asp:Image ID="lastNameImage" runat="server"
                  ImageUrl="~/Images/lname.png" />
               <asp:TextBox ID="lastNameTextBox" runat="server">
               </asp:TextBox>
            </td>
         </tr>
         <tr>
            <td valign="top" style="width: 225px">
               <asp:Image ID="emailImage" runat="server"
                  ImageUrl="~/Images/email.png" />
               <asp:TextBox ID="emailTextBox" runat="server">
               </asp:TextBox>
            </td>
            <td valign="top">
               <asp:Image ID="phoneImage" runat="server"
                  ImageUrl="~/Images/phone.png" />
               <asp:TextBox ID="phoneTextBox" runat="server">
               </asp:TextBox>
               <br />
               Must be in the form (555) 555-5555.
            </td>
         </tr>
      </table>
      <p>
         <asp:Image ID="publicationsImage" runat="server" 
            ImageUrl="~/Images/publications.png" />&nbsp;
         <span class="style1">
            Which book would you like information about?</span>
      </p>
      <p>
         <asp:DropDownList ID="booksDropDownList" runat="server">
            <asp:ListItem>Visual Basic 2008 How to Program</asp:ListItem>
            <asp:ListItem>Visual C# 2008 How to Program</asp:ListItem>
            <asp:ListItem>Java How to Program 6e</asp:ListItem>
            <asp:ListItem>C++ How to Program 5e</asp:ListItem>
            <asp:ListItem>C How to Program 5e</asp:ListItem>
            <asp:ListItem>Internet and World Wide Web How to Program 4e
               </asp:ListItem>
         </asp:DropDownList>
      </p>
      <p>
         <asp:HyperLink ID="booksHyperLink" runat="server" 
            NavigateUrl="http://www.deitel.com" Target="_blank">
            Click here to view more information about our books
         </asp:HyperLink>
      </p>
      <p>
         <asp:Image ID="operatingSystemImage" runat="server" 
            ImageUrl="~/Images/os.png" />&nbsp;
         <span class="style1">Which operating system are you using?
            </span>
      </p>
      <p>
         <asp:RadioButtonList ID="operatingSystemRadioButtonList"
            runat="server">
            <asp:ListItem>Windows Vista</asp:ListItem>
            <asp:ListItem>Windows XP</asp:ListItem>
            <asp:ListItem>Mac OS X</asp:ListItem>
            <asp:ListItem>Linux</asp:ListItem>
            <asp:ListItem>Other</asp:ListItem>
         </asp:RadioButtonList>
      </p>
      <p>
         <asp:Button ID="registerButton" runat="server" 
            Text="Register" />
      </p>
   </div>
   </form>
</body>
</html>