<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hada_p3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        NIF:
        <asp:TextBox id="in1" runat="server" />
        <br /><br />
        Nombre:
        <asp:TextBox id="TextBox1" runat="server" />
        <br /><br />
        Edad:
        <asp:TextBox id="TextBox2" runat="server" />
        <br /><br />

        <asp:Button id="Button0" text="Leer" OnClick="read" runat="server" />
        <asp:Button id="Button1" text="Leer Primero" OnClick="read" runat="server" />
        <asp:Button id="Button2" text="Leer Anterior" OnClick="read" runat="server" />
        <asp:Button id="Button3" text="Leer Siguiente" OnClick="read" runat="server" />
        <asp:Button id="Button4" text="Crear" OnClick="read" runat="server" />
        <asp:Button id="Button5" text="Actualizar" OnClick="read" runat="server" />
        <asp:Button id="Button6" text="Borrar" OnClick="read" runat="server" />
    
</asp:Content>
