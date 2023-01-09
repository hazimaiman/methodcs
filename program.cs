using System.Runtime.CompilerServices;

namespace MyFirstProgram
    {
        class Program
        {
        static void Main(string[] args)
        {
            //method = performs a section of code. its called invoked
            // benefit lets us reuse code w/o writing it multiple times.


            String name = "Aiman";
            int age = 24;

            singHappyBirthday(name, age);
            

            Console.ReadKey();
        }
          static void singHappyBirthday(String name, int age)
         //static void singHappyBirthday(String birthdayBOY, int yearsOld) 
         //parameter dok perlu nama sme dgn arguments atas pun boleh tukor
         //tukar yg name and age bowoh je
        {
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine("Happy Birthday dear you!" + name);
            Console.WriteLine("you are " + age + "years old");
            Console.WriteLine("Happy Birthday to you!");
            Console.WriteLine();
        }
        }
    }





   
