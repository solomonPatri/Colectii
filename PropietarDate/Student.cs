using Colectii.Vehicule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Colectii.PropietarDate
{
    public class Student  :Persoana,IComparable<Student>
    {
        
        private string _name;
        private string _email;
        private string _phone;
        private int _age;
        private static int _genId;


        public Student(int id,string type,string name, string email,string phone,int age) : base(id, "Student")
        {
            _name = name;
            _email = email;
            _phone = phone; 
            _age = age; 

        }
        public Student()
        {

        }

     
        public string Name { 
            get { return _name; }
            set { _name = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }



        public class StudentBuilder
        {
            private readonly Student _student;

           private StudentBuilder(Student student)
            {
                _student = student;
            }   

            public static StudentBuilder Create()
            {

                return new StudentBuilder(new Student());

            }
            public StudentBuilder Id()
            {

                (_student as Persoana).Id = _genId;
                _genId++;
                return this;
            }
            public StudentBuilder Name(string name)
            {
                _student._name = name;
                return this;
            }

            public StudentBuilder Email(string email)
            {
                _student._email = email; 
                return this;


            }

            public StudentBuilder Phone(string phone)
            {
                _student._phone = phone;
                return this;
            }

            public StudentBuilder Age(int age)
            {
                _student._age = age;
                return this;


            }



            public Student Build()
            {
                return _student;
            }



        }


        public int CompareTo(Student other)
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
            
            if((other as Persoana).Type.Equals("Student")){


                return (other as Persoana).Type;


            }

            return null;




        }


        public override bool Equals(object? student)
        {
            return student is Student other && Id.Equals(other.Id);

        }


        public override string ToString()
        {
            string t = " "+base.ToString();
                t+="Name: "+ Name +"\n "+"Email: " + Email + "\n" + "Phone:" + Phone + "\n" + "Age: " + Age + "\n";
            return t;
        }


        ///Pentru hashcode ne returneaza id

        public override int GetHashCode()
        {
            return Id.GetHashCode(); 
        }




    }
}
