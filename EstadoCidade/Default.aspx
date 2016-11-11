<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EstadoCidade._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <style>
        #MainContent_rowEstado:hover, #MainContent_rowCidade:hover{
            font-weight: bold;
        }
    </style>
    <div class="jumbotron">
        <asp:Table ID="mainTable" runat="server">
            <asp:TableRow ID="rowEstado">
                <asp:TableCell>
                <asp:Label ID="txtEstado" Text="Estado: " runat="server" />
                <asp:DropDownList ID="drpEstado" runat="server" AutoPostBack="true" DataTextField="DescEstado" DataValueField="IdEstado">
                </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow ID="rowCidade">
                <asp:TableCell>
                <asp:Label ID="txtCidade" Text="Cidade: " runat="server" Visible="false"/>
                <asp:DropDownList ID="drpCidade" Visible="false" runat="server" DataTextField="DescCidade">
                </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </div>

</asp:Content>
