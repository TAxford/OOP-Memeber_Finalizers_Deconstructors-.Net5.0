using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Memeber_Finalizers_Deconstructors_.Net5._0
{
    internal class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;
        // member - public field
        public int age;

        // member - property - exposes jobTitle safely - properties start with a capital letter 
        public string JobTitle { 
            get 
            {
                return jobTitle;
            } 
            set
            {
                jobTitle = value;
            } 
        }

        //public member Methods - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age)";
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}, salary");
        }
    }
}
