using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golebnik 
{
    [Serializable]
    public class Golab : IComparable
    {
        public Image zdjecie;
        public string nrObraczki;
        public string barwa;
        public string plec;
        public string rodzajGolebia;

        public int CompareTo(object obj)
        {
            if (obj == null)
                return 1;

            Golab innyGolab = (Golab)obj;

            if (innyGolab.nrObraczki != null)
                return nrObraczki.CompareTo(innyGolab.nrObraczki);
            else
                throw new ArgumentException("Objekt nie jest typu <Golab>.");
        }
    }
}
