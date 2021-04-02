<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="hada_p3.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
        NIF:
        <asp:TextBox id="TextBox0" runat="server" />
        <br /><br />
        Nombre:
        <asp:TextBox id="TextBox1" runat="server" />
        <br /><br />
        Edad:
        <asp:TextBox id="TextBox2" runat="server" />
        <br /><br />

        <asp:Button id="button0" text="Leer" OnClick="button0_Click" runat="server" />
        <asp:Button id="button1" text="Leer Primero" OnClick="button1_Click" runat="server" />
        <asp:Button id="button2" text="Leer Anterior" OnClick="button2_Click" runat="server" />
        <asp:Button id="button3" text="Leer Siguiente" OnClick="button3_Click" runat="server" />
        <asp:Button id="button4" text="Crear" OnClick="button4_Click" runat="server" />
        <asp:Button id="button5" text="Actualizar" OnClick="button5_Click" runat="server" />
        <asp:Button id="button6" text="Borrar" OnClick="button6_Click" runat="server" />
    
</asp:Content>
