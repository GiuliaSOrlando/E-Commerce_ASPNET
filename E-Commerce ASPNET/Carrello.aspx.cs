using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce_ASPNET
{
    public partial class Carrello : System.Web.UI.Page
    {
        private ClasseCarrello carrello;
        protected void Page_Load(object sender, EventArgs e)
        {
            carrello = Session["Carrello"] as ClasseCarrello;
            if (carrello == null)
            {
                carrello = new ClasseCarrello();
                Session["Carrello"] = carrello;
            }

            if (!IsPostBack)
            {
                CaricaCarrello();
            }
        }

        private void CaricaCarrello()
        {
            GridViewCarrello.DataSource = carrello.articoli;
            GridViewCarrello.DataBind();

            decimal totale = carrello.CalcolaTotale();
            lblTotale.Text = totale.ToString("C");
        }

        protected void btnSvuotaCarrello_Click(object sender, EventArgs e)
        {
            carrello.SvuotaCarrello();
            CaricaCarrello();
        }

        protected void btnRimuovi_Click(object sender, EventArgs e)
        {
            if (carrello == null)
            {
                carrello = new ClasseCarrello();
                Session["Carrello"] = carrello;
            }
            Button btnRimuovi = (Button)sender;
            GridViewRow gridViewRow = (GridViewRow)btnRimuovi.NamingContainer;

            if (gridViewRow != null)
            {
                int index = gridViewRow.RowIndex;

                if (index >= 0 && index < carrello.articoli.Count)
                {
                    carrello.articoli.RemoveAt(index);
                    CaricaCarrello();
                    
                }
            }
            Response.Redirect(Request.RawUrl);
        }

        protected void btnAumenta_Click(object sender, EventArgs e)
        {
            Button btnAumenta = (Button)sender;
            int prodottoId = int.Parse(btnAumenta.CommandArgument);

            Prodotto prodotto = carrello.articoli.FirstOrDefault(p => p.ID == prodottoId);

            if (prodotto != null)
            {
                prodotto.Quantita++;
                CaricaCarrello();
            }

            
        }

        protected void btnDiminuisci_Click(object sender, EventArgs e)
        {
            Button btnDiminuisci = (Button)sender;
            int prodottoId = int.Parse(btnDiminuisci.CommandArgument);

            Prodotto prodotto = carrello.articoli.FirstOrDefault(p => p.ID == prodottoId);

            if (prodotto != null)
            {
                if (prodotto.Quantita > 1)
                {
                    prodotto.Quantita--;
                }
                else
                {
                    carrello.articoli.Remove(prodotto);
                }
                CaricaCarrello();
            }

            
        }
    }
}