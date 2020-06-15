<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adin.aspx.cs" Inherits="LoginLinkto.Adin" %>

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
                    <td></td>
                    <td></td>
                    
                </tr>
                 <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                    
                </tr>

                 <tr>
                    <td></td>
                    <td>
                        <asp:Label ID="lbl_bien" runat="server" Text="Bienvenido"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lbl_nombre" runat="server" Text="."></asp:Label>
                    </td>
                    
                </tr>

                 <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btn_session" runat="server" Text="Cerrar Session" OnClick="btn_session_Click" />
                    </td>
                    <td></td>
                    
                </tr>


            </table>
        </div>
    </form>
</body>
</html>
