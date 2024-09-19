using Colectii.PropietarDate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colectii.Colectii
{
    public class Exemplul2
    {

        public static void RecapitulareTeorie()
        {
            List<Persoana> pers = new List<Persoana>();


            Student s1 = Student.StudentBuilder
            .Create()
            .Id()
            .Name("Adrian")
            .Email("adria23@gmail.com")
            .Phone("29310937892")
            .Age(28)
            .Build();


            Student s2 = Student.StudentBuilder
            .Create()
            .Id()
            .Name("Pablo")
            .Email("Pablo12.Ad@gmail.com")
            .Phone("29387166163")
            .Age(12)
            .Build();

            Student s3 = Student.StudentBuilder
            .Create()
            .Id()
            .Name("Ines")
            .Email("Ines13.maria@gmail.com")
            .Phone("2032849134")
            .Age(30)
            .Build();

            Student s4 = Student.StudentBuilder
            .Create()
            .Id()
            .Name("ADreea")
            .Email("adree121@gmail.com")
            .Phone("284293472")
            .Age(11)
            .Build();


            Profesor p1 = Profesor.ProfesorBuilder
                .Create()
                .Id()
                .Name("Marin")
                .Age(43)
                .Vehicul("Dacia")
                .Build();


            Profesor p2 = Profesor.ProfesorBuilder
                .Create()
                .Id()
                .Name("Fernand")
                .Age(32)
                .Vehicul("Ford")
                .Build();


            Profesor p3 = Profesor.ProfesorBuilder
                .Create()
                .Id()
                .Name("Maria")
                .Age(63)
                .Vehicul("Mercedes")
                .Build();



            pers.Add(s1);
            pers.Add(s2);
            pers.Add(s3);
            pers.Add(s4);
            pers.Add(p1);
            pers.Add(p2);
            pers.Add(p3);


            pers.Remove(s4);


            pers.Contains(s1);





        }


        public static void StivaAndCoada()
        {

            Stack<Persoana> stiva = new Stack<Persoana>();

            Student s1 = Student.StudentBuilder
           .Create()
           .Id()
           .Name("Adrian")
           .Email("adria23@gmail.com")
           .Phone("29310937892")
           .Age(28)
           .Build();

            Profesor p3 = Profesor.ProfesorBuilder
               .Create()
               .Id()
               .Name("Maria")
               .Age(63)
               .Vehicul("Mercedes")
               .Build();


            Student s2 = Student.StudentBuilder
            .Create()
            .Id()
            .Name("Pablo")
            .Email("Pablo12.Ad@gmail.com")
            .Phone("29387166163")
            .Age(12)
            .Build();


           stiva.Push(s1);
           stiva.Push(s2);
           stiva.Push(p3);

            stiva.Pop();


           // Console.WriteLine(stiva.Peek());


            Queue<Persoana> coada2 = new Queue<Persoana>();

            Student s3 = Student.StudentBuilder
                .Create()
                .Id()
                .Name("Mario")
                .Age(17)
                .Email("Mario_adrian261@gamil.com")
                .Phone("815331949")
                .Build();


            Profesor p4 = Profesor.ProfesorBuilder
                .Create()
                .Id()
                .Name("Teodor")
                .Age(18) 
                .Vehicul("Mercedes")
                .Build();


            coada2 .Enqueue(s3);
            coada2.Enqueue(s2 );///////////s3,s2,p3,s1,p4
            coada2.Enqueue(p3 );
            coada2.Enqueue(s1);
            coada2.Enqueue(p4);

            Console.WriteLine("Dupa adaugarea toate Elementelor");

            foreach(var itemms in coada2)
            {

                Console.WriteLine(itemms);


            }

            Console.WriteLine("Dupa eliminarea unui obiect: ");


            coada2.Dequeue(); /// s2,p3,s1,p4
            foreach (var itemms in coada2)
            {

                Console.WriteLine(itemms);


            }

            Console.WriteLine( coada2.Contains(p4));   //Daca exista imi afiseaza True


            Console.WriteLine(coada2.Peek());   //Imi afiseaza primul element din lista








        }



        public static void ReacapitulareSet()
        {


            HashSet <Persoana> hashrecap = new HashSet <Persoana>();

            Student s8 = Student.StudentBuilder
                .Create()
                .Id()
                .Name("Andres")
                .Age(18)
                .Email("Andres23@gmail.com")
                .Phone("02836166372")
                .Build();

            Student s9 = Student.StudentBuilder
               .Create()
               .Id()
               .Name("Maria")
               .Age(15)
               .Email("Maria_ana321@gmail.com")
               .Phone("9275162736")
               .Build();
            Student s10 = Student.StudentBuilder
               .Create()
               .Id()
               .Name("Matias")
               .Age(36)
               .Email("matias_mateo12@gmail.com")
               .Phone("0019837122231")
               .Build();

            Profesor p8 = Profesor.ProfesorBuilder
                .Create()
                .Id()
                .Name("Fernando")
                .Vehicul("Dacia Sandero")
                .Age(45)
                .Build();

            Profesor p9 = Profesor.ProfesorBuilder
               .Create()
               .Id()
               .Name("Sandra")
               .Vehicul("Renault Vegane")
               .Age(23)
               .Build();

            Profesor p10 = Profesor.ProfesorBuilder
               .Create()
               .Id()
               .Name("Marcos")
               .Vehicul("Ford Puma")
               .Age(35)
               .Build();


            Console.WriteLine("Persoanele" + "\n");

            hashrecap.Add(s8);
            hashrecap.Add(s9);
            hashrecap.Add(s10);
            hashrecap.Add(p8);
            hashrecap.Add(p9);
            hashrecap.Add(p10);

            foreach (var item in hashrecap)
            {
                Console.WriteLine(item.ToString());

            }


            Console.WriteLine("Stergem pe studenta Maria: " + "\n");

            hashrecap.Remove(s9);

            foreach(var item in hashrecap)
            {
                Console.WriteLine(item.ToString());

            }

            Console.WriteLine("Exista profesorul nr 10" + "\n");

            Console.WriteLine(hashrecap.Contains(p10));


            SortedSet<Persoana> sortedrecap = new SortedSet<Persoana>();


            Student s11 = Student.StudentBuilder
               .Create()
               .Id()
               .Name("Andres")
               .Age(18)
               .Email("Andres23@gmail.com")
               .Phone("02836166372")
               .Build();

            Student s12 = Student.StudentBuilder
               .Create()
               .Id()
               .Name("Maria")
               .Age(15)
               .Email("Maria_ana321@gmail.com")
               .Phone("9275162736")
               .Build();
            Student s13 = Student.StudentBuilder
               .Create()
               .Id()
               .Name("Matias")
               .Age(36)
               .Email("matias_mateo12@gmail.com")
               .Phone("0019837122231")
               .Build();

            Profesor p11 = Profesor.ProfesorBuilder
                .Create()
                .Id()
                .Name("Fernando")
                .Vehicul("Dacia Sandero")
                .Age(45)
                .Build();

            Profesor p12 = Profesor.ProfesorBuilder
               .Create()
               .Id()
               .Name("Sandra")
               .Vehicul("Renault Vegane")
               .Age(23)
               .Build();

            Profesor p13 = Profesor.ProfesorBuilder
               .Create()
               .Id()
               .Name("Marcos")
               .Vehicul("Ford Puma")
               .Age(35)
               .Build();

            Console.WriteLine("Persoanele respective sunt :");
            sortedrecap.Add(s12);
            sortedrecap.Add(s13);
            sortedrecap.Add(s11);
            sortedrecap.Add(p12);
            sortedrecap.Add(p11);
            sortedrecap.Add(p13);


            foreach(var item  in sortedrecap)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Dupa stergerea profesorului Sandra");

            sortedrecap.Remove(p12);


            foreach (var item in sortedrecap)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("Exista studentul Matias ");

            Console.WriteLine(sortedrecap.Contains(s13));

















        }









    }
}
