<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TUDAI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><asp:Label CssClass="" Text="Tomas Gispert" runat="server"></asp:Label></h1>
    <h2>Noticias</h2>

    <asp:GridView ID="gvNoticias" runat="server" CssClass="table table-hover" GridLines="None" BorderStyle="None"
        AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="titulo" HeaderText="TITULO"/>
            <asp:BoundField DataField="fecha" HeaderText="FECHA"/>
            <asp:BoundField DataField="id_categoria" HeaderText="CATEGORIA"/>
            <asp:BoundField DataField="cuerpo" HeaderText="CUERPO"/>
            <asp:hyperlinkfield
                text="Editar"
                datanavigateurlfields="id"
                datanavigateurlformatstring="~\alta_noticia.aspx?id={0}"
                headertext="Editar"
                target="_blank"
            />
        </Columns>
    </asp:GridView>

</asp:Content>
