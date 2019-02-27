using System;
using System.Collections.Generic;
using System.Text;

namespace BilletLibrary
{
    /// <summary>
    /// Motorcykel klasse der indeholder værdier for metoderne Pris og Køretøj
    /// </summary>
    public class MCClass : BilletDLL
    {
        /// <summary>
        /// Returnerer prisen i decimal type.
        /// </summary>
        /// <returns></returns>
        public override decimal Pris()
        {
            return 125;
        }
        /// <summary>
        /// Returnerer køretøjet i string type.
        /// </summary>
        /// <returns></returns>
        public override string Køretøj()
        {
            return "MC";
        }
    }
}
