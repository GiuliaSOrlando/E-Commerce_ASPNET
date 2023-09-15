using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce_ASPNET
{
    public partial class Dettagli : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["id"], out int prodottoId) &&
                Session["ListaProdotti"] is List<Prodotto> listaProdotti &&
                listaProdotti.Any(p => p.ID == prodottoId))
            {
                GridViewDettagli.DataSource = new List<Prodotto> { listaProdotti.First(p => p.ID == prodottoId) };
                GridViewDettagli.DataBind();
            }

        }

        protected void btnAggiungiAlCarrello_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Request.QueryString["id"], out int prodottoId) &&
                Session["ListaProdotti"] is List<Prodotto> listaProdotti &&
                Session["Carrello"] is ClasseCarrello carrello)
            {
                Prodotto prodotto = listaProdotti.FirstOrDefault(p => p.ID == prodottoId);
                Prodotto prodottoNelCarrello = carrello.articoli.FirstOrDefault(p => p.ID == prodotto.ID);

                if (prodottoNelCarrello != null)
                {
                    prodottoNelCarrello.Quantita++;
                }
                else
                {
                    prodotto.Quantita = 1;
                    carrello.AggiungiAlCarrello(prodotto);
                }
            }

        }
    }
}