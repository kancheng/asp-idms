﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="topic" Runat="Server">
    	<br />
	<h1>IDMS</h1>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="idmsRdbtnArea" Runat="Server">
    <asp:Button ID="back" runat="server" Text="Back" CssClass = "btn btn-default btn-wdt10" OnClick="back_Click" />
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="idmsInputPanelArea" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="idmsOutputPanelArea" Runat="Server">
    	<!-- 1 Panel -->
		<asp:Panel ID="Panel1" runat="server">
		<div class ="alert alert-info" style = "text-align:center; width:50%; margin:0 auto;">
		<br />
		<asp:Label ID="Label1" runat="server" style =" font-size:25px;" ForeColor="#31708F">
		<div><h2>檢視最新的一筆資料</h2></div>
		<hr />
		</asp:Label>
		<br />
		</div>
		</asp:Panel>
		<br />
		<!-- 2 Panel -->
		<asp:Panel ID="Panel2" runat="server">
		<div class ="alert alert-danger" style = "text-align:center; width:50%; margin:0 auto;">
		<br />
		<asp:Label ID="Label2" runat="server" style =" font-size:25px;" ForeColor="#A94442">
		<div><h2>記錄</h2></div>
		<hr />
		</asp:Label>
		<br />
		</div>
		</asp:Panel>
		<br />

</asp:Content>

