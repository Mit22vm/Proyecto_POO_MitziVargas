<%@ Page Title="" Language="C#" MasterPageFile="~/Plantilla.Master" AutoEventWireup="true" CodeBehind="RegistroGira.aspx.cs" Inherits="Proyecto_WEB_Gira.RegistroGira" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        function MuestraMensaje(mensaje) {
            alert(mensaje);
        }
    </script> 
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <div class="col-6 mx-auto">
                <h1>Datos de gira</h1>
                <asp:TextBox ID="txtidGira" runat="server" Visible="False"></asp:TextBox> <!--Se coloca el identificar de la gira-->
        
                <!--FECHAS DE GIRA -->
                <!--forma 1-->
                <label for="fecha">Fecha llegada:</label> <!--Se coloca la fecha de llegada de gira-->
                <input type="date" id="txtFechaLlegada" name="fecha">
                <label for="fecha">Fecha Salida:</label> <!--Se coloca la fecha de llegada de salida-->
                <input type="date" id="txtFechaSalida" name="fecha">
                <hr /> <!--Quitar, se coloco por que se ve pegado fechas con el funcionario -->
                
                <!--Funcionarios-->
                <asp:Label ID="Label7" runat="server" Text="Funcionario solicitante: " CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtIdFuncionarioS" runat="server" CssClass="form-control"></asp:TextBox> 
                <asp:Label ID="Label8" runat="server" Text="Funcionario chofer: " CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtIdFuncionario" runat="server" CssClass="form-control"></asp:TextBox> 

                <asp:Label ID="Label9" runat="server" Text="Vehículo: " CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtIdPlaca" runat="server" CssClass="form-control"></asp:TextBox> 
                <!---->
                <asp:Label ID="Label3" runat="server" Text="Tipo de gira: " CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtTipo" runat="server" CssClass="form-control"></asp:TextBox> 
                <asp:Label ID="Label4" runat="server" Text="Origen: " CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtOrigen" runat="server" CssClass="form-control"></asp:TextBox>
                <asp:Label ID="Label5" runat="server" Text="Destino: " CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtDestino" runat="server" CssClass="form-control"></asp:TextBox> 
                <asp:Label ID="Label6" runat="server" Text="Justificación de gira " CssClass="form-label"></asp:Label>
                <asp:TextBox ID="txtJustificacion" runat="server" CssClass="form-control"></asp:TextBox> 



            </div>
        </div>
    </div>





</asp:Content>
