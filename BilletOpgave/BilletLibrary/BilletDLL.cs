using System;

namespace BilletLibrary
{
    /// <summary>
    ///Abstrakt klasse for klasserne BilClass og MCClass
    /// </summary>
    public abstract class BilletDLL
    {
        private string _nummerplade;
        private DateTime _dato;
        private bool _rabatKort;

        /// <summary>
        /// Sætter sandt eller falsk på om bilen har BroBizz
        /// </summary>
        public bool RabatKort
        {
            get { return _rabatKort; }
            set
            {
                _rabatKort = false;
                if (true)
                {
                    _rabatKort = value;
                }
            }
        }

        /// <summary>
        /// Sætter dato på bilen
        /// </summary>
        public DateTime Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }
        /// <summary>
        /// Sætter en nummerplade på bilen.
        /// </summary>
        public string Nummerplade
        {
            get { return _nummerplade; }
            set
            {
                if (Nummerplade.Length <= 7) { _nummerplade = value; }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        /// <summary>
        /// Returnerer prisen i decimal type.
        /// </summary>
        /// <returns></returns>
        public abstract decimal Pris();

        /// <summary>
        /// Returnerer køretøjet i string type.
        /// </summary>
        /// <returns></returns>
        public abstract string Køretøj();
    }
}
