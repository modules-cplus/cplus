using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackageModules;
using CompetencePlus.Properties;

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

        public bool ismodify = false;

        public void update(Precision prd)
        {

            nomTextBox.Text = prd.Nom;
            dureeTextBox.Text = prd.Duree.ToString();
            descriptionTextBox.Text = prd.Description;


        }

        private void benregistrer_Click(object sender, EventArgs e)
        {

            if (ismodify == false)
            {

                Precision pr = new Precision();
                pr.Nom = nomTextBox.Text;
                pr.Duree = int.Parse(dureeTextBox.Text);
                pr.Description = descriptionTextBox.Text;
                pr.Ordre = 1;
                pr.Modules_id = m;

                
                            //   new PrecisionBAO().Add(pr);

            }
            if (ismodify == true){
                Precision prx = new Precision();
                prx.Nom = nomTextBox.Text;
                prx.Duree = int.Parse(dureeTextBox.Text);
                prx.Description = descriptionTextBox.Text;
                prx.Ordre = 1;
                prx.Modules_id = m;
               

                new PrecisionBAO().Update(prx);

            }
           


        }

        private void nomTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomTextBox.Text))
            {

                NomErrorProvider.Icon = new Icon(SystemIcons.Error, 64, 32);
                NomErrorProvider.SetError(nomTextBox, "Entrer le nom");

            }
            else
            {
                NomErrorProvider.Icon = new Icon(Resources.Clear, 64, 32);
                NomErrorProvider.SetError(nomTextBox, "Ok");

            }
        }

        private void nomTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (nomTextBox.Text == "")
            {
                e.Cancel = true;
            }
        }

        private void dureeTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (dureeTextBox.Text == "")
                e.Cancel = true;
        }

        private void dureeTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(dureeTextBox.Text))
            {
                DurreerrorProvider.Icon = new Icon(SystemIcons.Error, 64, 32);
                DurreerrorProvider.SetError(dureeTextBox, "Entrer la duree");

            }
            else
            {
                DurreerrorProvider.Icon = new Icon(Resources.Clear, 64, 32);
                DurreerrorProvider.SetError(dureeTextBox, "Ok");

            }
        }

        private void FormPrecision_Load(object sender, EventArgs e)
        {

        }
    }
}
