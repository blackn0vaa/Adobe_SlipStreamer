
namespace Adobe_SlipStreamer
{
    partial class frmhauptprogramm
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
            this.cmdSlipstream = new System.Windows.Forms.Button();
            this.cmdInstall = new System.Windows.Forms.Button();
            this.cmdPaketBauen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdSlipstream
            // 
            this.cmdSlipstream.Location = new System.Drawing.Point(12, 30);
            this.cmdSlipstream.Name = "cmdSlipstream";
            this.cmdSlipstream.Size = new System.Drawing.Size(223, 80);
            this.cmdSlipstream.TabIndex = 0;
            this.cmdSlipstream.Text = "Slipstream";
            this.cmdSlipstream.UseVisualStyleBackColor = true;
            this.cmdSlipstream.Click += new System.EventHandler(this.cmdSlipstream_Click);
            // 
            // cmdInstall
            // 
            this.cmdInstall.Location = new System.Drawing.Point(12, 126);
            this.cmdInstall.Name = "cmdInstall";
            this.cmdInstall.Size = new System.Drawing.Size(223, 71);
            this.cmdInstall.TabIndex = 1;
            this.cmdInstall.Text = "install";
            this.cmdInstall.UseVisualStyleBackColor = true;
            this.cmdInstall.Click += new System.EventHandler(this.cmdInstall_Click);
            // 
            // cmdPaketBauen
            // 
            this.cmdPaketBauen.Location = new System.Drawing.Point(12, 212);
            this.cmdPaketBauen.Name = "cmdPaketBauen";
            this.cmdPaketBauen.Size = new System.Drawing.Size(223, 71);
            this.cmdPaketBauen.TabIndex = 2;
            this.cmdPaketBauen.Text = "Bauen";
            this.cmdPaketBauen.UseVisualStyleBackColor = true;
            this.cmdPaketBauen.Click += new System.EventHandler(this.cmdPaketBauen_Click);
            // 
            // frmhauptprogramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmdPaketBauen);
            this.Controls.Add(this.cmdInstall);
            this.Controls.Add(this.cmdSlipstream);
            this.Name = "frmhauptprogramm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmhauptprogramm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSlipstream;
        private System.Windows.Forms.Button cmdInstall;
        private System.Windows.Forms.Button cmdPaketBauen;
    }
}

