namespace GlitchedPolygons.Services.Bash
{
    /// <summary>
    /// Bash command line service interface for apps installed & running on Linux.
    /// </summary>
    public interface IBash
    {
        /// <summary>
        /// Executes the passed bash command.<para> </para>
        /// Only works on apps installed on a Linux OS!
        /// </summary>
        /// <param name="cmd">The command to execute.</param>
        void Exec(string cmd);
    }
}
