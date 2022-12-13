﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EpicGamingStore
{
    public partial class ProductDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Prodotto prodotto = new Prodotto();
            string id = Request.QueryString["idprodotto"];
            foreach (Prodotto p in Prodotto.getInventory(0)) 
            {
                if (id == p.IDProdotto.ToString()) 
                {
                    copertina.ImageUrl = $"~/assets/img/copertina/{p.URLImgCopertina.ToString()}";
                    front.ImageUrl = $"~/assets/img/front/{p.URLImg.ToString()}";
                    titolo.Text = p.NomeProdotto.ToString();
                    sviluppatore.Text = p.Sviluppatore.ToString();
                    publisher.Text = p.Publisher.ToString();
                    dataUscita.Text = p.DataRilascio.ToString();
                    prezzo.Text = p.PrezzoIntero.ToString("c2");
                    descrizione.Text = p.DescrizioneProdotto.ToString();    
                    gallery1.ImageUrl = $"~/assets/img/gallery/{p.URLGallery1.ToString()}";
                    gallery2.ImageUrl = $"~/assets/img/gallery/{p.URLGallery2.ToString()}";
                    gallery3.ImageUrl = $"~/assets/img/gallery/{p.URLGallery3.ToString()}";
                    gallery4.ImageUrl = $"~/assets/img/gallery/{p.URLGallery4.ToString()}";
                    iframe.Src = p.URLVideoTrailer.ToString();
                }
            }
        }
    }
}