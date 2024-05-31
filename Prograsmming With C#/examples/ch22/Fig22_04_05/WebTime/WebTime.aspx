﻿<%-- Fig. 22.4: WebTime.aspx --%>
<%-- A page that displays the current time in a Label. --%>
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="WebTime.aspx.cs" 
   Inherits="WebTime" EnableSessionState="False" %>                      

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
   <head runat="server">
      <title>A Simple Web Form Example</title>
   </head>
   <body>
   <form id="form1" runat="server">
      <div>
         <h2>Current time on the web server:</h2>
         <p>
            <asp:Label ID="timeLabel" runat="server" BackColor="Black"
               Font-Size="XX-Large" ForeColor="Yellow"                
               EnableViewState="False"></asp:Label>                   
         </p>
      </div>
   </form>
   </body>
</html>