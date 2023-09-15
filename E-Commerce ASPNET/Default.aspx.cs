using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace E_Commerce_ASPNET
{
    public partial class Prodotti : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                PopolaProdotti();
                if (Session["Carrello"] == null)
                {
                    Session["Carrello"] = new ClasseCarrello();
                }
            }
        }

        private void PopolaProdotti()
        {
            List<Prodotto> listaProdotti = new List<Prodotto>();

            listaProdotti.Add(new Prodotto(1, "Blusa Gotica", "Una blusa gotica con un design elegante, adatta per ogni stagione.", 49.99m, "blusa.png"));

            listaProdotti.Add(new Prodotto(2, "Maglia Lunga Gotica", "Una maglia lunga gotica perfetta per occasioni speciali con uno stile raffinato e unico.", 59.99m, "maglia_lunga.png"));

            listaProdotti.Add(new Prodotto(3, "Corsetto Steampunk alla Moda", "Un corsetto alla moda in stile steampunk per un look unico e audace.", 39.99m, "steampunk_corset.png"));

            listaProdotti.Add(new Prodotto(4, "Vestito Steampunk Vintage", "Un elegante vestito steampunk vintage per un tocco di classe e originalità.", 59.99m, "vestito_steampunk.png"));

            Session["ListaProdotti"] = listaProdotti;

            prodottiRepeater.DataSource = listaProdotti;
            prodottiRepeater.DataBind();

        }
    

    }
}