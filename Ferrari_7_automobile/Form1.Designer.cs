namespace Ferrari_7_automobile
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelVelocita = new System.Windows.Forms.Label();
            this.labelGiriMin = new System.Windows.Forms.Label();
            this.buttonFrena = new System.Windows.Forms.Button();
            this.buttonAccelera = new System.Windows.Forms.Button();
            this.buttonMarciaSu = new System.Windows.Forms.Button();
            this.buttonMarciaGiu = new System.Windows.Forms.Button();
            this.buttonOnOff = new System.Windows.Forms.Button();
            this.labelOnOff = new System.Windows.Forms.Label();
            this.labelMarcia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelVelocita
            // 
            this.labelVelocita.AutoSize = true;
            this.labelVelocita.Location = new System.Drawing.Point(12, 9);
            this.labelVelocita.Name = "labelVelocita";
            this.labelVelocita.Size = new System.Drawing.Size(13, 13);
            this.labelVelocita.TabIndex = 0;
            this.labelVelocita.Text = "0";
            // 
            // labelGiriMin
            // 
            this.labelGiriMin.AutoSize = true;
            this.labelGiriMin.Location = new System.Drawing.Point(43, 9);
            this.labelGiriMin.Name = "labelGiriMin";
            this.labelGiriMin.Size = new System.Drawing.Size(13, 13);
            this.labelGiriMin.TabIndex = 1;
            this.labelGiriMin.Text = "0";
            // 
            // buttonFrena
            // 
            this.buttonFrena.Location = new System.Drawing.Point(12, 35);
            this.buttonFrena.Name = "buttonFrena";
            this.buttonFrena.Size = new System.Drawing.Size(75, 23);
            this.buttonFrena.TabIndex = 2;
            this.buttonFrena.Text = "Freno";
            this.buttonFrena.UseVisualStyleBackColor = true;
            this.buttonFrena.Click += new System.EventHandler(this.buttonFrena_Click);
            // 
            // buttonAccelera
            // 
            this.buttonAccelera.Location = new System.Drawing.Point(107, 35);
            this.buttonAccelera.Name = "buttonAccelera";
            this.buttonAccelera.Size = new System.Drawing.Size(75, 23);
            this.buttonAccelera.TabIndex = 3;
            this.buttonAccelera.Text = "Acceleratore";
            this.buttonAccelera.UseVisualStyleBackColor = true;
            this.buttonAccelera.Click += new System.EventHandler(this.buttonAccelera_Click);
            // 
            // buttonMarciaSu
            // 
            this.buttonMarciaSu.Location = new System.Drawing.Point(204, 35);
            this.buttonMarciaSu.Name = "buttonMarciaSu";
            this.buttonMarciaSu.Size = new System.Drawing.Size(75, 23);
            this.buttonMarciaSu.TabIndex = 4;
            this.buttonMarciaSu.Text = "Marcia Su";
            this.buttonMarciaSu.UseVisualStyleBackColor = true;
            this.buttonMarciaSu.Click += new System.EventHandler(this.buttonMarciaSu_Click);
            // 
            // buttonMarciaGiu
            // 
            this.buttonMarciaGiu.Location = new System.Drawing.Point(304, 35);
            this.buttonMarciaGiu.Name = "buttonMarciaGiu";
            this.buttonMarciaGiu.Size = new System.Drawing.Size(75, 23);
            this.buttonMarciaGiu.TabIndex = 5;
            this.buttonMarciaGiu.Text = "Marcia Giu";
            this.buttonMarciaGiu.UseVisualStyleBackColor = true;
            this.buttonMarciaGiu.Click += new System.EventHandler(this.buttonMarciaGiu_Click);
            // 
            // buttonOnOff
            // 
            this.buttonOnOff.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.buttonOnOff.Location = new System.Drawing.Point(394, 35);
            this.buttonOnOff.Name = "buttonOnOff";
            this.buttonOnOff.Size = new System.Drawing.Size(75, 23);
            this.buttonOnOff.TabIndex = 6;
            this.buttonOnOff.Text = "Engine On";
            this.buttonOnOff.UseVisualStyleBackColor = true;
            this.buttonOnOff.Click += new System.EventHandler(this.buttonOnOff_Click);
            // 
            // labelOnOff
            // 
            this.labelOnOff.AutoSize = true;
            this.labelOnOff.Location = new System.Drawing.Point(74, 9);
            this.labelOnOff.Name = "labelOnOff";
            this.labelOnOff.Size = new System.Drawing.Size(41, 13);
            this.labelOnOff.TabIndex = 7;
            this.labelOnOff.Text = "Spento";
            // 
            // labelMarcia
            // 
            this.labelMarcia.AutoSize = true;
            this.labelMarcia.Location = new System.Drawing.Point(102, 9);
            this.labelMarcia.Name = "labelMarcia";
            this.labelMarcia.Size = new System.Drawing.Size(13, 13);
            this.labelMarcia.TabIndex = 8;
            this.labelMarcia.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelMarcia);
            this.Controls.Add(this.labelOnOff);
            this.Controls.Add(this.buttonOnOff);
            this.Controls.Add(this.buttonMarciaGiu);
            this.Controls.Add(this.buttonMarciaSu);
            this.Controls.Add(this.buttonAccelera);
            this.Controls.Add(this.buttonFrena);
            this.Controls.Add(this.labelGiriMin);
            this.Controls.Add(this.labelVelocita);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVelocita;
        private System.Windows.Forms.Label labelGiriMin;
        private System.Windows.Forms.Button buttonFrena;
        private System.Windows.Forms.Button buttonAccelera;
        private System.Windows.Forms.Button buttonMarciaSu;
        private System.Windows.Forms.Button buttonMarciaGiu;
        private System.Windows.Forms.Button buttonOnOff;
        private System.Windows.Forms.Label labelOnOff;
        private System.Windows.Forms.Label labelMarcia;
    }
}

