namespace Fahrplan
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.btnJa = new System.Windows.Forms.Button();
            this.btnNein = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Möchten Sie die Anwedung wirklich schliessen?";
            // 
            // btnJa
            // 
            this.btnJa.Location = new System.Drawing.Point(95, 91);
            this.btnJa.Name = "btnJa";
            this.btnJa.Size = new System.Drawing.Size(75, 23);
            this.btnJa.TabIndex = 1;
            this.btnJa.Text = "Ja";
            this.btnJa.UseVisualStyleBackColor = true;
            this.btnJa.Click += new System.EventHandler(this.btnJa_Click);
            // 
            // btnNein
            // 
            this.btnNein.Location = new System.Drawing.Point(225, 91);
            this.btnNein.Name = "btnNein";
            this.btnNein.Size = new System.Drawing.Size(75, 23);
            this.btnNein.TabIndex = 2;
            this.btnNein.Text = "Nein";
            this.btnNein.UseVisualStyleBackColor = true;
            this.btnNein.Click += new System.EventHandler(this.btnNein_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(401, 157);
            this.Controls.Add(this.btnNein);
            this.Controls.Add(this.btnJa);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Anwedung schliessen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnJa;
        private System.Windows.Forms.Button btnNein;
    }
}