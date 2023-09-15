<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Dettagli.aspx.cs" Inherits="E_Commerce_ASPNET.Dettagli" EnableEventValidation="false"%>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblMessaggio" runat="server" Text="" ForeColor="Green" Visible="false"></asp:Label>

    <asp:GridView ID="GridViewDettagli" runat="server" AutoGenerateColumns="False" ItemType="E_Commerce_ASPNET.Prodotto" CssClass="table table-bordered table-striped m-4">
    <Columns>
        <asp:TemplateField HeaderText="Nome">
            <ItemTemplate>
                <h2 class="card-title"><%# Item.Nome %></h2>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Descrizione">
            <ItemTemplate>
                <p class="card-text"><%# Item.Descrizione %></p>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Prezzo">
            <ItemTemplate>
                <p class="card-text">Prezzo: <%# string.Format("{0:C}", Item.Prezzo) %></p>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField>
            <ItemTemplate>
                <asp:Button runat="server" Text="Aggiungi al Carrello" OnClick="btnAggiungiAlCarrello_Click" CssClass="btn btn-primary" />
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
</asp:GridView>
</asp:Content>
