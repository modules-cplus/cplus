namespace CompetencePlus.PackageModules
{
    partial class FormeGestionPrecision
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomLabel;
            System.Windows.Forms.Label dureeLabel;
            System.Windows.Forms.Label nomLabel2;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label dureeLabel2;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dureeLabel1 = new System.Windows.Forms.Label();
            this.nomLabel1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dureeTrackBar = new System.Windows.Forms.TrackBar();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.precisionDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.bend = new System.Windows.Forms.Button();
            this.bSuivant = new System.Windows.Forms.Button();
            this.bpervious = new System.Windows.Forms.Button();
            this.bfirst = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.precisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prealable = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Contenue = new System.Windows.Forms.DataGridViewButtonColumn();
            this.pmodifier = new System.Windows.Forms.DataGridViewImageColumn();
            this.psupprimer = new System.Windows.Forms.DataGridViewImageColumn();
            nomLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            nomLabel2 = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            dureeLabel2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeTrackBar)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.precisionDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.precisionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(10, 27);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(31, 13);
            nomLabel.TabIndex = 2;
            nomLabel.Text = "Titre:";
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Location = new System.Drawing.Point(3, 59);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(39, 13);
            dureeLabel.TabIndex = 4;
            dureeLabel.Text = "Duree:";
            // 
            // nomLabel2
            // 
            nomLabel2.AutoSize = true;
            nomLabel2.Location = new System.Drawing.Point(35, 46);
            nomLabel2.Name = "nomLabel2";
            nomLabel2.Size = new System.Drawing.Size(31, 13);
            nomLabel2.TabIndex = 0;
            nomLabel2.Text = "Titre:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(4, 79);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // dureeLabel2
            // 
            dureeLabel2.AutoSize = true;
            dureeLabel2.Location = new System.Drawing.Point(28, 180);
            dureeLabel2.Name = "dureeLabel2";
            dureeLabel2.Size = new System.Drawing.Size(39, 13);
            dureeLabel2.TabIndex = 6;
            dureeLabel2.Text = "Duree:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(dureeLabel);
            this.groupBox1.Controls.Add(this.dureeLabel1);
            this.groupBox1.Controls.Add(nomLabel);
            this.groupBox1.Controls.Add(this.nomLabel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precision";
            // 
            // dureeLabel1
            // 
            this.dureeLabel1.Location = new System.Drawing.Point(48, 59);
            this.dureeLabel1.Name = "dureeLabel1";
            this.dureeLabel1.Size = new System.Drawing.Size(100, 23);
            this.dureeLabel1.TabIndex = 5;
            this.dureeLabel1.Text = "label1";
            // 
            // nomLabel1
            // 
            this.nomLabel1.Location = new System.Drawing.Point(48, 27);
            this.nomLabel1.Name = "nomLabel1";
            this.nomLabel1.Size = new System.Drawing.Size(100, 23);
            this.nomLabel1.TabIndex = 3;
            this.nomLabel1.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(dureeLabel2);
            this.groupBox2.Controls.Add(this.dureeTrackBar);
            this.groupBox2.Controls.Add(descriptionLabel);
            this.groupBox2.Controls.Add(this.descriptionTextBox);
            this.groupBox2.Controls.Add(nomLabel2);
            this.groupBox2.Controls.Add(this.nomTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 253);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Precision";
            // 
            // dureeTrackBar
            // 
            this.dureeTrackBar.Location = new System.Drawing.Point(73, 180);
            this.dureeTrackBar.Name = "dureeTrackBar";
            this.dureeTrackBar.Size = new System.Drawing.Size(195, 45);
            this.dureeTrackBar.TabIndex = 7;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(73, 76);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(195, 87);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(73, 43);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(195, 20);
            this.nomTextBox.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.precisionDataGridView);
            this.groupBox3.Location = new System.Drawing.Point(311, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(624, 358);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Liste Précision";
            // 
            // precisionDataGridView
            // 
            this.precisionDataGridView.AllowUserToAddRows = false;
            this.precisionDataGridView.AutoGenerateColumns = false;
            this.precisionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.precisionDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5,
            this.prealable,
            this.Contenue,
            this.pmodifier,
            this.psupprimer});
            this.precisionDataGridView.DataSource = this.precisionBindingSource;
            this.precisionDataGridView.Location = new System.Drawing.Point(6, 21);
            this.precisionDataGridView.Name = "precisionDataGridView";
            this.precisionDataGridView.Size = new System.Drawing.Size(612, 311);
            this.precisionDataGridView.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(860, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bend
            // 
            this.bend.Location = new System.Drawing.Point(737, 425);
            this.bend.Name = "bend";
            this.bend.Size = new System.Drawing.Size(69, 23);
            this.bend.TabIndex = 15;
            this.bend.Text = ">>";
            this.bend.UseVisualStyleBackColor = true;
            // 
            // bSuivant
            // 
            this.bSuivant.Location = new System.Drawing.Point(636, 425);
            this.bSuivant.Name = "bSuivant";
            this.bSuivant.Size = new System.Drawing.Size(69, 23);
            this.bSuivant.TabIndex = 14;
            this.bSuivant.Text = ">";
            this.bSuivant.UseVisualStyleBackColor = true;
            // 
            // bpervious
            // 
            this.bpervious.Location = new System.Drawing.Point(533, 425);
            this.bpervious.Name = "bpervious";
            this.bpervious.Size = new System.Drawing.Size(69, 23);
            this.bpervious.TabIndex = 13;
            this.bpervious.Text = "<";
            this.bpervious.UseVisualStyleBackColor = true;
            // 
            // bfirst
            // 
            this.bfirst.Location = new System.Drawing.Point(433, 425);
            this.bfirst.Name = "bfirst";
            this.bfirst.Size = new System.Drawing.Size(69, 23);
            this.bfirst.TabIndex = 12;
            this.bfirst.Text = "<<";
            this.bfirst.UseVisualStyleBackColor = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Mod";
            this.dataGridViewImageColumn1.HeaderText = "pmodifier";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.DataPropertyName = "Mod";
            this.dataGridViewImageColumn2.HeaderText = "psupprimer";
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // precisionBindingSource
            // 
            this.precisionBindingSource.DataSource = typeof(CompetencePlus.PackagePrecision.Precision);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nom";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titre";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Duree";
            this.dataGridViewTextBoxColumn5.HeaderText = "Duree";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // prealable
            // 
            this.prealable.HeaderText = "prealable";
            this.prealable.Name = "prealable";
            this.prealable.Text = "prealable";
            this.prealable.ToolTipText = "prealable";
            this.prealable.UseColumnTextForButtonValue = true;
            // 
            // Contenue
            // 
            this.Contenue.HeaderText = "Contenue";
            this.Contenue.Name = "Contenue";
            this.Contenue.Text = "Contenue";
            this.Contenue.ToolTipText = "Contenue";
            this.Contenue.UseColumnTextForButtonValue = true;
            // 
            // pmodifier
            // 
            this.pmodifier.HeaderText = "";
            this.pmodifier.Image = global::CompetencePlus.Properties.Resources.Update;
            this.pmodifier.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.pmodifier.Name = "pmodifier";
            this.pmodifier.Width = 30;
            // 
            // psupprimer
            // 
            this.psupprimer.HeaderText = "";
            this.psupprimer.Image = global::CompetencePlus.Properties.Resources.Delete;
            this.psupprimer.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.psupprimer.Name = "psupprimer";
            this.psupprimer.Width = 30;
            // 
            // FormeGestionPrecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 463);
            this.Controls.Add(this.bend);
            this.Controls.Add(this.bSuivant);
            this.Controls.Add(this.bpervious);
            this.Controls.Add(this.bfirst);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormeGestionPrecision";
            this.Text = "Gestion Precisions";
            this.Load += new System.EventHandler(this.FormeGestionPrecision_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dureeTrackBar)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.precisionDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.precisionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label dureeLabel1;
        private System.Windows.Forms.Label nomLabel1;
        private System.Windows.Forms.TrackBar dureeTrackBar;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.DataGridView precisionDataGridView;
        private System.Windows.Forms.BindingSource precisionBindingSource;
        private System.Windows.Forms.Button bend;
        private System.Windows.Forms.Button bSuivant;
        private System.Windows.Forms.Button bpervious;
        private System.Windows.Forms.Button bfirst;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewButtonColumn prealable;
        private System.Windows.Forms.DataGridViewButtonColumn Contenue;
        private System.Windows.Forms.DataGridViewImageColumn pmodifier;
        private System.Windows.Forms.DataGridViewImageColumn psupprimer;
    }
}