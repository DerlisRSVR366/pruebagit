<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Administrador.aspx.cs" Inherits="LoginLinkto.Administrador" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cph_mensaje" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cph_contenido" runat="server">
<table>
    <tr>
        <td>
        <asp:label ID="lbl_mensaje" runat="server" Text=""></asp:label>
    </td>
            </tr>
    <tr>
        <td>
          
            <asp:Button ID="btn_session" runat="server" OnClick="btn_session_Click" Text="Cerrar Session" />
          
        </td>

    </tr>
    <tr>
        <td>&nbsp;</td>
    </tr>

</table>


</asp:Content>
