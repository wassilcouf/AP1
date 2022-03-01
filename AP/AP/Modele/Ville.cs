using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Modele
{
    class Ville
    {
        #region Attributs;
        private static List<Ville> collClasse = new List<Ville>();
        private string nom;
        private int codePostal;
        private List<Magasin> lesMagasins;



        #endregion

        #region Constructeur
        public Ville(string nom, int codePostal, List<Magasin> lesMagasins)
        {
            Ville.collClasse.Add(this);
            this.nom = nom;
            this.codePostal = codePostal;
            this.lesMagasins = lesMagasins;
        }



        #endregion

        #region Getters/Setters
        internal static List<Ville> CollClasse { get => collClasse; set => collClasse = value; }
        public string Nom { get => nom; set => nom = value; }
        public int CodePostal { get => codePostal; set => codePostal = value; }
        internal List<Magasin> LesMagasins { get => lesMagasins; set => lesMagasins = value; }

        #endregion

        #region Methodes


        #endregion

    }
}
