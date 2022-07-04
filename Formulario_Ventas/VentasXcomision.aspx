<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="VentasXcomision.aspx.cs" Inherits="Formulario_2.VentasXcomision" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/HTML; charset=utf-8"/>
    <title>
        Ventas por Comision
    </title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <hr />
            <asp:Label ID="Label1" runat="server" Text="Nombre:   ">

            </asp:Label>
            <asp:TextBox ID="Obj_Nombre" runat="server">

            </asp:TextBox>
            <br />
            <hr />
            <asp:Label ID="Label2" runat="server" Text="Turno Laboral:   ">

            </asp:Label>
            <asp:DropDownList ID="Obj_DList_Turno" runat="server">

            </asp:DropDownList>
            <br />
            <hr />
            <asp:Label ID="Label3" runat="server" Text="Total de Ventas:   ">

            </asp:Label>
            <asp:TextBox ID="Obj_Ventas" runat="server">

            </asp:TextBox>
            <br />
            <hr />
            <asp:Button ID="Obj_Button_Executable" runat="server" Text="Ejecutar" OnClick="Obj_Button_Executable_Click" />
            <br />
            <hr />
        </div>
    </form>
</body>
</html>
