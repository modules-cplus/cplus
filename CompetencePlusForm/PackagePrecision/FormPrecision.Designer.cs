namespace CompetencePlus.PackagePrecision
{
    partial class FormPrecision
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
            System.Windows.Forms.Label descriptionLabel;
            this.precisionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.dureeTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.benregistrer = new System.Windows.Forms.Button();
            nomLabel = new System.Windows.Forms.Label();
            dureeLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.precisionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // precisionBindingSource
            // 
            this.precisionBindingSource.DataSource = typeof(CompetencePlus.PackagePrecision.Precision);
            // 
            // nomLabel
            // 
            nomLabel.AutoSize = true;
            nomLabel.Location = new System.Drawing.Point(36, 65);
            nomLabel.Name = "nomLabel";
            nomLabel.Size = new System.Drawing.Size(32, 13);
            nomLabel.TabIndex = 1;
            nomLabel.Text = "Nom:";
            // 
            // nomTextBox
            // 
            this.nomTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.precisionBindingSource, "Nom", true));
            this.nomTextBox.Location = new System.Drawing.Point(74, 62);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(496, 20);
            this.nomTextBox.TabIndex = 2;
            // 
            // dureeLabel
            // 
            dureeLabel.AutoSize = true;
            dureeLabel.Location = new System.Drawing.Point(29, 105);
            dureeLabel.Name = "dureeLabel";
            dureeLabel.Size = new System.Drawing.Size(39, 13);
            dureeLabel.TabIndex = 2;
            dureeLabel.Text = "Duree:";
            // 
            // dureeTextBox
            // 
            this.dureeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.precisionBindingSource, "Duree", true));
            this.dureeTextBox.Location = new System.Drawing.Point(74, 102);
            this.dureeTextBox.Name = "dureeTextBox";
            this.dureeTextBox.Size = new System.Drawing.Size(212, 20);
            this.dureeTextBox.TabIndex = 3;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 158);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 4;
            descriptionLabel.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.precisionBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(12, 174);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(613, 114);
            this.descriptionTextBox.TabIndex = 5;
            // 
            // benregistrer
            // 
            this.benregistrer.Location = new System.Drawing.Point(39, 312);
            this.benregistrer.Name = "benregistrer";
            this.benregistrer.Size = new System.Drawing.Size(75, 23);
            this.benregistrer.TabIndex = 6;
            this.benregistrer.Text = "Enregistrer";
            this.benregistrer.UseVisualStyleBackColor = true;
            this.benregistrer.Click += new System.EventHandler(this.benregistrer_Click);
            // 
            // FormPrecision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 362);
            this.Controls.Add(this.benregistrer);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(dureeLabel);
            this.Controls.Add(this.dureeTextBox);
            this.Controls.Add(nomLabel);
            this.Controls.Add(this.nomTextBox);
            this.Name = "FormPrecision";
            this.Text = "Form Ajoute Precision";
            ((System.ComponentModel.ISupportInitialize)(this.precisionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource precisionBindingSource;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.TextBox dureeTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button benregistrer;
    }
}