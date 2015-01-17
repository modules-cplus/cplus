using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using CompetencePlus.Outils;

namespace CompetencePlus.PackageModules
{
    public partial class FormeGestionModules : Form
    {
        public FormeGestionModules()
        {
            InitializeComponent();
        }
        
        public void Actualiser()
        {
           
            moduleBindingSource.DataSource = null;
            moduleBindingSource.DataSource = new ModuleBAO().Select();

            Module m = (Module)moduleBindingSource.Current;
            if (m != null)
            {
                nomLabel1.Text = m.Nom;
                competenceLabel1.Text = m.Competence;
                dureeLabel1.Text = m.Duree.ToString();
            }
            
           
        }
        private void FormeGestionModules_Load(object sender, EventArgs e)
        {
            this.Actualiser();
            labelTime.Text = "0h".ToString();
            //Module m = (Module)moduleBindingSource.Current;
           
            //    nomLabel1.Text = m.Nom;
            //    competenceLabel1.Text = m.Competence;
            //    dureeLabel1.Text = m.Duree.ToString();
            
            
           
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void moduleDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Actualiser();
        }

        private void moduleDataGridView_Click(object sender, EventArgs e)
        {
            
        }

        private void moduleDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
        private void moduleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Module d = (Module)moduleBindingSource.Current; 
            if (e.ColumnIndex == 5)
                {
                    new ModuleBAO().Delete(d.ID);
                    this.Actualiser();
                }
            if (e.ColumnIndex == 3)
            {
                FormeGestionPrecision fp = new FormeGestionPrecision();
                fp.getid(d);
                fp.Show();
            }
            if (e.ColumnIndex == 4)
            {
                FormeModule f = new FormeModule();
                f.Ismodify = true;
                f.getid(d.ID);
                f.update(d);
                f.ShowDialog();
                this.Actualiser();
            }
            try
            {
              //  int id = int.Parse(moduleDataGridView.SelectedRows[0].Cells[0].Value.ToString());
                
                foreach (var item in new ModuleBAO().Select())
                {
                    if (d.ID == item.ID)
                    {
                        dureeLabel1.Text = item.Duree.ToString();
                        competenceLabel1.Text = item.Competence.ToString();
                        nomLabel1.Text = item.Nom.ToString();
                    }
                }

               
        
            }
            catch(Exception r)
            {
                MessageBox.Show(r.ToString());
            }
          
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Actualiser();
            FormeModule f = new FormeModule();
            f.ShowDialog();
            this.Actualiser();
        }

        private void brechercher_Click(object sender, EventArgs e)
        {
         
                Module m = new Module();
                m.Nom = nomTextBox.Text;
                m.Description = descriptionTextBox.Text;
                m.Duree = hScrollBar1.Value;
                m.Id_f = new PackageFilieres.FiliereDAO().FindByName(codeTextBox.Text.ToString());
                moduleBindingSource.DataSource = null;
                moduleBindingSource.DataSource = new ModuleBAO().findbyname(m);
          
        }

        public void getinfo()
        {
            Module m = (Module)moduleBindingSource.Current;
            try
            {
                nomLabel1.Text = m.Nom;
                competenceLabel1.Text = m.Competence;
                dureeLabel1.Text = m.Duree.ToString();
            }
            catch
            {
            }
        }

        private void bfirst_Click(object sender, EventArgs e)
        {
            moduleBindingSource.MoveFirst();
            getinfo();
          
        }

        private void bpervious_Click(object sender, EventArgs e)
        {
            moduleBindingSource.MovePrevious(); getinfo();
        }

        private void bSuivant_Click(object sender, EventArgs e)
        {
            moduleBindingSource.MoveNext(); getinfo();
        }

        private void bend_Click(object sender, EventArgs e)
        {
            moduleBindingSource.MoveLast(); getinfo();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            labelTime.Text = hScrollBar1.Value + "h";
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Actualiser();
        }
    }
}
