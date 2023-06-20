<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="StarCap.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
        <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Clientes</h3>
                </div>
                <div class="card-body">
                    <asp:GridView CssClass="table table-hover table-bordered" runat="server" 
                         OnRowCommand="grillaCliente_RowCommand"
                         AutoGenerateColumns="false" ID="grillaCliente">
                        <Columns>
                            <asp:BoundField DataField="Rut" HeaderText="Rut del Cliente" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre del Cliente" />
                            <asp:BoundField DataField="NivelTxt" HeaderText="Nivel Cliente"/>
                            <asp:BoundField DataField="BebidaFavorita.Nombre" HeaderText="Favorita" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button CommandName="elimina" CommandArgument='<%# Eval("Rut") %>' 
                                        
                                        runat="server" CssClass="btn btn-danger" Text="Eliminar" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
