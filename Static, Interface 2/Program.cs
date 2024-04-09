using Static__Interface_2.Models;

namespace Static__Interface_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student("Nurlan","Abbasov");

            Console.WriteLine(student.CodeEmail);

        }
    }
}
