using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CompetencePlus.PackageModules;

namespace CompetencePlus.PackagePrecision
{
    public class Precision
    {
        int id, duree, ordre;
        string nom, description;
        int testcontenue;
        Module modules_id;

        public Module Modules_id
        {
            get { return modules_id; }
            set { modules_id = value; }
        }



        public Precision(int id, int testcontenue, string nom, string description, int duree, int ordre,Module modules_id)
        {
            this.modules_id = modules_id;
            this.id = id; this.testcontenue = testcontenue; this.nom = nom; this.description = description; this.duree = duree; this.ordre = ordre;
        }

        public Precision()
        {
            // TODO: Complete member initialization
        }


       
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public int Id { get { return this.id; } set { this.id = value; } }
        public int Duree { get { return this.duree; } set { this.duree = value; } }
        public int Ordre { get { return this.ordre; } set { this.ordre = value; } }
    }
}
