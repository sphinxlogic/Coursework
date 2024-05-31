<%-- Fig. 22.29: Options.aspx --%>
<%-- Allows client to select programming languages and access book --%>
<%-- recommendations. --%>
<%@ Page Language="C#" AutoEventWireup="true" 
   CodeFile="Options.aspx.cs" Inherits="Options" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Sessions</title>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <asp:Label ID="promptLabel" runat="server" Font-Bold="True"
         Font-Size="Large" Text="Select a programming language:">
      </asp:Label>
      <asp:RadioButtonList ID="languageList" runat="server">
         <asp:ListItem>Visual Basic 2008</asp:ListItem>
         <asp:ListItem>Visual C# 2008</asp:ListItem>
         <asp:ListItem>C</asp:ListItem>
         <asp:ListItem>C++</asp:ListItem>
         <asp:ListItem>Java</asp:ListItem>
      </asp:RadioButtonList>
      <asp:Button ID="submitButton" runat="server" Text="Submit" 
         onclick="submitButton_Click" />
   </div>
   <div>
      <asp:Label ID="responseLabel" runat="server" Font-Bold="True"
         Font-Size="Large" Text="Welcome to cookies!" Visible="False">
      </asp:Label>
      <br /><br />
      <asp:Label ID="idLabel" runat="server" Visible="False"></asp:Label>
      <br /><br />
      <asp:Label ID="timeoutLabel" runat="server" Visible="False">
      </asp:Label>
      <br /><br />
      <asp:HyperLink ID="languageLink" runat="server"
         NavigateUrl="~/Options.aspx" Visible="False">
         Click here to choose another language.
      </asp:HyperLink>
      <br /><br />
      <asp:HyperLink ID="recommendationsLink" runat="server" 
         NavigateUrl="~/Recommendations.aspx" Visible="False">
         Click here to get book recommendations.
      </asp:HyperLink>
   </div>
   </form>
</body>
</html>