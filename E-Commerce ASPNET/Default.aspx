<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E_Commerce_ASPNET.Prodotti" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <div class="row">
            <asp:Repeater ID="prodottiRepeater" runat="server" ItemType="E_Commerce_ASPNET.Prodotto">
                <ItemTemplate>
                    <div class="col-md-6 mb-4 mt-5">
                        <div class="card fixed-card"">
                            <div class="h-50"><img class="card-img-top h-100" src='<%# "Content/img/" + Item.Immagine %>' alt='<%# Item.Nome %>' /></div>
                            <div class="card-body">
                                <h5 class="card-title"><%# Item.Nome %></h5>
                                <p class="card-text"><%# Item.Descrizione %></p>
                                <p class="card-text">Prezzo: <%# string.Format("{0:C}", Item.Prezzo) %></p>
                                <a href='<%# "Dettagli.aspx?id=" + Item.ID %>' class="btn btn-primary">Dettagli</a>
                            </div>
                        </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </div>
</asp:Content>
