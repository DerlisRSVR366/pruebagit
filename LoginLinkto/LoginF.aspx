<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="LoginF.aspx.cs" Inherits="LoginLinkto.LoginF" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 31px;
            width: 173px;
            margin-left: 80px;
        }
        .auto-style3 {
            height: 31px;
            }
        .auto-style9 {
            width: 400px;
        }
        .auto-style10 {
            width: 6px;
        }
        .auto-style13 {
            width: 173px;
        }
        .auto-style14 {
            height: 273px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Cph_mensaje" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Cph_contenido" runat="server">
    <asp:UpdatePanel ID="Udp" runat="server">
        <ContentTemplate>
            <table align="center" class="auto-style14">
                <tr>
                    <td class="auto-style9">
                        <table class="auto-style10">
                            <tr>
                                <td class="auto-style1">
                                    <asp:Label ID="lbl_usuario" runat="server" Text="Usuario"></asp:Label>
                                </td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="txt_nombre" runat="server" BorderColor="#9900CC" BorderStyle="Groove" ForeColor="#9900CC" Width="151px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style13">
                                    <asp:Label ID="lbl_contra" runat="server" Text="Contraseña"></asp:Label>
                                </td>
                                <td>
                                    <asp:TextBox ID="txt_contra" runat="server" BorderColor="#9900CC" BorderStyle="Outset" type="password" ForeColor="#9900CC" Width="153px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style13">&nbsp;</td>
                                <td>
                                    <asp:DropDownList ID="cb_emails" runat="server" OnSelectedIndexChanged="cb_emails_SelectedIndexChanged" Visible="False">
                                        <asp:ListItem Selected="True" Value="1">Gmail</asp:ListItem>
                                        <asp:ListItem Value="2">Yahoo</asp:ListItem>
                                        <asp:ListItem Value="3">Outlook</asp:ListItem>
                                    </asp:DropDownList>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style13">
                                    <asp:LinkButton ID="lnk_bt" runat="server">Olvido su contraseña</asp:LinkButton>
                                    <asp:Button ID="btn_olvido" runat="server" Text="Recuperar" OnClick="btn_olvido_Click" />
                                </td>
                                <td>
                                    <asp:Button ID="btn_ingresar" runat="server" BackColor="White" BorderColor="#9900CC" BorderStyle="Outset" ForeColor="#9900CC" Text="Ingresar" OnClick="btn_ingresar_Click" Width="84px" />
                                    <asp:Button ID="btn_enviar" runat="server" OnClick="btn_enviar_Click" Text="Enviar" Visible="False" />
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style13">
                                    <asp:Label ID="lbl" runat="server">Intentos:           </asp:Label>
                                    <asp:Label ID="lbl_contador" runat="server" Text="1"></asp:Label>
                                </td>
                                <td>
                                    &nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style13">
                                    <asp:Label ID="lbl_mensaje" runat="server" Text="Mensaje"></asp:Label>
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                            <tr>
                                <td class="auto-style13">
                                    <asp:Button ID="btn_crear" runat="server" OnClick="btn_crear_Click" Text="Crear Usuario" />
                                </td>
                                <td>&nbsp;</td>
                            </tr>
                        </table>
                    </td>

                </tr>
                <tr>
                    <td align="center" class="auto-style9">
                        &nbsp;</td>

                </tr>

            </table>

        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
