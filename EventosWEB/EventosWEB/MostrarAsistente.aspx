<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="MostrarAsistente.aspx.cs" Inherits="EventosWEB.MostrarAsistente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row mt-5">
        <div class="col-lg-6 mx-auto">
            <asp:DropDownList ID="estadoDDL" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div class="row mt-5">
        <asp:GridView ID="grillaAsistente" AutoGenerateColumns="false" ShowHeaderWhenEmpty="true"
            CssClass="table table-hover table-bordered"
            EmptyDataText="No hay Registros" runat="server">
            <Columns>
                <asp:BoundField HeardText="Nombre" DataField="Nombre" />
                <asp:BoundField HeardText="Apellido" DataField="Apellido" />
                <asp:BoundField HeardText="Empresa" DataField="Empresa" />
                <asp:BoundField HeardText="Region" DataField="Region" />
                <asp:BoundField HeardText="Estado" DataField="Estado" />


            </Columns>

        </asp:GridView>
    </div>
</asp:Content>
