using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eenmalige_uitkering
{
    class Program
    {
        static void Main(string[] args)
        {
            //parameters
            string name;
            string marriedd;

            DateTime currentDate = DateTime.Now;
            DateTime birthDate;

            bool married;

            double salary;
            double boundary;
            double payment;

            //data
            Console.WriteLine("Please enter your name: ");
            name = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.WriteLine("What is your birthdate?");
                    birthDate = Convert.ToDateTime(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: please try again."); }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Are you married? Yes or no");
                    string a = Console.ReadLine();
                    if (a == "yes" || a == "Yes" || a == "YES")
                    {
                        married = true;
                        marriedd = "married";
                        break;
                    }
                    else if (a == "no" || a == "No" || a == "NO")
                    {
                        married = false;
                        marriedd = "not married";
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Invalid: please try again.");
                    }
                }
                catch (Exception) { Console.WriteLine("Invalid: please try again."); }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("What was your salary last year?");
                    salary = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (Exception) { Console.WriteLine("Invalid: please try again."); }
            }

            //math
            double AgeY = currentDate.Year - birthDate.Year;
            double AgeM = currentDate.Month - birthDate.Month;
            double AgeD = currentDate.Day - birthDate.Day;

            if (AgeM > 0 || (AgeM == 0 && AgeD > 0)) { }
            else { AgeY -= 1; }

            if (AgeY < 21 && married == false) { boundary = 1300; }
            else { boundary = 1425; }

            if (boundary >= salary / 12) { payment = salary / 100 * 1.75; }
            else { payment = 0; }

            if (payment < 250) { payment = 250; }

            //conclusion
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine("The current date is: " + currentDate);
            Console.WriteLine("Your birth date is: " + birthDate);
            Console.WriteLine("Your age is: " + AgeY);
            Console.WriteLine("Your marriage status: " + marriedd);
            Console.WriteLine("Your salary last year was: " + salary);
            Console.WriteLine("Your payment: " + payment);
        }
    }
    // grens van werknemers, beneden grens ontvangt uitkering
    // ongehuwd, jonger dan 21 jaar, bedraagd 1300 euro. De rest 1425 euro
    // uitkering 1,75% van totale salaris van afgelopen jaar
    // minimum 250 euro
}
