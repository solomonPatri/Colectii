using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Colectii.Vehicule;

namespace Colectii.Colectii
{
    public class Exemple
    {
     

        public void  TeorieListe()
        {
            List<Vehicul> veh = new List<Vehicul>();

            Masina masina = Masina.MasinaBuilder

            .Create()
            .Id()
            .Model("Dacia")
            .AnFabrica(2019)
            .NameProp("Marius")
            .Cost(201232)
            .Build();
            Masina masina2 = Masina.MasinaBuilder

         .Create()
         .Id()
         .Model("Ford")
         .AnFabrica(2009)
         .NameProp("Andreea")
         .Cost(201829)
         .Build();

            Autobus bus = Autobus.AutobusBuilder
                .Create()
                .Id()
                .Firma("Tursib")
                .NrPasajeri(232)
                .NameSofer("Darius")
                .Build();

            Autobus bus2 = Autobus.AutobusBuilder
               .Create()
               .Id()
               .Firma("Tursib")
               .NrPasajeri(121)
               .NameSofer("Daniel")
               .Build();


            // Adaugarea 
            veh.Add(masina);
            veh.Add(masina2);
            veh.Add(bus2);
            veh.Add(bus);



            //Afisare

           for(int j = 0; j < veh.Count; j++)
            {
                Console.WriteLine(veh[j].ToString());

            }

            // Insert

           Masina mas3 = Masina.MasinaBuilder
           .Create()
           .Id()
           .Model("Seat")
           .AnFabrica(2013)
           .NameProp("Sonia")
           .Cost(232910)
           .Build();


            veh.Insert(2, mas3);

            Console.WriteLine("Dupa inserare"+"\n");

            for(int j = 0; j < veh.Count; j++)
            {
                Console.WriteLine(veh[j].ToString());

            }


            //Remove // Stergere

            veh.Remove(bus);

            Console.WriteLine("Dupa remove"+"\n");


            for (int j = 0; j < veh.Count; j++)
            {
                Console.WriteLine(veh[j].ToString());

            }


            //RemoveAt  // Stergere dupa index

            veh.RemoveAt(1);
            Console.WriteLine("Dupa remove at" + "\n");
            for (int j = 0; j < veh.Count; j++)
            {
                Console.WriteLine(veh[j].ToString());

            }


            //Contains // Verifica daca exista in lista dupa obiect
            Console.WriteLine("Dupa Contains" + "\n");

            veh.Contains(masina);


            Masina masina4 = Masina.MasinaBuilder
           .Create()
           .Id()
           .Model("Dacia")
           .AnFabrica(2019)
           .NameProp("Rebeca")
           .Cost(1827319)
           .Build();

            Console.WriteLine(  "test includes");

            Console.WriteLine(veh.Contains(masina4));


            Console.WriteLine(veh.Contains(bus)); // Nu ne apara deoarece am folosit remove si sa sters din lista 


            Masina masina5= Masina.MasinaBuilder
          .Create()
          .Id()
          .Model("Dacia")
          .AnFabrica(2019)
          .NameProp("Rebeca")
          .Cost(1827319)
          .Build();

            Console.WriteLine(masina5.Id); //Deja exista masina 4 si se genreaza automat 5 ca id




        }


        public void StackAndQueueExemplu()
        {
            //LIFO last in first out

            Stack<Vehicul> s = new Stack<Vehicul>();

            Masina mas7 = Masina.MasinaBuilder

            .Create()
            .Id()
            .Model("Renault")
            .AnFabrica(2017)
            .NameProp("Adrian")
            .Cost(1291382)
            .Build();


            Masina mas8 = Masina.MasinaBuilder

            .Create()
            .Id()
            .Model("Seat")
            .AnFabrica(2012)
            .NameProp("Adreea")
            .Cost(19283)
            .Build();

            Autobus bus6 = Autobus.AutobusBuilder
               .Create()
               .Id()
               .Firma("BrasovTur")
               .NrPasajeri(121)
               .NameSofer("Elena")
               .Build();

            Autobus bus8 = Autobus.AutobusBuilder
               .Create()
               .Id()
               .Firma("Bucuresti Bus")
               .NrPasajeri(12)
               .NameSofer("Andrei")
               .Build();

            //creare stiva LIFO   

            s.Push(mas7);// first in
            s.Push(mas8);
            s.Push(bus6);
            s.Push(bus8);  //last in

           // Console.WriteLine(s.Count);

            //Console.WriteLine("Dupa stergere a ramas nr de elemente: ");
            s.Pop();  // firstout   sa sters bus8

           // Console.WriteLine(s.Count);


        //   Console.WriteLine(s.Peek()); // Imi afiseaza ultimul din stiva (Brasov)
            

            
            //Queue  FIFO   (First in First Out)  
            //   stack 4321 321
            //   queue 1234 234
   

            Queue <Vehicul> coada = new Queue<Vehicul> ();

             Masina masina5 = Masina.MasinaBuilder
          .Create()
          .Id()
          .Model("Dacia")
          .AnFabrica(2019)
          .NameProp("Rebeca")
          .Cost(1827319)
          .Build();


            Masina masina6 = Masina.MasinaBuilder
        .Create()
        .Id()
        .Model("Ford")
        .AnFabrica(2003)
        .NameProp("Andreea")
        .Cost(1827319)
        .Build();

            Autobus bus = Autobus.AutobusBuilder
                .Create()
                .Id()
                .Firma("Tursib")
                .NrPasajeri(232)
                .NameSofer("Darius")
                .Build();

            Autobus bus2 = Autobus.AutobusBuilder
               .Create()
               .Id()
               .Firma("Tursib")
               .NrPasajeri(121)
               .NameSofer("Daniel")
               .Build();


            coada.Enqueue(masina5);
            coada.Enqueue (masina6);
            coada.Enqueue(bus);
            coada.Enqueue(bus2);

            foreach(var item in coada)       //Nu se poate folosi pentru modifcare doar parcurgere 
            {
                Console.WriteLine(item.ToString());
            }
             Console.WriteLine("Afisarea primului item din coada"+"\n");
            Console.WriteLine(coada.Peek());   //Fiind coada acuma imi afiseaza prima din coada  fata de stiva care era ultimul 


            Console.WriteLine("Dupa stergerea primul din coada"+"\n");
            coada.Dequeue();

            foreach(var item in coada)
            {
                Console.WriteLine(item.ToString());
            }



            Console.WriteLine( coada.Count()); // Afiseaza 3 deoarece am sters inainte primul vehicul


            int ct = 0;

            //1234
            foreach(var item in coada)
            {
                if(ct==2)
                {
                    Console.WriteLine(item.ToString());
                }
                ct++;
               
            }




        }


