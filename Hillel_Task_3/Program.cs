using Hillel_Task_3.Classes;
using Hillel_Task_3.Enums;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Hillel_Task_3
{
    internal class Program
    {
        
        
        
        
        static void Main(string[] args)
        {
            int checAge = 0;            
            int age = 0;
            GetUserAge();               

            User newUs = new User(checAge);
          
            GetUserName();

            GetLastName();            

            ChoiseGender(newUs);
            var getInf = newUs.ToString();
            Console.WriteLine(getInf);

        
            void GetUserName()
        {
            Console.Write("Enter your Name: ");
            string firstName = Console.ReadLine();

            if (IsCorrectNameSurname(firstName))
            {
                newUs.FirstName = firstName;
            }
            else
            {
                Console.WriteLine("Error! Please enter only symbols(A-Z): ");
                GetUserName();
            }
            
        }

            void GetLastName()
            {
                Console.Write("Enter your LastName: ");
                string lastName = Console.ReadLine();

                if (IsCorrectNameSurname(lastName))
                {
                    newUs.LastName = lastName;
                }
                else
                {
                    Console.WriteLine("Error! Please enter only symbols(A-Z): ");
                    GetLastName();
                }
               
            }


            bool IsCorrectNameSurname(string inputStr)
        {
            var pattern = new Regex("[A-Za-z]+");
            return pattern.IsMatch(inputStr);

        }

            void ChoiseGender(User newUs)
        {
             Console.WriteLine("Choose your gender, press 1 if you male or 2 if you female: ");
             int gender = Convert.ToInt32(Console.ReadLine());

                if (gender == 1)
            {
                newUs.ChoiseGend = Gender.Male;
            }
            else if (gender == 2)
            {
                newUs.ChoiseGend = Gender.Female;
            }
            else
            {
                Console.Write("Error, pleace try again: ");
                gender = Convert.ToInt32(Console.ReadLine());
                ChoiseGender(newUs);                
             }
        }

            void GetUserAge()
            {
                Console.Write("Enter your age: ");
                age = Convert.ToInt32(Console.ReadLine());
                if (age > 0 && age < 120)
                {
                    checAge = age;
                }
                else
                {
                    Console.Write("Error! Pleace try again: ");
                    age = Convert.ToInt32(Console.ReadLine());
                    GetUserAge();
                }
            }

        }
       

    }
}