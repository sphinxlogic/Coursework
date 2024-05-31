<%-- Fig. 22.65: Books.aspx --%>
<%-- Displays information from the Books database. --%>
<%@ Page Language="C#" MasterPageFile="~/Bug2Bug.master"
   AutoEventWireup="true" CodeFile="Books.aspx.cs"
   Inherits="Secure_Books" Title="Book Information" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent"
   Runat="Server">
   <p>
      Welcome,
      <asp:LoginName ID="LoginName1" runat="server" />!
      <asp:LoginStatus ID="LoginStatus1" runat="server" 
         LogoutAction="RedirectToLoginPage"
         LogoutText="Click here to log out." />
   </p>
   <p>
      Author:
      <asp:DropDownList ID="authorsDropDownList" runat="server" 
         DataSourceID="authorsLinqDataSource" DataTextField="Name" 
         DataValueField="AuthorID" AutoPostBack="True" 
         onselectedindexchanged=
            "authorsDropDownList_SelectedIndexChanged">
      </asp:DropDownList>
      <asp:LinqDataSource ID="authorsLinqDataSource" runat="server" 
         onselecting="authorsLinqDataSource_Selecting">
      </asp:LinqDataSource>
   </p>
   <p>
      <asp:GridView ID="booksGridView" runat="server" AllowPaging="True" 
         AllowSorting="True" AutoGenerateColumns="False" CellPadding="5" 
         DataSourceID="booksLinqDataSource" PageSize="4" 
         Width="600px">
         <Columns>
            <asp:BoundField DataField="ISBN" HeaderText="ISBN"
               SortExpression="ISBN" />
            <asp:BoundField DataField="Title" HeaderText="Title"
               SortExpression="Title" />
            <asp:BoundField DataField="EditionNumber"
               HeaderText="Edition Number"
               SortExpression="EditionNumber" />
            <asp:BoundField DataField="Copyright" HeaderText="Copyright" 
               SortExpression="Copyright" />
         </Columns>
         <HeaderStyle BackColor="LightGreen" />
         <AlternatingRowStyle BackColor="LightYellow" />
      </asp:GridView>
      <asp:LinqDataSource ID="booksLinqDataSource" runat="server" 
         onselecting="booksLinqDataSource_Selecting">
      </asp:LinqDataSource>
   </p>
</asp:Content>