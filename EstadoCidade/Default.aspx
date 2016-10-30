<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EstadoCidade._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <asp:Label ID="txtEstado" Text="Estado" runat="server" /> <br />
        <asp:DropDownList ID="drpEstado" runat="server" >
            <asp:ListItem Text="Selecione"/>
        </asp:DropDownList><br />
        <asp:Label ID="txtCidade" Text="Cidade" runat="server" /><br />
        <asp:DropDownList ID="drpCidade" Visible="false" runat="server" >
        </asp:DropDownList>
        
    </div>

</asp:Content>
