<%-- Figure 22.59: Login.aspx --%>
<%-- Content page using a Login control that authenticates users. --%>
<%@ Page Language="C#" MasterPageFile="~/Bug2Bug.master" Title="Login" %>

<script runat="server">
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="bodyContent"
   Runat="Server">
   <asp:Login ID="Login1" runat="server" BackColor="#F7F6F3"
      BorderColor="#E6E2D8" BorderPadding="4" BorderStyle="Solid"
      BorderWidth="1px" CreateUserText="Click here to create a new user." 
      CreateUserUrl="~/CreateNewUser.aspx" DisplayRememberMe="False"
      Font-Names="Verdana" Font-Size="0.8em" ForeColor="#333333"
      DestinationPageUrl="~/Secure/Books.aspx">
      <TextBoxStyle Font-Size="0.8em" />
      <LoginButtonStyle BackColor="#FFFBFF" BorderColor="#CCCCCC"
         BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" 
         Font-Size="0.8em" ForeColor="#284775" />
      <InstructionTextStyle Font-Italic="True" ForeColor="Black" />
      <TitleTextStyle BackColor="#5D7B9D" Font-Bold="True"
         Font-Size="0.9em" ForeColor="White" />
   </asp:Login>
</asp:Content>