using Colectii.Vehicule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii
{
    public class ComparatorMasina : IComparer<Vehicul>
    {
        public  int Compare(Vehicul? x, Vehicul? y)
        {
             if (x.Id > y.Id)
            {
                return 1;
            }
             if (x.Id < y.Id)
            {
                return -1;
            }
            return 0;

        }
    }
}
