using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CompetencePlus.PackagePrecision;

namespace CompetencePlus.PackageModules
{
    public partial class FormeGestionPrecision : Form
    {
        public FormeGestionPrecision()
        {
            InitializeComponent();
        }
        Module m;
        public void getid(Module mos)
        {
            
            m = mos;
        }
        public void Actualiser()
        {

            precisionBindingSource.DataSource = null;
            precisionBindingSource.DataSource = new PrecisionBAO().GetallPres(m.ID);

            Precision pr = (Precision)precisionBindingSource.Current;
            if (pr != null)
            {
                dureeLabel1.Text = pr.Duree.ToString();
                nomLabel1.Text = pr.Nom;
               // idLabel1.Text = pr.Id.ToString();
            }
        }

        private void FormeGestionPrecision_Load(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPrecision pr = new FormPrecision();
            pr.getid(m);
            pr.ShowDialog();
            this.Actualiser();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void precisionDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Precision pr = (Precision)precisionBindingSource.Current;
            if (e.ColumnIndex == 6)
            {
               
                    new PrecisionBAO().Delete(pr.Id);
                    this.Actualiser();
                
            }
            if (e.ColumnIndex == 5)
            {
                FormPrecision prx = new FormPrecision();
                prx.ismodify = true;
                prx.getid(m);
                prx.update(pr);
                prx.ShowDialog();
                this.Actualiser();
            }


        }
    }
}
