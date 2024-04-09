using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Static__Interface_2.Interface;

namespace Static__Interface_2.Models
{
    internal class Student : ICodeAcademy
    {

        /*public int _id;
        public string _name;
        public string _surname;
        static int count = 1;*/


        public static int Count { get; set; } = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CodeEmail { get; set; }

        
        public Student(string name,string surname)
        {
            Name = name;
            Surname = surname;
            Id = Count++;
            GenerateEmail();
        }

        private void GenerateEmail()
        {
            throw new NotImplementedException();
        }



        /* public static bool CheckName(string name)
         {
             for (int i = 0; i < name.Length; i++)
             {
                 if ()
                 {
                     return true;
                 }
             }
             return false;
         }*/


        private void GenerateEmail(string Email)
        {

            Email = $"{Name.ToLower()}.{Surname.ToLower()}{Id}@code.edu.az";

            CodeEmail=Email;
        }

        void ICodeAcademy.GenerateEmail()
        {
            throw new NotImplementedException();
        }
    }
}
