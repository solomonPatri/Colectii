using Colectii.Vehicule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.PropietarDate
{
    public  class Profesor : IPersoana,IComparable<Profesor>
    {
        private int _id;
        private string _name;
        private int _age;
        private string _veh;
        private static int _genId;

        public Profesor()
        {

        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Veh
        {
            get { return _veh; }
            set { _veh = value; }
        }



        public class ProfesorBuilder
        {
            private readonly Profesor _profe;

            private ProfesorBuilder(Profesor profesor)
            {
                _profe = profesor;
            }

            public static ProfesorBuilder Create()
            {

                return new ProfesorBuilder(new Profesor());

            }
            public ProfesorBuilder Id()
            {
                _profe._id = _genId ;
                _genId++;
                return this;
            }
            public ProfesorBuilder Name(string name)
            {
                _profe._name = name;
                return this;
            }

            public ProfesorBuilder Age(int age)
            {
                _profe._age = age;
                return this;


            }

            public ProfesorBuilder Vehicul(string veh)
            {
                _profe._veh = veh;
                return this;
            }


            public Profesor Build()
            {
                return _profe;
            }



        }


        public int CompareTo(Profesor other)
        {
            if (_age > other._age)
            {
                return 1;
            }

            if (_age < other._age)
            {
                return -1;

            }

            return 0;

        }

        public override bool Equals(object? profe)
        {
            return profe is Profesor other && Id.Equals(other.Id);

        }


        public override string ToString()
        {
            string t = "Name: " + Name + "\n" + "Age: " + Age + "\n" + "Vehicul:" + Veh + "\n";
            return t;
        }





    }
}
