using Hillel_Task_3.Classes;
using Hillel_Task_3.Enums;

namespace Hillel_Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            int age = 0;
            
            Console.Write("Enter your Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your LastName: ");
            string lastName = Console.ReadLine();


            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            void ChoiseGender(int gender, User newUs)
        {            
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
                ChoiseGender(gender, newUs);
                
             }
        }
            

            User newUs = new User(age);

            newUs.FirstName = firstName;
            newUs.LastName = lastName;
            
            Console.WriteLine("Choose your gender, press 1 if you male or 2 if you female: ");
            int gender = Convert.ToInt32(Console.ReadLine());

            ChoiseGender(gender, newUs);
            var getInf = newUs.ToString();
            Console.WriteLine(getInf);


        }
       












                //if (age > 0 || age < 120)
                //{
                //    age = Convert.ToInt32(record);
                //}
                //if (age <= 10)
                //{
                //    age = Convert.ToInt32(record);
                //    Console.WriteLine("");
                //}

                //switch (age)
                //{
                //    case < 0:
                //        Console.WriteLine("Error, pleace try again: ");
                //        break;
                //    case > 120:
                //        Console.WriteLine("Error, pleace try again: ");
                //        break;
                //    case <= 10:
                //        Console.WriteLine("");
                //        age = Convert.ToInt32(record);
                //        break;
                //    default:
                //        age = Convert.ToInt32(record);
                //        break;
            
    }
}