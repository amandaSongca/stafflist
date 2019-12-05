using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffList
{
    public class Class
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int YearInExperience { get; set; }
       
        
    }

    public interface IClass
    {
        void Add(Class person);
        Class Find(string firstName, string lastName, int yearInExperience);
    }

 

}
