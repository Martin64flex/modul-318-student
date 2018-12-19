namespace Fahrplan
{
    partial class Fahrplan
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlfahrplan = new System.Windows.Forms.Panel();
            this.grbResultat = new System.Windows.Forms.GroupBox();
            this.dgvResultat = new System.Windows.Forms.DataGridView();
            this.grbSuche = new System.Windows.Forms.GroupBox();
            this.dtpUhrzeit = new System.Windows.Forms.DateTimePicker();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnWechseln = new System.Windows.Forms.Button();
            this.txtZiel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAbfahrtsort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsbAbfahrtsort = new System.Windows.Forms.ListBox();
            this.lsbZiel = new System.Windows.Forms.ListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblladen = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlfahrplan.SuspendLayout();
            this.grbResultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).BeginInit();
            this.grbSuche.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlfahrplan
            // 
            this.pnlfahrplan.Controls.Add(this.button1);
            this.pnlfahrplan.Controls.Add(this.grbResultat);
            this.pnlfahrplan.Controls.Add(this.grbSuche);
            this.pnlfahrplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlfahrplan.Location = new System.Drawing.Point(-2, 1);
            this.pnlfahrplan.Name = "pnlfahrplan";
            this.pnlfahrplan.Size = new System.Drawing.Size(853, 525);
            this.pnlfahrplan.TabIndex = 0;
            // 
            // grbResultat
            // 
            this.grbResultat.Controls.Add(this.lblladen);
            this.grbResultat.Controls.Add(this.dgvResultat);
            this.grbResultat.Location = new System.Drawing.Point(28, 235);
            this.grbResultat.Name = "grbResultat";
            this.grbResultat.Size = new System.Drawing.Size(796, 273);
            this.grbResultat.TabIndex = 11;
            this.grbResultat.TabStop = false;
            this.grbResultat.Text = "Resultat";
            // 
            // dgvResultat
            // 
            this.dgvResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultat.Location = new System.Drawing.Point(27, 36);
            this.dgvResultat.Name = "dgvResultat";
            this.dgvResultat.Size = new System.Drawing.Size(730, 219);
            this.dgvResultat.TabIndex = 0;
            // 
            // grbSuche
            // 
            this.grbSuche.Controls.Add(this.dtpUhrzeit);
            this.grbSuche.Controls.Add(this.dtpDatum);
            this.grbSuche.Controls.Add(this.btnWechseln);
            this.grbSuche.Controls.Add(this.txtZiel);
            this.grbSuche.Controls.Add(this.label1);
            this.grbSuche.Controls.Add(this.btnSuchen);
            this.grbSuche.Controls.Add(this.label4);
            this.grbSuche.Controls.Add(this.txtAbfahrtsort);
            this.grbSuche.Controls.Add(this.label3);
            this.grbSuche.Controls.Add(this.label2);
            this.grbSuche.Controls.Add(this.lsbAbfahrtsort);
            this.grbSuche.Controls.Add(this.lsbZiel);
            this.grbSuche.Location = new System.Drawing.Point(28, 82);
            this.grbSuche.Name = "grbSuche";
            this.grbSuche.Size = new System.Drawing.Size(796, 129);
            this.grbSuche.TabIndex = 10;
            this.grbSuche.TabStop = false;
            this.grbSuche.Text = "Suche";
            // 
            // dtpUhrzeit
            // 
            this.dtpUhrzeit.CustomFormat = "HH.mm";
            this.dtpUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUhrzeit.Location = new System.Drawing.Point(89, 76);
            this.dtpUhrzeit.Name = "dtpUhrzeit";
            this.dtpUhrzeit.ShowUpDown = true;
            this.dtpUhrzeit.Size = new System.Drawing.Size(74, 24);
            this.dtpUhrzeit.TabIndex = 12;
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "dd.mm.yyyy";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(243, 76);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(113, 24);
            this.dtpDatum.TabIndex = 11;
            // 
            // btnWechseln
            // 
            this.btnWechseln.Location = new System.Drawing.Point(389, 29);
            this.btnWechseln.Name = "btnWechseln";
            this.btnWechseln.Size = new System.Drawing.Size(53, 24);
            this.btnWechseln.TabIndex = 10;
            this.btnWechseln.Text = "<- ->";
            this.btnWechseln.UseVisualStyleBackColor = true;
            this.btnWechseln.Click += new System.EventHandler(this.btnWechseln_Click);
            // 
            // txtZiel
            // 
            this.txtZiel.Location = new System.Drawing.Point(515, 29);
            this.txtZiel.Name = "txtZiel";
            this.txtZiel.Size = new System.Drawing.Size(242, 24);
            this.txtZiel.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Abfahrtsort:";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(622, 72);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(135, 33);
            this.btnSuchen.TabIndex = 0;
            this.btnSuchen.Text = "Verbing suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Datum:";
            // 
            // txtAbfahrtsort
            // 
            this.txtAbfahrtsort.Location = new System.Drawing.Point(114, 29);
            this.txtAbfahrtsort.Name = "txtAbfahrtsort";
            this.txtAbfahrtsort.Size = new System.Drawing.Size(242, 24);
            this.txtAbfahrtsort.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uhrzeit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(474, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ziel:";
            // 
            // lsbAbfahrtsort
            // 
            this.lsbAbfahrtsort.FormattingEnabled = true;
            this.lsbAbfahrtsort.ItemHeight = 18;
            this.lsbAbfahrtsort.Location = new System.Drawing.Point(114, 53);
            this.lsbAbfahrtsort.Name = "lsbAbfahrtsort";
            this.lsbAbfahrtsort.Size = new System.Drawing.Size(242, 76);
            this.lsbAbfahrtsort.TabIndex = 13;
            this.lsbAbfahrtsort.Visible = false;
            // 
            // lsbZiel
            // 
            this.lsbZiel.FormattingEnabled = true;
            this.lsbZiel.ItemHeight = 18;
            this.lsbZiel.Location = new System.Drawing.Point(515, 53);
            this.lsbZiel.Name = "lsbZiel";
            this.lsbZiel.Size = new System.Drawing.Size(242, 76);
            this.lsbZiel.TabIndex = 14;
            this.lsbZiel.Visible = false;
            // 
            // lblladen
            // 
            this.lblladen.AutoSize = true;
            this.lblladen.Location = new System.Drawing.Point(386, 135);
            this.lblladen.Name = "lblladen";
            this.lblladen.Size = new System.Drawing.Size(52, 18);
            this.lblladen.TabIndex = 1;
            this.lblladen.Text = "Lädt....";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(164, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "btnabfahrt";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 526);
            this.Controls.Add(this.pnlfahrplan);
            this.Name = "Fahrplan";
            this.Text = "Fahrplan";
            this.pnlfahrplan.ResumeLayout(false);
            this.grbResultat.ResumeLayout(false);
            this.grbResultat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).EndInit();
            this.grbSuche.ResumeLayout(false);
            this.grbSuche.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlfahrplan;
        private System.Windows.Forms.GroupBox grbSuche;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAbfahrtsort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbResultat;
        private System.Windows.Forms.Button btnWechseln;
        private System.Windows.Forms.TextBox txtZiel;
        private System.Windows.Forms.DataGridView dgvResultat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DateTimePicker dtpUhrzeit;
        private System.Windows.Forms.ListBox lsbAbfahrtsort;
        private System.Windows.Forms.ListBox lsbZiel;
        private System.Windows.Forms.Label lblladen;
        private System.Windows.Forms.Button button1;
    }
}

