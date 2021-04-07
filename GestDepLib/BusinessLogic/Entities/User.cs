using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDepLib.Entities
{
    public partial class User : Person
    {
        
        public User() : base()
        {
            Enrollments = new List<Enrollment>();
        }

        public User(String Id, String Name, String Address, int ZipCode, String IBAN, DateTime BirthDate, Boolean Retired) : base( Address,  IBAN,  Name,  ZipCode,  Id)
        {
            this.BirthDate = BirthDate;
            this.Retired = Retired;
            Enrollments = new List<Enrollment>();
        }
        public void addenrollment(Enrollment e)
        {
            Enrollments.Add(e);
        }
    }
}
