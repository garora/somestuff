<%@ Control Language="C#" AutoEventWireup="true" CodeFile="createPage.ascx.cs" Inherits="myTemplates_createPage" %>
<div>
    <table>
        <tr>
            <td style="width: 100px">
                Page Title
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtTitle" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Tags
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtTags" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
                Description
            </td>
            <td style="width: 100px">
                <asp:TextBox ID="txtContent" runat="server" Height="292px" TextMode="MultiLine" Width="510px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100%">
                <ul>
                    <li><font color="red">You may use basic html tags like &lt;H1&gt; &lt;H2&gt; &lt;B&gt;
                        &lt;I&gt; &lt;FONT&gt; etc. </font></li>
                    <li><font color="red">Tags like &lt;BODY&gt; &lt;HEAD&gt; &lt;TABLE&gt; are NOT allowed.</font></li>
                    <li><font color="red">Please check spelling before posting articles.</font></li>
                </ul>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:Label ID="lblMessage" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100%">
                <asp:LinkButton ID="lnkNewPage" OnClick="lnkNewPage_Click" runat="server"></asp:LinkButton>
            </td>
        </tr>        
        <tr>
            <td style="width: 100px">
            </td>
            <td style="width: 100px">
                <asp:Button ID="btnGenerate" runat="server" OnClick="btnGenerate_Click" Text="Generate" />
            </td>
        </tr>
    </table>
</div>
