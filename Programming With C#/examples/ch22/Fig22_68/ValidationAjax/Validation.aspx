<%-- Fig. 22.68: Validation.aspx --%>
<%-- Validation application enhanced with ASP.NET AJAX. --%>
<%@ Page Language="C#" AutoEventWireup="true"
   CodeFile="Validation.aspx.cs" Inherits="Validation" %>
<%@ Register assembly="AjaxControlToolkit"
   namespace="AjaxControlToolkit" tagprefix="ajax" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <title>Demonstrating Validation Controls</title>
   <style type="text/css">
      .style1
      {
         width: 100%;
      }
      .style2
      {
         text-align: right;
         vertical-align: top;
      }   
   </style>
</head>
<body>
<form id="form1" runat="server">
<ajax:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
</ajax:ToolkitScriptManager>
<div>
   <p>
      Please fill out the following form.<br /><i>All fields are
      required and must contain valid information.</i>
   </p>
   <ajax:TabContainer ID="TabContainer1" runat="server" 
      ActiveTabIndex="0" Width="500px">
      <ajax:TabPanel runat="server" HeaderText="Name" ID="TabPanel1">
         <ContentTemplate>
         <table class="style1">
            <tr>
               <td class="style2">First Name:</td>
               <td>
                  <asp:TextBox ID="firstNameTextBox" runat="server">
                  </asp:TextBox><br />
                  <asp:RequiredFieldValidator
                     ID="firstNameExistsValidator" runat="server"
                     ControlToValidate="firstNameTextBox" Display="None" 
                     ErrorMessage="Please enter your first name.">
                  </asp:RequiredFieldValidator>
                  <ajax:ValidatorCalloutExtender
                     ID="firstNameExistsCallout" runat="server" 
                     Enabled="True"
                     TargetControlID="firstNameExistsValidator">
                  </ajax:ValidatorCalloutExtender>
               </td>
            </tr>
            <tr>
               <td class="style2">Last Name:</td>
               <td>
                  <asp:TextBox ID="lastNameTextBox" runat="server">
                  </asp:TextBox><br />
                  <asp:RequiredFieldValidator
                     ID="lastNameExistsValidator" runat="server" 
                     ControlToValidate="lastNameTextBox" Display="None" 
                     ErrorMessage="Please enter your last name.">
                  </asp:RequiredFieldValidator>
                  <ajax:ValidatorCalloutExtender
                     ID="lastNameExistsCallout" runat="server" 
                     Enabled="True"
                     TargetControlID="lastNameExistsValidator">
                  </ajax:ValidatorCalloutExtender>
               </td>
            </tr>
         </table>
         </ContentTemplate>
      </ajax:TabPanel>
      <ajax:TabPanel ID="TabPanel2" runat="server" HeaderText="Contact">
         <ContentTemplate>
         <table class="style1">
            <tr>
               <td class="style2">E-mail address:</td>
               <td>
                  <asp:TextBox ID="emailTextBox" runat="server">
                  </asp:TextBox>&nbsp;e.g., user@domain.com<br />
                  <asp:RequiredFieldValidator
                     ID="emailExistsValidator" runat="server" 
                     ErrorMessage="Please enter your e-mail address." 
                     ControlToValidate="emailTextBox" Display="None">
                  </asp:RequiredFieldValidator>
                  <ajax:ValidatorCalloutExtender 
                     ID="emailExistsCallout" runat="server" 
                     Enabled="True"
                     TargetControlID="emailExistsValidator">
                  </ajax:ValidatorCalloutExtender>
                  <asp:RegularExpressionValidator
                     ID="emailFormatValidator" runat="server" 
                     ErrorMessage="Please enter a valid e-mail address." 
                     ControlToValidate="emailTextBox" Display="None" 
                     ValidationExpression=
                        "\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                  </asp:RegularExpressionValidator>
                  <ajax:ValidatorCalloutExtender ID="emailFormatCallout"
                     runat="server" Enabled="True"
                     TargetControlID="emailFormatValidator">
                  </ajax:ValidatorCalloutExtender>
               </td>
            </tr>
            <tr>
               <td class="style2">Phone number:</td>
               <td>
                  <asp:TextBox ID="phoneTextBox" runat="server">
                  </asp:TextBox>&nbsp;e.g., (555) 555-5555<br />
                  <asp:RequiredFieldValidator ID="phoneExistsValidator"
                     runat="server" ControlToValidate="phoneTextBox" 
                     ErrorMessage="Please enter your phone number."
                     Display="None">
                  </asp:RequiredFieldValidator>
                  <ajax:ValidatorCalloutExtender ID="phoneExistsCallout"
                     runat="server" Enabled="True"
                     TargetControlID="phoneExistsValidator">
                  </ajax:ValidatorCalloutExtender>
                  <asp:RegularExpressionValidator
                     ID="phoneFormatValidator" runat="server" 
                     ControlToValidate="phoneTextBox" 
                     ErrorMessage="Please enter a valid phone number."
                     Display="None" ValidationExpression=
                        "((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}">
                  </asp:RegularExpressionValidator>
                  <ajax:ValidatorCalloutExtender ID="phoneFormatCallout"
                     runat="server" Enabled="True"
                     TargetControlID="phoneFormatValidator">
                  </ajax:ValidatorCalloutExtender>
               </td>
            </tr>
         </table>
         </ContentTemplate>
      </ajax:TabPanel>
   </ajax:TabContainer> 
   <p>
      <asp:Button ID="submitButton" runat="server" Text="Submit" />
   </p>
   <asp:UpdatePanel ID="UpdatePanel1" runat="server">
      <ContentTemplate>
         <asp:Label ID="outputLabel" runat="server"
            Text="Thank you for your submission." Visible="False">
         </asp:Label>
      </ContentTemplate>
      <Triggers>
         <asp:AsyncPostBackTrigger ControlID="submitButton"
            EventName="Click" />
      </Triggers>
   </asp:UpdatePanel>
</div>
</form>
</body>
</html>