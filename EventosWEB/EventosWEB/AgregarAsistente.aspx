<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="AgregarAsistente.aspx.cs" Inherits="EventosWEB.AgregarAsistente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-primary text-white">
                    <h3>Ingresar Asistente</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="rutTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombreTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="apellidoTxt">Apellido</label>
                        <asp:TextBox ID="apellidoTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="edadTxt">Edad</label>
                        <asp:TextBox ID="edadTXT" TextMode="Number" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="empresaTxt">Empresa</label>
                        <asp:TextBox ID="empresaTXT" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="estadolbl">Estado</label>
                        <asp:RadioButtonList ID="estadoRbl" runat="server">
                            <asp:ListItem Text="Pagada" Selected="True" Value="Pagada"></asp:ListItem>
                            <asp:ListItem Text="Con Deuda" Value="Con Deuda"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <div class="form-group">
                        <label for="regionDDL">Region</label>
                        <asp:DropDownList ID="regionDDL" runat="server"></asp:DropDownList>
                    </div>
                    <asp:Button runat="server" CssClass="btn btn-primary" ID="ingresaBtn" Text="Ingresar" />

                </div>
            </div>

        </div>
    </div>
</asp:Content>
