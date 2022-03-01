using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Modele
{
    class Produit
    {
        #region Attributs
        private static List<Produit> collClasse = new List<Produit>();
        private string nomProduit;
        private int prixProduit;
        private Magasin leMagasin;




        #endregion

        #region Constructeur
        public Produit(string nomProduit, int prixProduit, Magasin leMagasin)
        {
            Produit.collClasse.Add(this);
            this.nomProduit = nomProduit;
            this.prixProduit = prixProduit;
            this.leMagasin = leMagasin;
        }



        #endregion

        #region Getters/Setters
        internal static List<Produit> CollClasse { get => collClasse; set => collClasse = value; }
        public string NomProduit { get => nomProduit; set => nomProduit = value; }
        public int PrixProduit { get => prixProduit; set => prixProduit = value; }
        internal Magasin LeMagasin { get => leMagasin; set => leMagasin = value; }

        #endregion

        #region Methodes


        #endregion

    }
}
