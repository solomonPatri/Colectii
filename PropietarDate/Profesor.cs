using Colectii.Vehicule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.PropietarDate
{
    public  class Profesor : Persoana,IComparable<Profesor>
    {
        
        private string _name;
        private int _age;
        private string _veh;
        private static int _genId;

        public Profesor(int id, string type, string name, int age, string veh):base(id,"Profesor")
        {
            _name=  name;
            _age= age;
            _veh= veh;



        }

        public Profesor()
        {

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
                ( _profe as Persoana).Id = _genId ;
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
        public string CompareToType(Student other)
        {

            if ((other as Persoana).Type.Equals("Profesor"))
            {


                return (other as Persoana).Type;


            }

            return null;




        }
        public override bool Equals(object? profe)
        {
            return profe is Profesor other && Id.Equals(other.Id);

        }


        public override string ToString()
        {
            string t = " " + base.ToString();
            t+= "Name: " + Name + "\n" + "Age: " + Age + "\n" + "Vehicul:" + Veh + "\n";

            return t;
        }


        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }









    }
}
