
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmhauptprogramm));
            this.cmdStep_2 = new System.Windows.Forms.Button();
            this.lstUpdateFile = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cmdDipOeffnen = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3Counter = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cmdStep_2
            // 
            this.cmdStep_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmdStep_2.Enabled = false;
            this.cmdStep_2.Location = new System.Drawing.Point(14, 37);
            this.cmdStep_2.Name = "cmdStep_2";
            this.cmdStep_2.Size = new System.Drawing.Size(223, 71);
            this.cmdStep_2.TabIndex = 1;
            this.cmdStep_2.Text = "Slipstream";
            this.cmdStep_2.UseVisualStyleBackColor = true;
            this.cmdStep_2.Click += new System.EventHandler(this.cmdStep_2_Click);
            // 
            // lstUpdateFile
            // 
            this.lstUpdateFile.AllowDrop = true;
            this.lstUpdateFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstUpdateFile.FormattingEnabled = true;
            this.lstUpdateFile.ItemHeight = 25;
            this.lstUpdateFile.Location = new System.Drawing.Point(243, 37);
            this.lstUpdateFile.Name = "lstUpdateFile";
            this.lstUpdateFile.Size = new System.Drawing.Size(510, 304);
            this.lstUpdateFile.TabIndex = 3;
            this.lstUpdateFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstUpdateFile_DragDrop);
            this.lstUpdateFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstUpdateFile_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drag&Drop Update Datei";
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 20000;
            // 
            // cmdDipOeffnen
            // 
            this.cmdDipOeffnen.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmdDipOeffnen.Location = new System.Drawing.Point(9, 270);
            this.cmdDipOeffnen.Name = "cmdDipOeffnen";
            this.cmdDipOeffnen.Size = new System.Drawing.Size(223, 71);
            this.cmdDipOeffnen.TabIndex = 5;
            this.cmdDipOeffnen.Text = "DIP struktur öffnen";
            this.cmdDipOeffnen.UseVisualStyleBackColor = true;
            this.cmdDipOeffnen.Click += new System.EventHandler(this.cmdDipOeffnen_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Gezählte Objekte: ";
            // 
            // timer3Counter
            // 
            this.timer3Counter.Enabled = true;
            this.timer3Counter.Tick += new System.EventHandler(this.timer3Counter_Tick);
            // 
            // frmhauptprogramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 368);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmdDipOeffnen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstUpdateFile);
            this.Controls.Add(this.cmdStep_2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(786, 439);
            this.Name = "frmhauptprogramm";
            this.Text = "Schlipschtreamer";
            this.Load += new System.EventHandler(this.frmhauptprogramm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdStep_2;
        private System.Windows.Forms.ListBox lstUpdateFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button cmdDipOeffnen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer3Counter;
    }
}

