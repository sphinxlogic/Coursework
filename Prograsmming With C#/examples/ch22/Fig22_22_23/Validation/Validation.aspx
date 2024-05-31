<%-- Fig. 22.22: Validation.aspx --%>
<%-- Form that demonstrates using validators to validate user input. --%>

<%@ Page Language="C#" AutoEventWireup="true"
   CodeFile="Validation.aspx.cs" Inherits="Validation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Demonstrating Validation Controls</title>
    <style type="text/css">
       .style1
       {
          width: 125px;
          vertical-align: top;
       }
    </style>
</head>
<body>
   <form id="form1" runat="server">
   <div>
      <p>
         Please fill out the following form.<br /><i>All fields are
         required and must contain valid information.</i>
      </p>
      <table style="width:100%;">
         <tr>
            <td class="style1">Name:</td>
            <td>
               <asp:TextBox ID="nameTextBox" runat="server">
               </asp:TextBox><br />
               <asp:RequiredFieldValidator ID="nameExistsValidator"
                  runat="server" ControlToValidate="nameTextBox" 
                  ErrorMessage="Please enter your name."
                  Display="Dynamic">
               </asp:RequiredFieldValidator>
            </td>
         </tr>
         <tr>
            <td class="style1">E-mail address:</td>
            <td>
               <asp:TextBox ID="emailTextBox" runat="server">
               </asp:TextBox>&nbsp;e.g., user@domain.com<br />
               <asp:RequiredFieldValidator ID="emailExistsValidator" 
                  runat="server" ControlToValidate="emailTextBox" 
                  ErrorMessage="Please enter your e-mail address."
                  Display="Dynamic">
               </asp:RequiredFieldValidator>
               <asp:RegularExpressionValidator ID="emailFormatValidator"
                  runat="server" ControlToValidate="emailTextBox" 
                  ErrorMessage=
                     "Please enter an e-mail address in a valid format." 
                  ValidationExpression=
                     "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
                  Display="Dynamic">
               </asp:RegularExpressionValidator>
            </td>
         </tr>
         <tr>
            <td class="style1">Phone number:</td>
            <td>
               <asp:TextBox ID="phoneTextBox" runat="server">
               </asp:TextBox>&nbsp;e.g., (555) 555-5555<br />
               <asp:RequiredFieldValidator ID="phoneExistsValidator" 
                  runat="server" ControlToValidate="phoneTextBox" 
                  ErrorMessage="Please enter your phone number."
                  Display="Dynamic">
               </asp:RequiredFieldValidator>
               <asp:RegularExpressionValidator ID="phoneFormatValidator"
                  runat="server" ControlToValidate="phoneTextBox" 
                  ErrorMessage=
                     "Please enter a phone number in a valid format." 
                  ValidationExpression=
                     "((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" 
                  Display="Dynamic">
               </asp:RegularExpressionValidator>
            </td>
         </tr>
      </table>
      <p>
         <asp:Button ID="submitButton" runat="server" Text="Submit" />
      </p>
      <p>
         <asp:Label ID="outputLabel" runat="server"
            Text="Thank you for your submission." Visible="False">
         </asp:Label>
      </p>  
   </div>
   </form>
</body>
</html>