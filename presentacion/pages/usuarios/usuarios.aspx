<%@ Page Title="" Language="C#" MasterPageFile="~/resources/master/MasterPage.Master" AutoEventWireup="true" CodeBehind="usuarios.aspx.cs" Inherits="presentacion.pages.usuarios.usuarios" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="table-responsive">
        <asp:GridView ID="gvUsuarios" runat="server" CssClass="table table-bordered" AlternatingRowStyle-BackColor="#3399ff" AlternatingRowStyle-ForeColor="White" OnSelectedIndexChanged="gvUsuarios_SelectedIndexChanged">
<AlternatingRowStyle BackColor="#3399FF" ForeColor="White"></AlternatingRowStyle>
            <Columns>
                <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Acciones" ShowHeader="True" Text="ver" ControlStyle-ForeColor="Black"/>
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
