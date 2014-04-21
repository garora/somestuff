<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PageHeader.ascx.cs" Inherits="myTemplates_PageHeader" %>
<link href="../style.css" rel="stylesheet" type="text/css" />
<div>
		<asp:PlaceHolder ID ="plhImage" runat="server" />
		<ul class="menu">
			<li><a href="./default.aspx">HOME</a></li>
			<li><a href="./default.aspx">About US</a></li>
			<li><a href="./default.aspx">Recent Posts</a></li>
			<li><a href="./default.aspx">Site Map</a></li>
			<li><a href="./default.aspx">Contact US</a></li>
			<li><a href="./default.aspx">Tags</a></li>
			<li><a href="./default.aspx">Meta</a></li>
			<li><a href="./default.aspx">Most Emailed</a></li>
		</ul>
	</div>