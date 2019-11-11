<%@ Page Language ="C#" AutoEventWireup="false" 
    CodeBehind="FirstPage.aspx.cs" Inherits="AspNetApplication1.FirstPage" %>
<%-- when the autowiredup is false manually we have to write
    Page_Init, Page_Load, Page_Prerender, Page_Unload, Page_Disposed --%>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <title>Asp.Net</title>
<script runat="server">   
   
</script>

</head>
<body>
    <h1> Welcome to ASP.Net Application </h1>
    <p> This is our first page</p>
    <form runat = "server">
      
<%-- asp:label --> called as webserver controls --%>
<%-- "CssClass" can be used to apply styles --%>
<%-- To see the compiled version of this file goto
" C:\Users\thanushrees\AppData\Local\Temp\Temporary ASP.NET Files\vs\9004fab7\21b3a026\filename.compiled "
--%>
<asp:Label  runat="server" Text="User Name :" CssClass= "label" />
<asp:TextBox id="txt1" runat="server" />
<br/> <br/>
<asp:Label id = "lbl2" runat="server" Text="Password :" />
<asp:TextBox id="txt2" runat="server" TextMode= "Password" />
<br/> <br/>
<asp:Button id="btn1" runat="server" Text="Submit" OnClick = "btn1_Click" />

    </form>
</body>
</html>