<%-- Fig. 22.21: FlagRotator.aspx --%>
<%-- A Web Form that displays flags using an AdRotator control. --%>
<%@ Page Language="C#" AutoEventWireup="true" 
   CodeFile="FlagRotator.aspx.cs" Inherits="FlagRotator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
   "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Flag Rotator</title>
</head>
<body background="Images/background.png">
    <form id="form1" runat="server">
    <div>
       <h3>AdRotator Example</h3>
       <p>
          <asp:AdRotator ID="countryRotator" runat="server" 
            DataSourceID="adXmlDataSource" />
          <asp:XmlDataSource ID="adXmlDataSource" runat="server" 
             DataFile="~/App_Data/AdRotatorInformation.xml">
          </asp:XmlDataSource>
       </p>
    </div>
    </form>
</body>
</html>
