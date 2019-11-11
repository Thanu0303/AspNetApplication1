<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SignOut.aspx.cs" Inherits="AspNetApplication1.SignOut" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="jumbotron">
        <div class="display-1"> You have logged out. you have to
            <asp:HyperLink ID="link1" runat="server" Text="Re-login"
                NavigateUrl="~/SignInForm.aspx" /> to access this site.
        </div>
    </section>
</asp:Content>
