<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CreateProduct.aspx.cs" Inherits="AspNetApplication1.CreateProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="container">
        <h2 class="bg-success text-white text-center">Create New Product</h2>
         <div class="row">
              <div class="col-4 offset-2">
                <div class="form-group">
                    <asp:Label ID="lblName" runat="server" CssClass="col-form-label text-dark"
                        Text="Product Name" />
                    <asp:TextBox ID="txtName" runat="server" CssClass="form-control" />
              </div>
            </div>
            <div class="col-4">
                <div class="form-group">
                    <asp:Label ID="lblPrice" runat="server" CssClass="col-form-label text-dark"
                        Text="Unit Price" />
                    <asp:TextBox ID="txtPrice" runat="server" CssClass="form-control" />
              </div>
            </div>
          </div>

         <div class="row">

            <div class="col-4 offset-2">
                <div class="form-group">
                    <asp:Label ID="lblStock" runat="server" CssClass="col-form-label text-dark"
                        Text="Units In Stock" />
                    <asp:TextBox ID="txtStock" runat="server" CssClass="form-control" />
              </div>
            </div>

            <div class="col-4">
                <div class="form-group">
                    <asp:Label ID="lblCatg" runat="server" CssClass="col-form-label text-dark"
                        Text="Category" />
                    <asp:DropDownList ID="ddlCategories" runat="server" CssClass="form-control" />
              </div>
            </div>
        </div>

         <div class="row">
            <div class="col-4 offset-2">
                <div class="form-group">
                    <asp:Label ID="lblDisContinued" runat="server" CssClass="col-form-label text-dark"
                        Text="DisContinued" />
                    <asp:CheckBox ID="chkDiscontinued" runat="server" CssClass="ml-3 form-check-inline" />
              </div>
            </div>
            </div>


                                     <%-- Buttons--%>
       <div class="row">
           <div class="col-8 offset-2 text-center">
            <asp:LinkButton ID="btnsave" runat="server" CssClass="btn btn-primary m-1 p-2 w-25"
                OnClick="btnsave_Click">
                <i class="fa fa-save"></i> Save
            </asp:LinkButton>

               <asp:LinkButton ID="btnClear" runat="server" CssClass="btn btn-secondary m-1 p-2 w-25"
                OnClick="btnClear_Click">
                <i class="fa fa-sign-out"></i> Discard
            </asp:LinkButton>

           </div>

       </div>
</section>
</asp:Content>
