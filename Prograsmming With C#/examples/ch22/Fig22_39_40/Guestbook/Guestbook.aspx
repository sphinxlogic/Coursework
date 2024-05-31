<%-- Fig. 22.39: Guestbook.aspx --%>
<%-- Guestbook web application with a form for users to submit --%>
<%-- guestbook entries and a GridView to view existing entries. --%>
<%@ Page Language="C#" AutoEventWireup="true"
   CodeFile="Guestbook.aspx.cs" Inherits="Guestbook" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Guestbook</title>
    <style type="text/css">
       .style1
       {
          width: 100%;
       }
       .style2
       {
          width: 150px;
          vertical-align: top;
       }
    </style>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <h2>Please leave a message in our guestbook:</h2>
      <table class="style1">
         <tr>
            <td class="style2">Your name:</td>
            <td>
               <asp:TextBox ID="nameTextBox" runat="server"
                  Width="300px"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="style2">Your e-mail address:</td>
            <td>
               <asp:TextBox ID="emailTextBox" runat="server"
                  Width="300px"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="style2">Tell the world:</td>
            <td>
               <asp:TextBox ID="messageTextBox" runat="server" 
                  Height="100px" Rows="8" Width="300px"
                  TextMode="MultiLine"></asp:TextBox>
            </td>
         </tr>
         <tr>
            <td class="style2">&nbsp;</td>
            <td>
               <asp:Button ID="submitButton" runat="server"
                  onclick="submitButton_Click" Text="Submit" />
               <asp:Button ID="clearButton" runat="server" 
                  onclick="clearButton_Click" Text="Clear" />
            </td>
         </tr>
      </table>
      <p>
         <asp:GridView ID="messagesGridView" runat="server"
            AutoGenerateColumns="False" CellPadding="4"
            DataKeyNames="MessageID" ForeColor="#333333" GridLines="None"
            DataSourceID="messagesLinqDataSource" Width="600px">
            <FooterStyle BackColor="#1C5E55" Font-Bold="True"
               ForeColor="White" />
            <RowStyle BackColor="#E3EAEB" />
            <Columns>
               <asp:BoundField DataField="Date" HeaderText="Date"
                  SortExpression="Date" />
               <asp:BoundField DataField="Name" HeaderText="Name"
                  SortExpression="Name" />
               <asp:BoundField DataField="Email" HeaderText="Email"
                  SortExpression="Email" />
               <asp:BoundField DataField="MessageText"
                  HeaderText="Message" SortExpression="MessageText" />
            </Columns>
            <PagerStyle BackColor="#666666" ForeColor="White"
               HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True"
               ForeColor="#333333" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True"
               ForeColor="White" />
            <EditRowStyle BackColor="#7C6F57" />
            <AlternatingRowStyle BackColor="White" />
         </asp:GridView>
         <asp:LinqDataSource ID="messagesLinqDataSource" runat="server" 
            ContextTypeName="GuestbookDBDataContext" EnableInsert="True" 
            TableName="Messages">
         </asp:LinqDataSource>
      </p>
   </div>
   </form>
</body>
</html>