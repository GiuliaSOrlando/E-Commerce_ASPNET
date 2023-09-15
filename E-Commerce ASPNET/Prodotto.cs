using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce_ASPNET
{
    public class Prodotto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public decimal Prezzo { get; set; }
        public string Immagine { get; set; }
        public int Quantita { get; set; }

        public Prodotto() { }

        public Prodotto(int id, string nome, string descrizione, decimal prezzo, string immagine)
        {
            ID = id;
            Nome = nome;
            Descrizione = descrizione;
            Prezzo = prezzo;
            Immagine = immagine;
        }
    }
}