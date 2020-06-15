    <%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="LoginLinkto.Usuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cph_mensaje" runat="server">
    <table style="width:100%;">
        <tr>
            <td>Bienvenido</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btn_session" runat="server" OnClick="Button1_Click" Text="Cerrar Session" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cph_contenido" runat="server">
</asp:Content>
