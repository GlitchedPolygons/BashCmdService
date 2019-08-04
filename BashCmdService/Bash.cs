using System.Diagnostics;

namespace GlitchedPolygons.Services.Bash
{
    /// <summary>
    /// Bash command line service interface for apps installed &amp; running on Linux.
    /// </summary>
    public class Bash : IBash
    {
        /// <summary>
        /// Executes the passed bash command.<para> </para>
        /// Only works on apps running from Linux!
        /// </summary>
        /// <param name="cmd">The command to execute.</param>
        public void Exec(string cmd)
        {
            string escapedArgs = cmd.Replace("\"", "\\\"");

            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true,
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "/bin/bash",
                    Arguments = $"-c \"{escapedArgs}\""
                }
            };

            process.Start();
            process.WaitForExit();
        }
    }
}
