using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns
{
    //https://www.c-sharpcorner.com/article/all-about-c-sharp-immutable-classes2/
    // Immutable Class means a class which once created, its state cannot be changed later by any means internally or externally.
    //Read Only properties
    // Parametrized constructor to initialize properties,
    class ImmutableObjects
    {
        public FullName name { get; }
        public ImmutableObjects(string _firstName, string _lastName)
        {
            this.name = new FullName();
            this.name.firstName = _firstName;
            this.name.lastName = _lastName;
        }      
    }

    class FullName
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
}
