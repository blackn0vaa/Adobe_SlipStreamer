using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adobe_SlipStreamer
{
    public partial class frmhauptprogramm : Form
    {
        //Public Variablen
        public string PfadMSI = @"C:\temp\AcroRdrDC.msi";
        public string PfadADC = @"C:\adc\";

        public frmhauptprogramm()
        {
            InitializeComponent();
        }

        private void frmhauptprogramm_Load(object sender, EventArgs e)
        {
            DateiVorhanden();

        }

        private void cmdStep_1_Click(object sender, EventArgs e)
        {
            DoStep_1();
            cmdStep_1.Enabled = false;
            timer1.Enabled = true;
            timer1.Start();
            
        }

        private void cmdStep_2_Click(object sender, EventArgs e)
        {
            DoStep_2();
            timer1.Stop();
            cmdStep_2.Enabled = false;
            Process.Start("explorer.exe", PfadADC);
        }

        private void cmdStep_3_Click(object sender, EventArgs e)
        {
            DoStep_3();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cmdStep_2.Enabled = true;
        }

        private void DateiVorhanden()
        {
            //Wenn datei existiert, dann löschen
            if (System.IO.File.Exists(PfadMSI))
            {
                try
                {
                    System.IO.File.Delete(PfadMSI);
                    File.WriteAllBytes(PfadMSI, Properties.Resources.AcroRdrDC1500720033_de_DE);
                    File.WriteAllBytes(PfadADC + "AcroRdrDC.mst", Properties.Resources.AcroRdrDC);

                }
                catch { }
            }
            else
            {
                try
                {
                    System.IO.File.Delete(PfadMSI);
                    File.WriteAllBytes(PfadMSI, Properties.Resources.AcroRdrDC1500720033_de_DE);
                    File.WriteAllBytes(PfadADC + "AcroRdrDC.mst", Properties.Resources.AcroRdrDC);
                }
                catch { }

            }


        }


        public void DoStep_1()
        {
            //msiexec /a AcroRdrDC1500720033_de_DE.msi TARGETDIR="C:\adc" /qn
            //string installcommand = "msiexec /a c:/temp/AcroRdrDC1500720033_de_DE.msi TARGETDIR=" + "c:/adc/" + "/qn";

            //DoCmd.ShellExecute("msiexec ", "/a c:/temp/AcroRdrDC1500720033_de_DE.msi");äö

            System.Diagnostics.Process.Start("msiexec", "/a c:\\temp\\AcroRdrDC.msi TARGETDIR=C:\\adc /qn");

        }

        public void DoStep_2()
        {
            //msiexec /a "C:\adc\AcroRdrDC1500720033_de_DE.msi" /p C:\Users\h.barthelmes\Desktop\AcroRdrDCUpd2100120150.msp
            System.Diagnostics.Process.Start("msiexec", "/a C:\\adc\\AcroRdrDC.msi /p " + lstUpdateFile.Items[0].ToString() + " /qn");

            //MessageBox.Show(lstUpdateFile.SelectedItem.ToString());
        }

        public void DoStep_3()
        {
            //start /w msiexec /i "%wd%\deploy\%version%\AcroRead.msi" /qn TRANSFORMS="%wd%\deploy\%version%\AcroRead.mst"
            //System.Diagnostics.Process.Start
            //Console.WriteLine("start /w msiexec /i \"C:\\adc\\AcroRdrDC.msi\" /qn TRANSFORMS=\"C:\\adc\\AcroRdrDC.mst\"");
        }

        private void lstUpdateFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                lstUpdateFile.Items.Add(file);
        }

        private void lstUpdateFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }


    }
}
