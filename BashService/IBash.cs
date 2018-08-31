namespace GlitchedPolygons.Services.Bash
{
    /// <summary>
    /// Bash command line service interface for ASP.NET Core apps installed on Linux.
    /// </summary>
    public interface IBash
    {
        /// <summary>
        /// Executes the passed bash command.<para> </para>
        /// Only works on ASP.NET Core apps installed on a Linux OS!!!
        /// </summary>
        /// <param name="cmd">The command to execute.</param>
        void Exec(string cmd);
    }
}