        public  static void SetExemp()
        {

            HashSet<Vehicul> hash = new HashSet<Vehicul>();

            Masina mas1 = Masina.MasinaBuilder
          .Create()
          .Id()
          .Model("Dacia")
          .AnFabrica(2019)
          .NameProp("Rebeca")
          .Cost(1827319)
          .Build();

            Masina mas2 = Masina.MasinaBuilder
           .Create()
           .Id()
           .Model("Seat")
           .AnFabrica(2013)
           .NameProp("Sonia")
           .Cost(232910)
           .Build();

            Autobus bus = Autobus.AutobusBuilder
             .Create()
             .Id()
             .Firma("Tursib")
             .NrPasajeri(232)
             .NameSofer("Darius")
             .Build();

            Autobus bus2 = Autobus.AutobusBuilder
               .Create()
               .Id()
               .Firma("Tursib")
               .NrPasajeri(121)
               .NameSofer("Daniel")
               .Build();

            
            hash.Add(mas1);
            hash.Add(mas2);
            hash.Add(bus);
            hash.Add(bus2);

            Console.WriteLine("Toate Vehiculele adaugate la inceput"+"\n");

            foreach (var item in hash)
            {
                Console.WriteLine(item.ToString());

            }

            Console.WriteLine("Dupa stergerea primului autobus" + "\n");

            bus.Id = 1111;
            hash.Remove(bus);

           

            foreach (var item in hash)
            {
                Console.WriteLine(item.ToString());

            }


            Console.WriteLine("Exista Masina 1?");

           Console.WriteLine( hash.Contains(mas1));

            ///// hash.Clear();  // Sterge toate elementele 
            

            Masina create = Masina.MasinaBuilder
                .Create()
               .Model("Ford")
           .AnFabrica(2014)
           .NameProp("alex")
           .Cost(232910)
           .Build();

            create.Id = 1;


            Console.WriteLine("Inainte de adaugare ================");

            foreach (var item in hash)
            {
                Console.WriteLine(item.ToString());

            }

            hash.Add(create);

         




            Console.WriteLine("Dupa Adaugare ===================");

            

            foreach (var item in hash)
            {
                Console.WriteLine(item.ToString());
            }



            Console.WriteLine("///////////////////Sorted////////////////////////////////");



            SortedSet<Vehicul> sortedset = new SortedSet<Vehicul>(new ComparatorMasina());



            Masina mas10 = Masina.MasinaBuilder
          .Create()
          .Id()
          .Model("Renault")
          .AnFabrica(2013)
          .NameProp("Rebeca")
          .Cost(3938219)
          .Build();

            Masina mas11 = Masina.MasinaBuilder
           .Create()
           .Id()
           .Model("Ford")
           .AnFabrica(2018)
           .NameProp("Sofia")
           .Cost(183623)
           .Build();

            Autobus bus10 = Autobus.AutobusBuilder
             .Create()
             .Id()
             .Firma("Brasov srlTour")
             .NrPasajeri(2341)
             .NameSofer("Marius")
             .Build();

            Autobus bus12 = Autobus.AutobusBuilder
               .Create()
               .Id()
               .Firma("Tursib")
               .NrPasajeri(98)
               .NameSofer("Andrei")
               .Build();

            //adaugam in lista

            Console.WriteLine("Toate elementele recent adaugate in colectie: " + "\n");
            sortedset.Add(mas10);
            sortedset.Add(mas11);
            sortedset.Add(bus10);
            sortedset.Add(bus12);

            foreach (var item in sortedset)
            {
                Console.WriteLine(item.ToString());
            }


            //Remove 
            Console.WriteLine("Dupa stergerea autobuzului bus12(Brasov SrlTour) : " + "\n");
            sortedset.Remove(bus10);
            foreach (var item in sortedset)
            {
                Console.WriteLine(item.ToString());
            }

         

            // Min element
            Console.WriteLine("Elementul cel mai mic din colectie: "+"\n");
            Console.WriteLine(sortedset.Min().ToString());


            //Max Element
            Console.WriteLine("Elementul cel mai mare din colectie: " + "\n");
            Console.WriteLine(sortedset.Max().ToString());

            //Contains...

            Console.WriteLine("Exista masina nr 10  : " + "\n");

            Console.WriteLine(sortedset.Contains(bus10)); ////false deoarece lam sters anterior

            //Compare By Type
            Console.WriteLine("Exista acest autobus : " + "\n");

            Console.WriteLine(sortedset.Contains(mas10));

            Console.WriteLine("Exista aceasta masina doar in hash : " + "\n");
            Console.WriteLine(sortedset.Contains(mas1));






        }


















    }
}
