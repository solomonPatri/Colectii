using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.PropietarDate
{
    public class  Persoana: IComparable<Persoana>
    {
        private int _id;
        private string _type;

        public Persoana(int id, string type) {
            
            _id = id;
            _type = type;
        }

        public Persoana()
        {

        }

        public string Type
        {
            get { return _type; }
            set { _type = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }


        public int CompareTo(Persoana other)
        {
            if(_id< (other.Id))
            {

                return 1;

            }
            if (_id > (other._id))
            {
                return -1;


            }

            return 0;





        }


        public string CompareToType(Persoana other)
        {
            if (_type.Equals(other._type))
            {
                return other._type;


            }
            return null;
        }


        public virtual string ToString()
        {
            string t = " ";
            t += "Id: " + Id+"\n";
            t += "Type: " + Type + "\n";
            return t;


        }
















    }
}
