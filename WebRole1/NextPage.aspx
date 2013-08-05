<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NextPage.aspx.cs" Inherits="WebRole1.NextPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
    <h1> 次のページ</h1>
    <p>
        日時の表示: <%: DateTime.Now %>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <a href="Default.aspx">トップへ戻る</a>
    </p>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
   
</asp:Content>
