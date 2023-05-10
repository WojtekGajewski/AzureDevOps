using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C08PropertiesAndFields
{
    internal class Person
    {
        // field
        private string lastName;

        // property
        public string FirstName { get; set; }

        public string LastName 
        {
            get
            {
                return lastName;
            }
            set 
            { 
                lastName = value; 
            }
        }

        public string FullName
        {
            get
            {
                string upperFristName = FirstName.ToUpper();
                string lowerLasterName = LastName.ToLower();

                return upperFristName + " " + lowerLasterName;
            }
        }


    }
}
