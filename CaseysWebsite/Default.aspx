<%@ Page Title="" Language="C#" MasterPageFile="~/CaseysWebsite.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CaseysWebsite1.Default" %>

<%@ Register Src="~/Controls/BlogPost.ascx" TagPrefix="cdc" TagName="BlogPost" %>




<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/style_Default.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Default" ContentPlaceHolderID="MasterBody" runat="server">
    <div id="main-page">
        <h3>
            Blog
        </h3>
        <asp:PlaceHolder ID="BlogPostPlaceholder" runat="server"></asp:PlaceHolder>
    </div>
</asp:Content>
