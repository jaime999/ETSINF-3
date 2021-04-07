using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDepLib.Entities
{   
    public partial class Monitor : Person
    {   
        

        //CONSTRUCTORES
        public Monitor () : base()
        {
            Courses = new List<Course>();
        }

        public Monitor (String Ssn, String Address, String IBAN, String Name, int ZipCode, String Id) : base(Address,  IBAN,  Name,  ZipCode,  Id)
        {
            this.Ssn = Ssn;
            Courses = new List<Course>();
        }

        public void addcourse(Course c)
        {
            Courses.Add(c);
        }

    }
}
