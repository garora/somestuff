<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default1.aspx.cs" Inherits="_Default1" %>

<%@ Register TagPrefix="myPage" TagName="aspxPage" Src="~/myTemplates/createPage.ascx" %>
<%@ Register TagPrefix="myPageHeader" TagName="PgHeader" Src="~/myTemplates/PageHeader.ascx" %>
<%@ Register TagPrefix="myPageFooter" TagName="PgFooter" Src="~/myTemplates/PageFooter.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
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
                        Create Dynamic Page(S)</h2>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:PlaceHolder ID="myPage" runat="server" />
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
