using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageModules;

namespace CompetencePlus.PackagePrecision
{
    public partial class FormPrecision : Form
    {
        public FormPrecision()
        {
            InitializeComponent();
        }

        Module m;
        public void getid(Module mos)
        {

            m = mos;
        }
        private void benregistrer_Click(object sender, EventArgs e)
        {


            Precision pr = new Precision();
            pr.Nom = nomTextBox.Text;
            pr.Duree = int.Parse(dureeTextBox.Text);
            pr.Description = descriptionTextBox.Text;
            pr.Ordre = 1;
            pr.Modules_id = m;
            new PrecisionBAO().Add(pr);

            


        }
    }
}
