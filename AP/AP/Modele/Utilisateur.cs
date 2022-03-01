using System;
using System.Collections.Generic;
using System.Text;

namespace AP.Modele
{
    class Utilisateur
    {
        #region Attributs
        private static List<Utilisateur> collClasse = new List<Utilisateur>();
        private string identifiant;
        private string motDePasse;
        private string nom;
        private string prenom;
        private string adresse;
        private Ville laVille;
        private int numTelephone;






        #endregion

        #region Constructeur

        public Utilisateur(string identifiant, string motDePasse, string nom, string prenom, string adresse, Ville laVille, int numTelephone)
        {
            Utilisateur.collClasse.Add(this);
            this.identifiant = identifiant;
            this.motDePasse = motDePasse;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = adresse;
            this.laVille = laVille;
            this.numTelephone = numTelephone;
        }

        #endregion

        #region Getters/Setters
        internal static List<Utilisateur> CollClasse { get => collClasse; set => collClasse = value; }
        public string Identifiant { get => identifiant; set => identifiant = value; }
        public string MotDePasse { get => motDePasse; set => motDePasse = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public int NumTelephone { get => numTelephone; set => numTelephone = value; }
        internal Ville LaVille { get => laVille; set => laVille = value; }

        #endregion

        #region Methodes


        #endregion

    }
}
