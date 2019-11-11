<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Validators.aspx.cs" Inherits="AspNetApplication1.Validators" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script>
        function myValidation(s, e) {
            if (e.Value.length > 4) {
            e.IsValid = true;
        }else
        {
             e.IsValid = false;
        }
        }
    </script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="container">
    <h2 class="bg-success text-white font-weight-bold text-center">Working with Validators</h2>
   
        <asp:ValidationSummary ID="summary1" runat="server" DisplayMode="List"
        ShowSummary="true" CssClass ="alert alert-danger" HeaderText="Errors"/>

        <div class="row">
                                        <%--UserName--%>
             <div class="col-3 p-2">
                <div class="card h-100">
                    <div class="card-header card-title bg-warning">Required Field Validator</div>
                    <div class="card-body">
                        <div class="form-group">
                            <asp:TextBox ID="txtName" Cssclass="form-control" runat="server" placeholder="Enter Name"  />
                            <asp:RequiredFieldValidator ID="refv1" runat="server"
                                ControlToValidate="txtName" Display="Static" Text="*" CssClass=" text-danger" ErrorMessage="Name is Required"/>
                        </div>
                    </div>
                </div>
            </div>
                                          <%--Password--%>
        <div class="col-3 p-2">
                <div class="card h-100">
                    <div class="card-header card-title bg-warning">Compare Validator</div>
                    <div class="card-body">
                        <div class="form-group">
                            <asp:TextBox ID="txtPwd" Cssclass="form-control" runat="server"
                                placeholder="Enter Password"  />
                            <asp:TextBox ID="txtConfirm" Cssclass="form-control" runat="server"
                                placeholder="Confirm Password"   />
                            <asp:CompareValidator ID="cv1" runat="server"
                                ControlToValidate="txtConfirm" Display="Static" Text="*"
                                CssClass=" text-danger" ErrorMessage="Password Doesnot match" ControlToCompare="txtPwd"
                                Operator="Equal" Type="String"/>
                        </div>
                    </div>
                </div>
            </div>   
            
                                         <%--BirthDate--%>
            <div class="col-3 p-2">
                <div class="card h-100">
                    <div class="card-header card-title bg-warning">Compare Validator 2</div>
                    <div class="card-body">
                        <div class="form-group">
                            <asp:TextBox ID="txtDate" Cssclass="form-control" runat="server"
                                placeholder="Enter BirthDate"  />
                            
                            <asp:CompareValidator ID="cv2" runat="server"
                                ControlToValidate="txtDate" Display="Static" Text="*"
                                CssClass=" text-danger" ErrorMessage="Invalid Date" 
                              Operator="DataTypeCheck" Type="Date"/>
                        </div>
                    </div>
                </div>
            </div>

                                   <%-- Age--%>
            <div class="col-3 p-2">
                <div class="card h-100">
                    <div class="card-header card-title bg-warning">Range Validator </div>
                    <div class="card-body">
                        <div class="form-group">
                            <asp:TextBox ID="txtAge" Cssclass="form-control" runat="server"
                                placeholder="Enter Age"  />
                            
                            <asp:RangeValidator ID="rv1" runat="server"
                                ControlToValidate="txtAge" Display="Static" Text="*"
                                CssClass=" text-danger" ErrorMessage="Age should be b/w 18 and 100" 
                               Type="Integer" MinimumValue="18" MaximumValue="100"/>
                        </div>
                    </div>
                </div>
            </div>

                                         <%--Email  --%>                       
            <div class="col-3 p-2">
                <div class="card h-100">
                    <div class="card-header card-title bg-warning">Regular Expression Validator </div>
                    <div class="card-body">
                        <div class="form-group">
                            <asp:TextBox ID="txtEmail" Cssclass="form-control" runat="server"
                                placeholder="Enter Email"  />
                            
                            <asp:RegularExpressionValidator ID="reg1" runat="server"
                                ControlToValidate="txtEmail" Display="Static" Text="*"
                                CssClass=" text-danger" ErrorMessage="Invalid email pattern" 
                              ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                        </div>
                    </div>
                </div>
            </div>

                                  <%--Custom Validator for UserId--%>
            <div class="col-3 p-2">
                <div class="card h-100">
                    <div class="card-header card-title bg-warning">Custom Validator </div>
                    <div class="card-body">
                        <div class="form-group">
                            <asp:TextBox ID="txtUserId" Cssclass="form-control" runat="server"
                                placeholder="Enter a valid UserId"  />
                            
                            <asp:CustomValidator ID="cv3" runat="server"
                                ControlToValidate="txtUserId" Display="Static" Text="*"
                                CssClass=" text-danger" ErrorMessage="User Id should be five or more letters and non-existent one" 
                             ClientValidationFunction="myValidation" OnServerValidate="cv3_ServerValidate" />
                        </div>
                    </div>
                </div>
            </div>


  </div>
                                               <%--Buttons--%>
    <div class="row">
        <div class="col-12 text-center">
            <button class="btn btn-outline-danger">Submit</button>
        </div>
    </div>

</section>
</asp:Content>
