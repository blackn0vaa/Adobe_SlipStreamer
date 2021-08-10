using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public string PfadMSI = @"C:\temp\AcroRdrDC1500720033_de_DE.msi";
        public string PfadADC = @"C:\adc\";

        public frmhauptprogramm()
        {
            InitializeComponent();
        }

        private void frmhauptprogramm_Load(object sender, EventArgs e)
        {

        }

        private void cmdSlipstream_Click(object sender, EventArgs e)
        {
            //Ist die MSI File vorhanden?
            DateiVorhanden();


            try
            {
                System.IO.Directory.Delete(PfadADC, true);
            }
            catch { }          
        }

        private void cmdInstall_Click(object sender, EventArgs e)
        {
            BasisversionInstallieren();
        }

        private void cmdPaketBauen_Click(object sender, EventArgs e)
        {
            SlipStream();
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

                }
                catch { }
            }
            else
            {
                try
                {
                    System.IO.File.Delete(PfadMSI);
                    File.WriteAllBytes(PfadMSI, Properties.Resources.AcroRdrDC1500720033_de_DE);
                }
                catch { }

            }


        }



        public void BasisversionInstallieren()
        {
            //msiexec /a AcroRdrDC1500720033_de_DE.msi TARGETDIR="C:\adc" /qn
            //string installcommand = "msiexec /a c:/temp/AcroRdrDC1500720033_de_DE.msi TARGETDIR=" + "c:/adc/" + "/qn";

            //DoCmd.ShellExecute("msiexec ", "/a c:/temp/AcroRdrDC1500720033_de_DE.msi");

            System.Diagnostics.Process.Start("msiexec", "/a c:\\temp\\AcroRdrDC1500720033_de_DE.msi TARGETDIR=C:\\adc /qn");

        }

        public void SlipStream()
        {
            //msiexec /a "C:\adc\AcroRdrDC1500720033_de_DE.msi" /p C:\Users\h.barthelmes\Desktop\AcroRdrDCUpd2100120150.msp
            System.Diagnostics.Process.Start("msiexec", "/a C:\\adc\\AcroRdrDC1500720033_de_DE.msi /p C:\\temp\\AcroRdrDCUpd2100520060.msp");
        }


    }
}
