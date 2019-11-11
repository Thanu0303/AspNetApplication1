<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WebControls1.aspx.cs" Inherits="AspNetApplication1.WebControls1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Literal ID="literal1" runat="server"></asp:Literal>

    <section class="card shadow mx-5 mb-5">
      <div class="card-header card-title text-center">Application Form</div>
        <div class="card-body">
        <div class="form-group form-row">
            <div class="col-3 offset-2 text-right">
                <asp:Label ID="lbl1" runat="server" Text="Name : "></asp:Label> </div>
           <div class="col-5 text-left">
               <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
        </div>
            <!-- Password --->
         <div class="form-group form-row">
            <div class="col-3 offset-2 text-right">
                <asp:Label ID="lbl2" runat="server" Text="Password : "></asp:Label> </div>
           <div class="col-5 text-left">
               <asp:TextBox ID="txtPwd" runat="server" TextMode="Password" CssClass="form-control"></asp:TextBox>
          </div>
        </div>
            <!-- Address --->
            <div class="form-group form-row">
            <div class="col-3 offset-2 text-right">
                <asp:Label ID="lbl3" runat="server" Text="Address : "></asp:Label> </div>
           <div class="col-5 text-left">
               <asp:TextBox ID="txtAdd" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
          </div>
        </div>

            <!-- Gender --->
            <div class="form-group form-row">
            <div class="col-3 offset-2 text-right">
                <asp:Label ID="lbl4" runat="server" Text="Gender : "></asp:Label> </div>
           <div class="col-5 text-left">
               <asp:RadioButton ID="Radio1" runat="server" GroupName="Gender" Text="Male"></asp:RadioButton>
               <asp:RadioButton ID="Radio2" runat="server" GroupName="Gender" Text="FeMale"></asp:RadioButton>
          </div>
        </div>

            <!-- Location --->
            <div class="form-group form-row">
            <div class="col-3 offset-2 text-right">
                <asp:Label ID="lbl5" runat="server" Text="Location : "></asp:Label> </div>
           <div class="col-5 text-left">
           <asp:DropDownList ID="DropDown1" runat="server" CssClass="form-control">
               <asp:ListItem Text="--------------------- Select ---------------------" Value="0" Selected="true" />
               <asp:ListItem Text="Bengaluru" Value="Bengaluru"  />
               <asp:ListItem Text="Mysuru" Value="Mysuru"  />
               <asp:ListItem Text="Hyderabad" Value="0"  />
               <asp:ListItem Text="Delhi" Value="0"  />
           </asp:DropDownList>
          </div>
        </div>

            <!-- Interest Hobbies --->
            <div class="form-group form-row">
            <div class="col-3 offset-2 text-right">
                <asp:Label ID="lbl6" runat="server" Text="Interest Hobbies : "></asp:Label> </div>
           <div class="col-5 text-left">
           <asp:CheckBoxList ID="CheckBox1" runat="server" RepeatColumns="2"
               RepeatDirection="Horizontal" RepeatLayout="Table" CssClass="table table-sm table-striped">
           </asp:CheckBoxList>
          </div>
        </div>

             <!-- Buttons --->
         <div class="form-row">
             <div class="col-4 offset-4 btn-group-lg text-center">
                 <asp:Button ID="btnSave" runat="server" Text="Save"  
                     CssClass="btn btn-primary mx-2 " OnClick="btnSave_Click" />
                 <asp:Button ID="btnCancel" runat="server" Text="Cancel"  
                     CssClass="btn btn-secondary mx-2 " />
              </div>
        </div>
      </div>
    </section>
</asp:Content>
