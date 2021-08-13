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

            this.Text = "Schlipschtreamer " + this.ProductVersion.ToString();
        }

        [STAThread]
        private void frmhauptprogramm_Load(object sender, EventArgs e)
        {
            DateiVorhanden();
            Process.Start("explorer.exe", @"E:\DIP\ManagedSoftware\source\AdobeReader\DC");
            //E:\DIP\ManagedSoftware\source\AdobeReader\DC
        }

        [STAThread]
        private void cmdStep_1_Click(object sender, EventArgs e)
        {
            DoStep_1();
            cmdStep_1.Enabled = false;
            timer1.Enabled = true;
            timer1.Start();
            
        }

        [STAThread]
        private void cmdStep_2_Click(object sender, EventArgs e)
        {
            DoStep_2();
            timer1.Stop();
            cmdStep_2.Enabled = false;

            //Timer2 start
            timer2.Enabled = true;
            timer2.Start();
            
        }

        [STAThread]
        private void cmdStep_3_Click(object sender, EventArgs e)
        {
            DoStep_3();
        }

        [STAThread]
        private void timer1_Tick(object sender, EventArgs e)
        {
            cmdStep_2.Enabled = true;
        }

        [STAThread]
        private void timer2_Tick(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", PfadADC);
            timer2.Stop();
        }

        [STAThread]
        private void DateiVorhanden()
        {

            try
            {
                System.IO.Directory.Delete("c:\\adc", true);
            }
            catch { }

            //Wenn datei existiert, dann löschen
            if (System.IO.File.Exists(PfadMSI))
            {
                try
                {
                    System.IO.Directory.Delete(PfadMSI);
                    File.WriteAllBytes(PfadMSI, Properties.Resources.AcroRdrDC1500720033_de_DE);
                    File.WriteAllBytes(PfadADC + "AcroRdrDC.mst", Properties.Resources.AcroRdrDC);

                }
                catch { }
            }
            else
            {
                try
                {
                    System.IO.Directory.Delete(PfadMSI);
                    File.WriteAllBytes(PfadMSI, Properties.Resources.AcroRdrDC1500720033_de_DE);
                    File.WriteAllBytes(PfadADC + "AcroRdrDC.mst", Properties.Resources.AcroRdrDC);
                }
                catch { }

            }



        }


        [STAThread]
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

        [STAThread]
        public void DoStep_3()
        {
            //start /w msiexec /i "%wd%\deploy\%version%\AcroRead.msi" /qn TRANSFORMS="%wd%\deploy\%version%\AcroRead.mst"
            //System.Diagnostics.Process.Start
            //Console.WriteLine("start /w msiexec /i \"C:\\adc\\AcroRdrDC.msi\" /qn TRANSFORMS=\"C:\\adc\\AcroRdrDC.mst\"");
        }

        [STAThread]
        private void lstUpdateFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
                lstUpdateFile.Items.Add(file);
        }

        [STAThread]
        private void lstUpdateFile_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;
        }


    }
}
