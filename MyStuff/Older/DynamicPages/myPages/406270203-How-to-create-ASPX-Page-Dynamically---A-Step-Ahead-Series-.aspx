<%@ Page Language="C#" CodeFileBaseClass="PageBase" AutoEventWireup="true" CodeFile ="myPageCode.cs" 
Inherits= "myPageCode" PageID="406270203" MetaTitle="How to create ASPX Page Dynamically - A Step Ahead Series?" MetaKeywords="How to create ASPX Page Dynamically - A Step Ahead Series?" %>
<%@ Register TagPrefix="myPageHeader" TagName="PgHeader" Src="~/myTemplates/PageHeader.ascx" %>
<%@ Register TagPrefix="myPageFooter" TagName="PgFooter" Src="~/myTemplates/PageFooter.ascx" %>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="style.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table width="100%">
            <tr>
                <td colspan="2">
                    <myPageHeader:PgHeader ID="PgHeader1" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <h2>
                         <%=MetaTitle%></h2>
                </td>
            </tr>
            <tr class=content>
                <td colspan="2">
                    <h4>Introduction</h4>
In a simple creating an <font color=green>aspx </font> page dynamically is a very tedious job. Whenever we think for dynamically creation scenarios stuck in mind about the overload to server etc.  But with the help of this article one can attain the same as easily as creating another simple <font color=green>aspx </font> page.

<h4>Need and Requirement</h4>
Now next words came to mind that what is the need to create an <font color=green>aspx </font> page dynamically? Let me explain it:

<ol>
<li>You need to create a page, based on selected requirement at the moment.</li>
<li>Need to create a page from static <font color = green>html </font> contents.</li>
<li>Having huge data, need to represent in an individual page and its tough to store in database.</li>
</ol>

                </td>
            </tr>
            <tr>
            <td colspan="2">
                <myPageFooter:PgFooter ID="PgFooter1" runat="server" />
            </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>


