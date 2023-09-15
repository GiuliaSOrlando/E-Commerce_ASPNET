<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Carrello.aspx.cs" Inherits="E_Commerce_ASPNET.Carrello" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container">
        <h2 class="mt-4">Carrello</h2>
        <div class="table-responsive">
            <asp:GridView ID="GridViewCarrello" runat="server" AutoGenerateColumns="False" CssClass="table table-bordered">
                <Columns>
                    <asp:BoundField DataField="Nome" HeaderText="Nome" ItemStyle-CssClass="card-text" />
                    <asp:BoundField DataField="Descrizione" HeaderText="Descrizione" ItemStyle-CssClass="card-text" />
                    <asp:BoundField DataField="Prezzo" HeaderText="Prezzo" DataFormatString="{0:C}" ItemStyle-CssClass="card-text" />
                    <asp:TemplateField HeaderText="Quantità">
                        <ItemTemplate>
                            <div class="quantity">
                                <asp:Button ID="btnDiminuisci" runat="server" Text="-" OnClick="btnDiminuisci_Click" CssClass="btn btn-primary btn-quantity" CommandArgument='<%# Eval("ID") %>' />
                                <asp:Label ID="lblQuantita" runat="server" Text='<%# Bind("Quantita") %>' CssClass="card-text"></asp:Label>
                                <asp:Button ID="btnAumenta" runat="server" Text="+" OnClick="btnAumenta_Click" CssClass="btn btn-primary btn-quantity" CommandArgument='<%# Eval("ID") %>' />
                            </div>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:Button ID="btnRimuovi" runat="server" Text="Rimuovi" OnClick="btnRimuovi_Click" CssClass="btn btn-primary" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <asp:Button ID="btnSvuotaCarrello" runat="server" Text="Svuota Carrello" OnClick="btnSvuotaCarrello_Click" CssClass="btn btn-secondary mt-3" />
        <p class="mt-3">
            Totale:
             <asp:Label ID="lblTotale" runat="server" Text=""></asp:Label>
        </p>
    </div>
</asp:Content>
