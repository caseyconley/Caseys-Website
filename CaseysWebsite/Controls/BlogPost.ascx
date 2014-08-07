<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BlogPost.ascx.cs" Inherits="CaseysWebsite1.Controls.BlogPost" %>
<link href="../Styles/style_BlogPost.css" rel="stylesheet" />
<div class="post">
    <asp:Label ID="lblBlogTitle" CssClass="blogTitle" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="lblBlogDate" CssClass="blogTitle" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="lblBlogBody" CssClass="blogBody" runat="server" Text=""></asp:Label>
</div>
