<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StateManagement.aspx.cs" Inherits="AspNetApplication1.StateManagement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            max-width: 1140px;
            min-width: 992px;
            height: 333px;
            margin-left: auto;
            margin-right: auto;
            padding-left: 15px;
            padding-right: 15px;
        }
        .auto-style2 {
            height: 170px;
        }
        .auto-style3 {
            height: -15px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="auto-style1">
        <h2 class="bg-success text-white text-center">
            State Management
        </h2>
        <hr />
      Application Counter  <asp:Label ID="lblApplication" runat="server" />
        <br />
        Session Counter <asp:Label ID="lblSession" runat="server" />

        <br />
        <hr />

        <div style="border: 1px solid black;">
            <div style="background-color:deepskyblue; color:white; font-weight:bold; padding:2px;
                width:100%; border-bottom:1px solid black;"> Working with Cookies</div>

            <div style="padding:10px;" >
                <asp:Label ID="lblName" runat="server" Text="Cookie Name" Width="150px" />
                <asp:TextBox ID="txtName" runat="server" BorderColor="Navy"
                    BorderStyle="Dotted" BorderWidth="2px" />
                <br /><br />
                 <asp:Label ID="Label1" runat="server" Text="Cookie Value" Width="150px" />
                <asp:TextBox ID="txtValue" runat="server" BorderColor="Navy"
                    BorderStyle="Dotted" BorderWidth="2px" />
                <br /> <br />
                <asp:Button ID="btnStore" runat="server" Text="Store Cookies"
                    BackColor="Navy" ForeColor="White" Font-Bold="true"
                    BorderColor="Yellow" BorderStyle="Groove" BorderWidth="1px"
                    OnClick="btnStore_Click" />
                
                <asp:Button ID="btnRetrieve" runat="server"
                    BackColor="Navy" ForeColor="White" Font-Bold="true"
                    BorderColor="Yellow" BorderStyle="Groove" BorderWidth="1px"
                    OnClick="btnRetrieve_Click" Text="Retrieve Cookies" />
                <br /><br />
                <asp:Label ID="lblMessage" runat="server" Text="Label"></asp:Label>
                <br />
                <br />
            </div>
        </div>
    </section>
</asp:Content>
