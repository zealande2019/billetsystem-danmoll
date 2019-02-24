using System;

namespace Bil
{
    public class BilletDLL
    {
        class BilContent
        {
            private string _nummerplade;
            private DateTime _dato;

            public DateTime Dato
            {
                get { return _dato; }
                set { _dato = value; }
            }

            public string Nummerplade
            {
                get { return _nummerplade; }
                set { _nummerplade = value; }
            }

            public decimal Pris()
            {
                return 240;
            }

            public string Køretøj()
            {
                return "Bil";
            }

        }
    }
}
