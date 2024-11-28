using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Data;

namespace VoyageVoyage
{
    public class Voyage
    {
        private string details;
        private ushort nbJours;
        private string nom;
        private ushort notation;
        private string pays;
        private double prix;
        private DateTime prochaineDate;
        private string urlDrapeau;
        //public event PropertyChangedEventHandler PropertyChanged;

        public string Details {  get { return details;} set { details = value; } }
        public ushort NbJours {  get { return nbJours; } set {  nbJours = value; } }
        public string Nom {  get { return nom; } set {  nom = value; } }
        public ushort Notation { get {  return notation; } set {  notation = value; } }
        public string Pays { get { return pays;} set {  pays = value; } }
        public double Prix { get {  return prix; } set {  prix = value; } }
        public DateTime ProchaineDate { get {  return prochaineDate; } set {  prochaineDate = value; } }
        public string UrlDrapeau { get {  return urlDrapeau; } set {  urlDrapeau = value; } }
        public Voyage (string nomVal, string paysVal, string drapeauVal, ushort nbjoursVal, string detailsVal, DateTime prochaineDateVal, double prixVal, ushort notationVal)
        {
            this.nom = nomVal;
            this.pays = paysVal;
            this.urlDrapeau= drapeauVal;
            this.nbJours = nbjoursVal;
            this.details = detailsVal;
            this.notation = notationVal;
            this.prix = prixVal;
            this.prochaineDate = prochaineDateVal;
        }
    }
}
