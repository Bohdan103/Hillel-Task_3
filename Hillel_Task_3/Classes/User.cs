using Hillel_Task_3.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillel_Task_3.Classes
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender ChoiseGend { get; set; }
        public readonly int Age;

        public User()
        {
        }

        public User(int age) 
        {
            this.Age = age;
        }


        public override string ToString() 
        {
            if (Age <= 10)
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am a baby. I am {ChoiseGend}";
            }
            else
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am {Age} years old. I am {ChoiseGend}";
            }
        }

    }
}
