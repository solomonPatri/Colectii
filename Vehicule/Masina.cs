using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Colectii.Vehicule
{
    public class Masina : IVehicul, IComparable<Masina>
    {
        private int _id;
        private string _model;
        private int _anFabrica;
        private string _prop;
        private int _cost;
        private static int genId = 1;


        public Masina()
        {


        }

        public int Id
        {
            get { return _id; }
            set
            {
                _id = value;
            }

        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
        public int AnFabrica
        {
            get { return _anFabrica; }
            set { _anFabrica = value; }
        }

        public string Prop
        {
            get { return _prop; }
            set { _prop = value; }
        }

        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }

        public class MasinaBuilder
        {
            private readonly Masina _masina;

            private MasinaBuilder(Masina masina)
            {
                _masina = masina;
            }

            public static MasinaBuilder Create()
            {

                return new MasinaBuilder(new Masina());

            }
            public MasinaBuilder Id()
            {
                _masina._id = genId;
                genId++;
                return this;
            }
            public MasinaBuilder Model(string model)
            {
                _masina._model = model;
                return this;
            }

            public MasinaBuilder AnFabrica(int anFabrica)
            {
                _masina._anFabrica = anFabrica;
                return this;


            }

            public MasinaBuilder NameProp(string prop)
            {
                _masina._prop = prop;
                return this;
            }

            public MasinaBuilder Cost(int cost)
            {
                _masina._cost = cost;
                return this;


            }



            public Masina Build()
            {
                return _masina;
            }



        }


        public int CompareTo(Masina other)
        {
            if (_cost > other._cost)
            {
                return 1;
            }

            if (_cost < other._cost)
            {
                return -1;

            }

            return 0;

        }

        public override bool Equals(object? masina)
        {
            return masina is Masina other && Id.Equals(other.Id);

        }


        public override string ToString()
        {
            string t = "Model: " + Model + "\n" + "An fabricatie: " + AnFabrica + "\n" + "Propietar:" + Prop + "\n" + "Pretul: " + Cost + "\n";
            return t;
        }


        public Masina Add(Masina newcar)
        {
            Console.WriteLine("Model: ");
            string newmodel = Console.ReadLine();
            Console.WriteLine("An fabrica: ");
            int newyear = int.Parse(Console.ReadLine());
            Console.WriteLine("Propietar: ");
            string prop = Console.ReadLine();
            Console.WriteLine("Pretul: ");
            int newcost = int.Parse(Console.ReadLine());

            Masina car = MasinaBuilder
                .Create()
                .Model(newmodel)
                .AnFabrica(newyear)
                .NameProp(prop)
                .Cost(newcost)
                .Build();


            newcar = car;
            return newcar;
        }























    }
}
