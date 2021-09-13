using System;

namespace DMWM_2TestExercicesCours
{
    class Person
    {
        public string FirstName { get; set; }
        //private string FirstName;
        //public string firstname
        //{
        //    get { return firstname; }
        //    set { firstname = value; }
        //}
        public string LastName { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = null;
            //if (person != null)
            //{
            //    Console.WriteLine(person.FirstName);
            //}
            //Console.WriteLine(person?.FirstName ?? "User introuvable");
            //Console.WriteLine(person?.FirstName);
            //Tester la longueur d'une chaine avec l'operateur de condition if
            //string _StringData = "Hello";
            //if (_StringData.Length > 0)
            //    Console.WriteLine("Longueur de la chaine positive");
            //else
            //    Console.WriteLine("La chaine est nulle");
            ////Console.WriteLine("Hello World!");
            ////Tester la longeur en utilisant conditionalOperator ?:
            //Console.WriteLine(_StringData.Length > 0 ? "Chaine positive"
            //    : "Chaine nulle");
           // int[] array = { 1, 2, 6, 10 };
           //// System.Collections.IEnumerable
           // foreach (var item in array)
           // {
           //     Console.WriteLine(item);
           // }
            //Test Ref & Out keywords
            static void TestFonction(out int RefInVariable)
            {
                RefInVariable = 0;
                RefInVariable = RefInVariable + 10;
            }
            int RefVariable = 20;
            TestFonction(out RefVariable);
            Console.WriteLine(RefVariable);
        }
    }
}
