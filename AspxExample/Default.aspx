<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AspxExample.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style2 {
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
            width: 211px;
        }
        .auto-style6 {
            height: 8px;
            width: 211px;
        }
        .auto-style7 {
            height: 8px;
        }
        .auto-style8 {
            width: 56%;
            height: 180px;
        }
        .auto-style9 {
            width: 60%;
        }
        .margin {
            margin-left:20px;
            margin-top: 20px
        }
    </style>
</head>
<body>

    <h1>Calificaciones Alumnos</h1>
    <form id="form1" runat="server">

            
    <table border="1" class="auto-style8">
        <tr>
            <th class="auto-style7">Boleta</th>
            <th class="auto-style7">Nombre</th>
            <th class="auto-style6">Calificación</th>
        </tr>
        <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta1"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre1"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList1"></asp:DropDownList> </td>
        </tr>
         <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta2"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre2"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList2"></asp:DropDownList> </td>
        </tr>
         <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta3"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre3"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList3"></asp:DropDownList> </td>
        </tr>
         <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta4"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre4"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList4"></asp:DropDownList> </td>
        </tr>
         <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta5"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre5"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList5"></asp:DropDownList> </td>
        </tr>
         <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta6"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre6"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList6"></asp:DropDownList> </td>
        </tr>
         <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta7"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre7"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList7"></asp:DropDownList> </td>
        </tr>
         <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta8"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre8"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList8"></asp:DropDownList> </td>
        </tr>
         <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta9"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre9"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList9"></asp:DropDownList> </td>
        </tr>
         <tr>
            <td class="auto-style2"><asp:Label runat="server" id="boleta10"></asp:Label> </td>
            <td class="auto-style2"><asp:Label runat="server" id="nombre10"></asp:Label> </td>
            <td class="auto-style4"><asp:DropDownList  runat="server" id="DropDownList10"></asp:DropDownList> </td>
        </tr>
     
        
       
    </table>

        <asp:Button id="Button1" runat="server" Height="24px" OnClick="Button1_Click" Text="Enviar" Width="125px" class="margin" />

        <h1> Estadísticas</h1>
        <table class="auto-style9" border="1">
            <tr>
                <th>%Aprobados</th>
                <th>%Reprobados</th>
                <th>Promedio</th>
                <th>Calif. Maxima</th>
                <th>Calif. Minima</th>
            </tr>

            <tr>
             <td><asp:Label runat="server" id="aprobado"></asp:Label></td>
             <td><asp:Label runat="server" id="reprobado"></asp:Label></td>
             <td><asp:Label runat="server" id="promedio"></asp:Label></td>
             <td><asp:Label runat="server" id="califMax"></asp:Label></td>
             <td><asp:Label runat="server" id="califMin"></asp:Label></td>
            </tr>
     
        </table>
            
    </form>
    
    </body>
</html>
