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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fahrplan));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnabfahrtstafel = new System.Windows.Forms.Button();
            this.btnVerbindung = new System.Windows.Forms.Button();
            this.grbSuche = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnMail = new System.Windows.Forms.Button();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.grbResultat = new System.Windows.Forms.GroupBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblLaden = new System.Windows.Forms.Label();
            this.dgvResultat = new System.Windows.Forms.DataGridView();
            this.pnlfahrplan = new System.Windows.Forms.Panel();
            this.pnlAbfahrtsplan = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gpbSuche = new System.Windows.Forms.GroupBox();
            this.lblLädt2 = new System.Windows.Forms.Label();
            this.dgvAbfahrtsplan = new System.Windows.Forms.DataGridView();
            this.btnAbfahrt = new System.Windows.Forms.Button();
            this.lsbVon = new System.Windows.Forms.ListBox();
            this.lblvon = new System.Windows.Forms.Label();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.lblAbfahrtsplan = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnKarte = new System.Windows.Forms.Button();
            this.grbSuche.SuspendLayout();
            this.grbResultat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).BeginInit();
            this.pnlfahrplan.SuspendLayout();
            this.pnlAbfahrtsplan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gpbSuche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtsplan)).BeginInit();
            this.SuspendLayout();
            // 
            // btnabfahrtstafel
            // 
            this.btnabfahrtstafel.BackColor = System.Drawing.Color.Red;
            this.btnabfahrtstafel.ForeColor = System.Drawing.Color.White;
            this.btnabfahrtstafel.Location = new System.Drawing.Point(209, 11);
            this.btnabfahrtstafel.Name = "btnabfahrtstafel";
            this.btnabfahrtstafel.Size = new System.Drawing.Size(111, 54);
            this.btnabfahrtstafel.TabIndex = 12;
            this.btnabfahrtstafel.Text = "Abfahrtstafel";
            this.btnabfahrtstafel.UseVisualStyleBackColor = false;
            this.btnabfahrtstafel.Click += new System.EventHandler(this.btnabfahrtstafel_Click);
            // 
            // btnVerbindung
            // 
            this.btnVerbindung.BackColor = System.Drawing.Color.Red;
            this.btnVerbindung.ForeColor = System.Drawing.Color.White;
            this.btnVerbindung.Location = new System.Drawing.Point(52, 12);
            this.btnVerbindung.Name = "btnVerbindung";
            this.btnVerbindung.Size = new System.Drawing.Size(123, 53);
            this.btnVerbindung.TabIndex = 13;
            this.btnVerbindung.Text = "Verbindung suchen";
            this.btnVerbindung.UseVisualStyleBackColor = false;
            this.btnVerbindung.Click += new System.EventHandler(this.btnVerbindung_Click);
            // 
            // grbSuche
            // 
            this.grbSuche.Controls.Add(this.panel1);
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
            this.grbSuche.Location = new System.Drawing.Point(27, 6);
            this.grbSuche.Name = "grbSuche";
            this.grbSuche.Size = new System.Drawing.Size(796, 186);
            this.grbSuche.TabIndex = 10;
            this.grbSuche.TabStop = false;
            this.grbSuche.Text = "Suche";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-92, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(86, 24);
            this.panel1.TabIndex = 15;
            // 
            // dtpUhrzeit
            // 
            this.dtpUhrzeit.CustomFormat = "HH.mm";
            this.dtpUhrzeit.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpUhrzeit.Location = new System.Drawing.Point(93, 137);
            this.dtpUhrzeit.Name = "dtpUhrzeit";
            this.dtpUhrzeit.ShowUpDown = true;
            this.dtpUhrzeit.Size = new System.Drawing.Size(74, 24);
            this.dtpUhrzeit.TabIndex = 12;
            // 
            // dtpDatum
            // 
            this.dtpDatum.CustomFormat = "";
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDatum.Location = new System.Drawing.Point(243, 137);
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
            this.txtZiel.TabIndex = 2;
            this.txtZiel.TextChanged += new System.EventHandler(this.txtZiel_TextChanged_1);
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
            this.btnSuchen.Location = new System.Drawing.Point(610, 135);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(147, 33);
            this.btnSuchen.TabIndex = 3;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.btnSuchen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(173, 140);
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
            this.txtAbfahrtsort.TextChanged += new System.EventHandler(this.txtAbfahrtsort_TextChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 140);
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
            this.lsbAbfahrtsort.SelectedIndexChanged += new System.EventHandler(this.lsbAbfahrtsort_SelectedIndexChanged_1);
            // 
            // lsbZiel
            // 
            this.lsbZiel.FormattingEnabled = true;
            this.lsbZiel.ItemHeight = 18;
            this.lsbZiel.Location = new System.Drawing.Point(515, 53);
            this.lsbZiel.Name = "lsbZiel";
            this.lsbZiel.Size = new System.Drawing.Size(242, 76);
            this.lsbZiel.TabIndex = 2;
            this.lsbZiel.Visible = false;
            this.lsbZiel.SelectedIndexChanged += new System.EventHandler(this.lsbZiel_SelectedIndexChanged_1);
            // 
            // btnMail
            // 
            this.btnMail.Location = new System.Drawing.Point(635, 18);
            this.btnMail.Name = "btnMail";
            this.btnMail.Size = new System.Drawing.Size(122, 29);
            this.btnMail.TabIndex = 17;
            this.btnMail.Text = "Schicken";
            this.btnMail.UseVisualStyleBackColor = true;
            this.btnMail.Click += new System.EventHandler(this.btnMail_Click);
            // 
            // txtMail
            // 
            this.txtMail.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMail.Location = new System.Drawing.Point(466, 20);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(163, 24);
            this.txtMail.TabIndex = 16;
            this.txtMail.Text = "max@gmail.ch";
            this.txtMail.Click += new System.EventHandler(this.txtMail_Click);
            // 
            // grbResultat
            // 
            this.grbResultat.Controls.Add(this.lblMail);
            this.grbResultat.Controls.Add(this.btnMail);
            this.grbResultat.Controls.Add(this.lblLaden);
            this.grbResultat.Controls.Add(this.txtMail);
            this.grbResultat.Controls.Add(this.dgvResultat);
            this.grbResultat.Location = new System.Drawing.Point(27, 198);
            this.grbResultat.Name = "grbResultat";
            this.grbResultat.Size = new System.Drawing.Size(796, 278);
            this.grbResultat.TabIndex = 11;
            this.grbResultat.TabStop = false;
            this.grbResultat.Text = "Resultat";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(302, 23);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(162, 18);
            this.lblMail.TabIndex = 18;
            this.lblMail.Text = "Liste als Mail Schicken:";
            // 
            // lblLaden
            // 
            this.lblLaden.AutoSize = true;
            this.lblLaden.BackColor = System.Drawing.Color.White;
            this.lblLaden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLaden.Location = new System.Drawing.Point(354, 140);
            this.lblLaden.Name = "lblLaden";
            this.lblLaden.Size = new System.Drawing.Size(60, 24);
            this.lblLaden.TabIndex = 1;
            this.lblLaden.Text = "Lädt...";
            this.lblLaden.Visible = false;
            // 
            // dgvResultat
            // 
            this.dgvResultat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvResultat.BackgroundColor = System.Drawing.Color.White;
            this.dgvResultat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultat.Location = new System.Drawing.Point(27, 56);
            this.dgvResultat.Name = "dgvResultat";
            this.dgvResultat.Size = new System.Drawing.Size(730, 215);
            this.dgvResultat.TabIndex = 0;
            // 
            // pnlfahrplan
            // 
            this.pnlfahrplan.Controls.Add(this.grbResultat);
            this.pnlfahrplan.Controls.Add(this.grbSuche);
            this.pnlfahrplan.Controls.Add(this.pnlAbfahrtsplan);
            this.pnlfahrplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlfahrplan.Location = new System.Drawing.Point(-2, 71);
            this.pnlfahrplan.Name = "pnlfahrplan";
            this.pnlfahrplan.Size = new System.Drawing.Size(855, 479);
            this.pnlfahrplan.TabIndex = 0;
            // 
            // pnlAbfahrtsplan
            // 
            this.pnlAbfahrtsplan.Controls.Add(this.pictureBox1);
            this.pnlAbfahrtsplan.Controls.Add(this.gpbSuche);
            this.pnlAbfahrtsplan.Controls.Add(this.lblAbfahrtsplan);
            this.pnlAbfahrtsplan.Location = new System.Drawing.Point(3, 3);
            this.pnlAbfahrtsplan.Name = "pnlAbfahrtsplan";
            this.pnlAbfahrtsplan.Size = new System.Drawing.Size(849, 483);
            this.pnlAbfahrtsplan.TabIndex = 14;
            this.pnlAbfahrtsplan.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(200, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 53);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // gpbSuche
            // 
            this.gpbSuche.Controls.Add(this.lblLädt2);
            this.gpbSuche.Controls.Add(this.dgvAbfahrtsplan);
            this.gpbSuche.Controls.Add(this.btnAbfahrt);
            this.gpbSuche.Controls.Add(this.lsbVon);
            this.gpbSuche.Controls.Add(this.lblvon);
            this.gpbSuche.Controls.Add(this.txtVon);
            this.gpbSuche.Location = new System.Drawing.Point(51, 81);
            this.gpbSuche.Name = "gpbSuche";
            this.gpbSuche.Size = new System.Drawing.Size(769, 339);
            this.gpbSuche.TabIndex = 1;
            this.gpbSuche.TabStop = false;
            this.gpbSuche.Text = "Suche";
            // 
            // lblLädt2
            // 
            this.lblLädt2.AutoSize = true;
            this.lblLädt2.Location = new System.Drawing.Point(565, 158);
            this.lblLädt2.Name = "lblLädt2";
            this.lblLädt2.Size = new System.Drawing.Size(48, 18);
            this.lblLädt2.TabIndex = 5;
            this.lblLädt2.Text = "Lädt...";
            this.lblLädt2.Visible = false;
            // 
            // dgvAbfahrtsplan
            // 
            this.dgvAbfahrtsplan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAbfahrtsplan.BackgroundColor = System.Drawing.Color.White;
            this.dgvAbfahrtsplan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbfahrtsplan.Location = new System.Drawing.Point(421, 23);
            this.dgvAbfahrtsplan.Name = "dgvAbfahrtsplan";
            this.dgvAbfahrtsplan.Size = new System.Drawing.Size(342, 301);
            this.dgvAbfahrtsplan.TabIndex = 4;
            // 
            // btnAbfahrt
            // 
            this.btnAbfahrt.Location = new System.Drawing.Point(216, 56);
            this.btnAbfahrt.Name = "btnAbfahrt";
            this.btnAbfahrt.Size = new System.Drawing.Size(189, 30);
            this.btnAbfahrt.TabIndex = 3;
            this.btnAbfahrt.Text = "Abfahrtstafel anzeigen";
            this.btnAbfahrt.UseVisualStyleBackColor = true;
            this.btnAbfahrt.Click += new System.EventHandler(this.btnAbfahrt_Click);
            // 
            // lsbVon
            // 
            this.lsbVon.FormattingEnabled = true;
            this.lsbVon.ItemHeight = 18;
            this.lsbVon.Location = new System.Drawing.Point(23, 82);
            this.lsbVon.Name = "lsbVon";
            this.lsbVon.Size = new System.Drawing.Size(187, 94);
            this.lsbVon.TabIndex = 2;
            this.lsbVon.Visible = false;
            this.lsbVon.SelectedIndexChanged += new System.EventHandler(this.lsbVon_SelectedIndexChanged);
            // 
            // lblvon
            // 
            this.lblvon.AutoSize = true;
            this.lblvon.Location = new System.Drawing.Point(23, 38);
            this.lblvon.Name = "lblvon";
            this.lblvon.Size = new System.Drawing.Size(38, 18);
            this.lblvon.TabIndex = 1;
            this.lblvon.Text = "Von:";
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(23, 59);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(187, 24);
            this.txtVon.TabIndex = 0;
            this.txtVon.TextChanged += new System.EventHandler(this.txtVon_TextChanged);
            // 
            // lblAbfahrtsplan
            // 
            this.lblAbfahrtsplan.AutoSize = true;
            this.lblAbfahrtsplan.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbfahrtsplan.Location = new System.Drawing.Point(48, 28);
            this.lblAbfahrtsplan.Name = "lblAbfahrtsplan";
            this.lblAbfahrtsplan.Size = new System.Drawing.Size(146, 29);
            this.lblAbfahrtsplan.TabIndex = 0;
            this.lblAbfahrtsplan.Text = "Abfahrtsplan";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(650, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 14;
            this.button1.Text = "Anwendung Schliessen";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKarte
            // 
            this.btnKarte.BackColor = System.Drawing.Color.Red;
            this.btnKarte.ForeColor = System.Drawing.Color.White;
            this.btnKarte.Location = new System.Drawing.Point(356, 13);
            this.btnKarte.Name = "btnKarte";
            this.btnKarte.Size = new System.Drawing.Size(111, 52);
            this.btnKarte.TabIndex = 16;
            this.btnKarte.Text = "Karte";
            this.btnKarte.UseVisualStyleBackColor = false;
            this.btnKarte.Click += new System.EventHandler(this.btnKarte_Click);
            // 
            // Fahrplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(850, 560);
            this.Controls.Add(this.btnKarte);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVerbindung);
            this.Controls.Add(this.btnabfahrtstafel);
            this.Controls.Add(this.pnlfahrplan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(866, 599);
            this.Name = "Fahrplan";
            this.Text = "Fahrplan";
            this.grbSuche.ResumeLayout(false);
            this.grbSuche.PerformLayout();
            this.grbResultat.ResumeLayout(false);
            this.grbResultat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultat)).EndInit();
            this.pnlfahrplan.ResumeLayout(false);
            this.pnlAbfahrtsplan.ResumeLayout(false);
            this.pnlAbfahrtsplan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gpbSuche.ResumeLayout(false);
            this.gpbSuche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbfahrtsplan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnabfahrtstafel;
        private System.Windows.Forms.Button btnVerbindung;
        private System.Windows.Forms.GroupBox grbSuche;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpUhrzeit;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnWechseln;
        private System.Windows.Forms.TextBox txtZiel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAbfahrtsort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lsbAbfahrtsort;
        private System.Windows.Forms.ListBox lsbZiel;
        private System.Windows.Forms.GroupBox grbResultat;
        private System.Windows.Forms.Label lblLaden;
        private System.Windows.Forms.DataGridView dgvResultat;
        private System.Windows.Forms.Panel pnlfahrplan;
        private System.Windows.Forms.Panel pnlAbfahrtsplan;
        private System.Windows.Forms.GroupBox gpbSuche;
        private System.Windows.Forms.DataGridView dgvAbfahrtsplan;
        private System.Windows.Forms.Button btnAbfahrt;
        private System.Windows.Forms.ListBox lsbVon;
        private System.Windows.Forms.Label lblvon;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.Label lblAbfahrtsplan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKarte;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Button btnMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblLädt2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

