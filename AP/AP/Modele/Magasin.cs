using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Modele
{
    class Magasin

    {
        #region Attributs
        private List<Magasin> collClasse = new List<Magasin>();
        private string nom;
        private Ville Laville;
        private List<Produit> lesProduits;



        #endregion

        #region Constructeur
        public Magasin(List<Magasin> collClasse, string nom, Ville laville, List<Produit> lesProduits)
        {
            this.collClasse = collClasse;
            this.nom = nom;
            Laville = laville;
            this.lesProduits = lesProduits;
        }


        #endregion

        #region Getters/Setters

        public string Nom { get => nom; set => nom = value; }
        internal List<Magasin> CollClasse { get => collClasse; set => collClasse = value; }
        internal Ville Laville1 { get => Laville; set => Laville = value; }
        internal List<Produit> LesProduits { get => lesProduits; set => lesProduits = value; }

        #endregion

        #region Methodes


        #endregion

    }
}
