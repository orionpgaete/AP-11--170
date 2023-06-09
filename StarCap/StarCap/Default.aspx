<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="StarCap.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-dark text-white">
                    <h3>Agregar Cliente</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nombreTxt">Nombre</label>
                        <asp:TextBox ID="nombretxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="rutTxt">Rut</label>
                        <asp:TextBox ID="ruttxt" CssClass="form-control" runat="server"></asp:TextBox>
                    </div>
                    <div class="form-group">
                        <label for="bebidaDbl">Bebida Favorita</label>                        
      <!--<select>-->  <asp:DropDownList runat="server" ID="bebidaDbl" CssClass="form-select">
                            <asp:ListItem Text="Frapuccino" Value="FRAP-01"></asp:ListItem> 
                            <asp:ListItem Text="Cafe del dia" Value="CAF-01"></asp:ListItem> 
                            <asp:ListItem Text="Te del dia" Value="TE-01"></asp:ListItem>
                            <asp:ListItem Text="Te Chai" Value="TE-02"></asp:ListItem> 
                        </asp:DropDownList>
                    </div>
                    <div class="form-group">
                        <label for="nivelRbl">Nivel</label>
                        <asp:DropDownList runat="server" ID="nivelRbl" CssClass="form-select">
                           <asp:ListItem Text="Silver" Value="1"></asp:ListItem> 
                           <asp:ListItem Text="Gold" Value="2"></asp:ListItem> 
                           <asp:ListItem Text="Platinum" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
