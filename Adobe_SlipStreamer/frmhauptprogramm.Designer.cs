
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
            this.cmdStep_1 = new System.Windows.Forms.Button();
            this.cmdStep_2 = new System.Windows.Forms.Button();
            this.cmdStep_3 = new System.Windows.Forms.Button();
            this.lstUpdateFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cmdStep_1
            // 
            this.cmdStep_1.Location = new System.Drawing.Point(12, 30);
            this.cmdStep_1.Name = "cmdStep_1";
            this.cmdStep_1.Size = new System.Drawing.Size(223, 80);
            this.cmdStep_1.TabIndex = 0;
            this.cmdStep_1.Text = "Step 1";
            this.cmdStep_1.UseVisualStyleBackColor = true;
            this.cmdStep_1.Click += new System.EventHandler(this.cmdStep_1_Click);
            // 
            // cmdStep_2
            // 
            this.cmdStep_2.Location = new System.Drawing.Point(12, 126);
            this.cmdStep_2.Name = "cmdStep_2";
            this.cmdStep_2.Size = new System.Drawing.Size(223, 71);
            this.cmdStep_2.TabIndex = 1;
            this.cmdStep_2.Text = "Step 2";
            this.cmdStep_2.UseVisualStyleBackColor = true;
            this.cmdStep_2.Click += new System.EventHandler(this.cmdStep_2_Click);
            // 
            // cmdStep_3
            // 
            this.cmdStep_3.Enabled = false;
            this.cmdStep_3.Location = new System.Drawing.Point(12, 212);
            this.cmdStep_3.Name = "cmdStep_3";
            this.cmdStep_3.Size = new System.Drawing.Size(223, 71);
            this.cmdStep_3.TabIndex = 2;
            this.cmdStep_3.Text = "Step 3";
            this.cmdStep_3.UseVisualStyleBackColor = true;
            this.cmdStep_3.Click += new System.EventHandler(this.cmdStep_3_Click);
            // 
            // lstUpdateFile
            // 
            this.lstUpdateFile.AllowDrop = true;
            this.lstUpdateFile.FormattingEnabled = true;
            this.lstUpdateFile.ItemHeight = 25;
            this.lstUpdateFile.Location = new System.Drawing.Point(323, 92);
            this.lstUpdateFile.Name = "lstUpdateFile";
            this.lstUpdateFile.Size = new System.Drawing.Size(400, 254);
            this.lstUpdateFile.TabIndex = 3;
            this.lstUpdateFile.DragDrop += new System.Windows.Forms.DragEventHandler(this.lstUpdateFile_DragDrop);
            this.lstUpdateFile.DragEnter += new System.Windows.Forms.DragEventHandler(this.lstUpdateFile_DragEnter);
            // 
            // frmhauptprogramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstUpdateFile);
            this.Controls.Add(this.cmdStep_3);
            this.Controls.Add(this.cmdStep_2);
            this.Controls.Add(this.cmdStep_1);
            this.Name = "frmhauptprogramm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmhauptprogramm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdStep_1;
        private System.Windows.Forms.Button cmdStep_2;
        private System.Windows.Forms.Button cmdStep_3;
        private System.Windows.Forms.ListBox lstUpdateFile;
    }
}

