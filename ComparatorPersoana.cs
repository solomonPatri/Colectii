using Colectii.PropietarDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii
{
    public  class ComparatorPersoana:  IComparer<Persoana>
    {

        public int Comparer(Persoana? x, Persoana? y)
        {
            if(x.Id > y.Id)
            {
                return 1;
            }
            if(x.Id < y.Id)
            {
                return -1;

            }

            return 0;



        }





    }
}
