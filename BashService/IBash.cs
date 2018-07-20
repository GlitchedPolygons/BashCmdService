using System;
using System.Collections.Generic;
using System.Text;

namespace GlitchedPolygons.Services.Bash
{
    /// <summary>
    /// Bash command line service interface for ASP.NET Core apps installed on Linux.
    /// </summary>
    interface IBash
    {
        /// <summary>
        /// Executes the passed bash command. Only works on ASP.NET Core apps installed on a Linux OS!!!
        /// </summary>
        /// <param name="cmd">The command to execute.</param>
        void Exec(string cmd);
    }
}
