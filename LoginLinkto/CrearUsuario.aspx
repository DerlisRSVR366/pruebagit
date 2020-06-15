<%@ Page Title="" Language="C#" MasterPageFile="~/Login.Master" AutoEventWireup="true" CodeBehind="CrearUsuario.aspx.cs" Inherits="LoginLinkto.CrearUsuario" %>
<asp:Content ID="Content1" ContentPlaceHolderID="cph_cabecera" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 30px;
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
                                <td class="auto-style1">Nombre</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="txt_nombre" runat="server" BorderColor="#9900CC" BorderStyle="Groove" ForeColor="#9900CC" Width="151px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Apellido</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="txt_apellido" runat="server" BorderColor="#9900CC" BorderStyle="Groove" ForeColor="#9900CC" Width="151px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Cedula</td>
                                <td class="auto-style1">
                                    <asp:TextBox ID="txt_cedula" runat="server" BorderColor="#9900CC" BorderStyle="Groove" ForeColor="#9900CC" Width="151px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style1">Usuario</td>
                                <td class="auto-style3">
                                    <asp:TextBox ID="txt_usuario" runat="server" BorderColor="#9900CC" BorderStyle="Groove" ForeColor="#9900CC" Width="151px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style13">Contraseña</td>
                                <td>
                                    <asp:TextBox ID="txt_contra" runat="server" BorderColor="#9900CC" BorderStyle="Outset" type="password" ForeColor="#9900CC" Width="153px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style13">Correo</td>
                                <td>
                                  
                                    <asp:TextBox ID="txt_correo" runat="server" BorderColor="#9900CC" BorderStyle="Groove" ForeColor="#9900CC" Width="151px"></asp:TextBox>
                                  
                                </td>
                            </tr>
                            <tr>
                                 <td class="auto-style13">Teléfono </td>
                                <td>
                                    <asp:TextBox ID="txt_telefono" runat="server" BorderColor="#9900CC" BorderStyle="Groove" ForeColor="#9900CC" Width="151px"></asp:TextBox>
                                 </td>
                            </tr>
                            <tr>
                                 <td class="auto-style13">Dirección</td>
                                <td>
                                    <asp:TextBox ID="txt_direccion" runat="server" BorderColor="#9900CC" BorderStyle="Groove" ForeColor="#9900CC" Width="151px"></asp:TextBox>
                                 </td>
                            </tr>
                            <tr>
                                <td class="auto-style13">
                                    <asp:Button ID="btn_crear" runat="server" OnClick="btn_crear_Click" Text="Crear Usuario" BorderColor="#9900CC" BorderStyle="Solid" ForeColor="#9900CC" />
                                </td>
                                <td>
                                    <asp:Label ID="lbl_mensaje" runat="server" Text="Mensaje" Visible="False"></asp:Label>
                                </td>
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
