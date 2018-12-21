namespace Fahrplan
{
    partial class Maps
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Maps));
            this.btnSchliesen = new System.Windows.Forms.Button();
            this.webKarte = new System.Windows.Forms.WebBrowser();
            this.lblStation = new System.Windows.Forms.Label();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.lsbStation = new System.Windows.Forms.ListBox();
            this.btnAnzeigen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSchliesen
            // 
            this.btnSchliesen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchliesen.Location = new System.Drawing.Point(672, 411);
            this.btnSchliesen.Name = "btnSchliesen";
            this.btnSchliesen.Size = new System.Drawing.Size(89, 27);
            this.btnSchliesen.TabIndex = 0;
            this.btnSchliesen.Text = "Schliesen";
            this.btnSchliesen.UseVisualStyleBackColor = true;
            this.btnSchliesen.Click += new System.EventHandler(this.btnSchliesen_Click);
            // 
            // webKarte
            // 
            this.webKarte.Location = new System.Drawing.Point(0, 85);
            this.webKarte.MinimumSize = new System.Drawing.Size(20, 20);
            this.webKarte.Name = "webKarte";
            this.webKarte.Size = new System.Drawing.Size(799, 367);
            this.webKarte.TabIndex = 1;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStation.Location = new System.Drawing.Point(23, 9);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(58, 18);
            this.lblStation.TabIndex = 2;
            this.lblStation.Text = "Station:";
            // 
            // txtStation
            // 
            this.txtStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStation.Location = new System.Drawing.Point(25, 31);
            this.txtStation.Name = "txtStation";
            this.txtStation.Size = new System.Drawing.Size(220, 24);
            this.txtStation.TabIndex = 3;
            this.txtStation.TextChanged += new System.EventHandler(this.txtStation_TextChanged);
            // 
            // lsbStation
            // 
            this.lsbStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbStation.FormattingEnabled = true;
            this.lsbStation.ItemHeight = 18;
            this.lsbStation.Location = new System.Drawing.Point(25, 54);
            this.lsbStation.Name = "lsbStation";
            this.lsbStation.Size = new System.Drawing.Size(220, 94);
            this.lsbStation.TabIndex = 4;
            this.lsbStation.Visible = false;
            this.lsbStation.SelectedIndexChanged += new System.EventHandler(this.lsbStation_SelectedIndexChanged);
            // 
            // btnAnzeigen
            // 
            this.btnAnzeigen.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnzeigen.Location = new System.Drawing.Point(277, 27);
            this.btnAnzeigen.Name = "btnAnzeigen";
            this.btnAnzeigen.Size = new System.Drawing.Size(143, 33);
            this.btnAnzeigen.TabIndex = 5;
            this.btnAnzeigen.Text = "Station anzeigen";
            this.btnAnzeigen.UseVisualStyleBackColor = true;
            this.btnAnzeigen.Click += new System.EventHandler(this.btnAnzeigen_Click);
            // 
            // Maps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAnzeigen);
            this.Controls.Add(this.lsbStation);
            this.Controls.Add(this.txtStation);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.btnSchliesen);
            this.Controls.Add(this.webKarte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.Name = "Maps";
            this.Text = "Maps";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSchliesen;
        private System.Windows.Forms.WebBrowser webKarte;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.ListBox lsbStation;
        private System.Windows.Forms.Button btnAnzeigen;
    }
}