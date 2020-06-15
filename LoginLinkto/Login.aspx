<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="LoginLinkto.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td></td>
                    <td>Login</td>
                    <td></td>
                    
                </tr>
                 <tr>
                    <td>Nombre</td>
                    <td>
                        <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>


                    </td>
                    <td></td>
                    
                </tr>

                 <tr>
                    <td>Contraseña</td>
                    <td>
                        <asp:TextBox ID="txt_contra" runat="server"></asp:TextBox>
                    </td>
                    <td></td>
                    
                </tr>

                 <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                    </td>
                     <td>Intentos<asp:Label ID="Label1" runat="server" Text=".  "></asp:Label>
                    <td><asp:Label ID="lbl_contador" runat="server" Text="1"></asp:Label>
                     </td>
                    
                </tr>


            </table>
           
        </div>
    </form>
</body>
</html>
