using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ASPNET
{
    public class ClasseCarrello
    {
        public List<Prodotto> articoli = new List<Prodotto>();

        public void AggiungiAlCarrello(Prodotto prodotto)
        {
            articoli.Add(prodotto);
        }

        public void RimuoviDalCarrello(Prodotto prodotto)
        {
            articoli.Remove(prodotto);
        }

        public void RimuoviDalCarrelloPerId(int id)
        {
            for(int i = 0; i < articoli.Count; i++)
            {
                if (articoli[i].ID == id)
                {
                    articoli.RemoveAt(i);
                    break;
                }
            }
        }

        public void SvuotaCarrello()
        {
            articoli.Clear();
        }

        public decimal CalcolaTotale()
        {
            decimal totale = 0;
            foreach (Prodotto prodotto in articoli)
            {

                totale += prodotto.Prezzo * prodotto.Quantita;
            }

            return totale;
        }
    }
}