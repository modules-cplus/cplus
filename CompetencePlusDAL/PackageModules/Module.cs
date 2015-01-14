using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageFilieres;
using CompetencePlus.PackagePrecision;

namespace CompetencePlus.PackageModules
{
    public class Module
    {
        private int id;


        private String nom, code;

        public String Code
        {
            get { return code; }
            set { code = value; }
        }
        private int duree;
        Filiere id_f;

        public Filiere Id_f
        {
            get { return id_f; }
            set { id_f = value; }
        }
       

       
        private string strategieEnseignement, description, presentation, competence, equipement, materiel, evaluation, apprentisage;


        public Module(int id, Filiere id_f, String nom, int duree, string strategieEnseignement, string apprentisage, string evaluation, string materiel, string equipement, string competence, string presentation, string description,String code)
        {
            
            this.id_f = id_f;
            this.id = id;
            this.code = code;
            this.nom = nom; this.duree = duree; this.strategieEnseignement = strategieEnseignement; this.description = description; this.presentation = presentation; this.competence = competence; this.equipement = equipement; this.materiel = materiel; this.evaluation = evaluation; this.apprentisage = apprentisage;
        }

        public Module()
        {
            // TODO: Complete member initialization
        }
 
        public string Presentation
        {
            get { return presentation; }
            set { presentation = value; }
        }
        public string Competence
        {
            get { return competence; }
            set { competence = value; }
        }
        public string Equipement
        {
            get { return equipement; }
            set { equipement = value; }
        }
        public string Materiel
        {
            get { return materiel; }
            set { materiel = value; }
        }
        public string Evaluation
        {
            get { return evaluation; }
            set { evaluation = value; }
        }
        public string Apprentisage
        {
            get { return apprentisage; }
            set { apprentisage = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string StrategieEnseignement
        {
            get { return strategieEnseignement; }
            set { strategieEnseignement = value; }
        }
        public int ID
        {
            get { return this.id; }
            set { id = value; }
        }
        public String Nom
        {
            get { return this.nom; }
            set { nom = value; }
        }
        public int Duree
        {
            get { return this.duree; }
            set { duree = value; }
        }
    }

}
