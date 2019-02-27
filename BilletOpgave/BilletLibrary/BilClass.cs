using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Bil klasse der indeholder værdier for metoderne Pris og Køretøj
    /// </summary>
    public class BilClass : BilletDLL
    {
        /// <summary>
        /// Returnerer prisen i decimal type.
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 240;
        }
        /// <summary>
        /// Returnerer køretøjet i string type.
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "Bil";
        }
    }
}
