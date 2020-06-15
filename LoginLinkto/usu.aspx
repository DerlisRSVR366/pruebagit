<%@ Page Title="" Language="C#" MasterPageFile="~/Segunda.Master" AutoEventWireup="true" CodeBehind="usu.aspx.cs" Inherits="LoginLinkto.usu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 425px;
    }
    .auto-style2 {
        width: 393px;
    }
        .auto-style3 {
            width: 425px;
            height: 36px;
        }
        .auto-style4 {
            width: 393px;
            height: 36px;
        }
        .auto-style5 {
            height: 36px;
        }
        .auto-style6 {
            width: 1152px;
            margin-left: 462px;
            margin-top: 0px;
        }
    </style>
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="Cph_mensaje" runat="server">
    <center class="auto-style6">
    <table style="width:100%;">
    <tr>
        <td class="auto-style1">Calculadora</td>
        <td class="auto-style2"> <asp:Label ID="lbl_usuario" runat="server" Text=""></asp:Label></td>
        <td>
            <asp:Button ID="btn_cerrar" runat="server" BackColor="#6699FF" BorderColor="#3399FF" OnClick="btn_cerrar_Click" Text="Cerrar Session" />
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Primer Número:</td>
        <td class="auto-style4">
            <asp:TextBox ID="txt_primer" onkeypress="return onKeyDecimal(this,event)" runat="server" BorderColor="#3366FF" BorderStyle="Solid"></asp:TextBox>
        </td>
        <td class="auto-style5"></td>
    </tr>
    <tr>
        <td class="auto-style1">Segundo Numero:</td>
        <td class="auto-style2">
            <asp:TextBox ID="txt_segundo" runat="server" BorderColor="#3366FF" BorderStyle="Solid"></asp:TextBox>
        </td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style1">
            <asp:Button ID="btn_sumar" runat="server" OnClick="Button1_Click" Text="Sumar" BackColor="#6699FF" />
            <asp:Button ID="btn_restar" runat="server" Text="Restar" OnClick="btn_restar_Click" BackColor="#FF0066" />
        </td>
        <td class="auto-style2">
            <asp:Button ID="btn_multi" runat="server" Text="Multiplicar" OnClick="btn_multi_Click" BackColor="#6699FF" />
            <asp:Button ID="btn_dividir" runat="server" Text="Dividir" OnClick="btn_dividir_Click" BackColor="#FF0066" />
        </td>
        <td>
            <asp:Button ID="btn_potenciar" runat="server" Text="Potencia" OnClick="btn_potenciar_Click" BackColor="#6699FF" />
            <asp:Button ID="btn_radicar" runat="server" Text="Radicación" OnClick="btn_radicar_Click" BackColor="#FF0066" />
        </td>
    </tr>
    <tr>
        <td class="auto-style1">Respuesta:</td>
        <td ><asp:Label ID="lbl_respuesta" runat="server" Text="0"></asp:Label></td>
        <td ><asp:Label ID="lbl_mensaje" runat="server" Text="Mensaje" Visible="False"></asp:Label></td>
    </tr>
</table>
        </center>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="Cph_contenido" runat="server">
</asp:Content>
