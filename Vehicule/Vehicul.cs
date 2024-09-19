using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Vehicule
{
    public class Vehicul : IComparable<Vehicul>
    {

        private int _id;
        private string _type;
        private int order;
       public Vehicul (int id, string type)
        {
            _id = id;
            _type = type;


        }
        public Vehicul()
        {

        }
        public int Order
        {
            get { return order; }
            set { order = value; }
        }

        public int Id { 
            get { return _id; } 
            set { _id = value; }
        }
        public string Type { 
            get { return _type; } 
            set { _type = value; } 
        }


        public int CompareTo(Vehicul veh)
        {
            if (_id > veh._id)
            {
                return 1;
            }

            if (_id <veh._id)
            {
                return -1;

            }

            return 0;

        }

        public Vehicul CompareToByType(Vehicul veh)
        {
            if (_type.Equals("Masina"))
            {
                return veh;
            }

            if (_type.Equals("Autobus"))
            {
                return veh;
            }

            return null;

        }

        public virtual string ToString()
        {
            string t = " ";
            t += "Type:" + Type + "\n";
            return t;
        }









    }
}
