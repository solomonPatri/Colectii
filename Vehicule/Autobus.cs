using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Vehicule
{
    public class Autobus : IVehicul, IComparable<Autobus>
    {
        private int _id;
        private string _firma;
        private int _nrPasanjeri;
        private string _soferName;
        private static int _generateId = 30;

        public Autobus()
        {

        }

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Firma
        {
            get { return _firma; }
            set { _firma = value; }
        }
        public int NrPasaj
        {
            get { return _nrPasanjeri; }
            set { _nrPasanjeri = value; }
        }
        public string SoferName
        {
            get { return _soferName; }
            set { _soferName = value; }
        }

        public class AutobusBuilder
        {
            private readonly Autobus _autobus;

            private AutobusBuilder(Autobus bus)
            {
                _autobus = bus;
            }

            public static AutobusBuilder Create()
            {
                return new AutobusBuilder(new Autobus());

            }
            public AutobusBuilder Id()
            {
                _autobus._id = _generateId;
                _generateId++;
                return this;

            }
            public AutobusBuilder Firma(string firma)
            {
                _autobus.Firma = firma;
                return this;

            }

            public AutobusBuilder NrPasajeri(int pasaj)
            {

                _autobus.NrPasaj = pasaj;
                return this;





            }

            public AutobusBuilder NameSofer(string name)
            {
                _autobus.SoferName = name;
                return this;


            }

            public Autobus Build()
            {
                return _autobus;
            }




        }

        public int CompareTo(Autobus other)
        {
            if (_nrPasanjeri > other._nrPasanjeri)
            {
                return 1;
            }

            if (_nrPasanjeri < other._nrPasanjeri)
            {
                return -1;

            }

            return 0;
        }

        public override bool Equals(object? bus)
        {
            return bus is Autobus other && Id.Equals(other.Id);

        }


        public override string ToString()
        {
            string t = " ";
            t += "Firma: " + Firma + "\n" + "Nr Pasajeri: " + NrPasaj + "\n" + "Name Sofer: " + SoferName + "\n";
            return t;
        }

        public override int GetHashCode()
        {
            return   Id.GetHashCode();
        }























    }
}
