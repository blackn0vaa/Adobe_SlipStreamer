using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;
using System;
using System.Diagnostics;
using System.IO;

namespace Adobe_SlipStreamer
{
    class DoCmd
    {
        [STAThread]
        public static string ShellExecute(string cmd, string args)

        {
            Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = cmd;
            p.StartInfo.Arguments = args;
            p.StartInfo.CreateNoWindow = true;

            //Für die rückgabe
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();
            p.WaitForExit();


            //Output lesen
            StreamReader sr = p.StandardOutput;

            return (sr.ReadToEnd());

        }

    }
 
}