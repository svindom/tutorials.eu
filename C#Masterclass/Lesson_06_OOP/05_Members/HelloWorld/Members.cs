using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
     class Members
    {
        // Member - private field
        private string memberName;
        private string jobTitle;
        private int salary;
        

        // Member - public field
        public int age;

        // Member - property - exposes jobTitle safely - properties start with a capital letter
        public string JobTitle 
        {
            get 
            {
                return JobTitle;
            }
            set
            {
                JobTitle = value;
            }
        }

        // Puplic member Method - can be called from other classes
        public void Introducing (bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine($"Hi my name is {memberName}, and my job title is {jobTitle}. I'm {age} years old");
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }

        // Member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
      
            Console.WriteLine("Object created");
        }

        // Member -finalizer - destructor
        ~Members()
        {
            // Cleanup statements
            Console.WriteLine("Deconstruction of Members object");
            Debug.Write("Destruction of Members object");
        }

    }
}
