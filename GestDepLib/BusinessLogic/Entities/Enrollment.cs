using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestDepLib.Entities;

namespace GestDepLib.Entities
{
    public partial class Enrollment
    {

        public Enrollment()
        {
            Payments = new List<Payment>();
            Absences = new List<Absence>();

        }

        public Enrollment(DateTime? CancellationDate, DateTime EnrollmentDate,
                            DateTime? ReturnedFirstCuotaIfCancelledCourse, Course Course, User User)
        {
            this.EnrollmentDate = EnrollmentDate;
            this.CancellationDate = CancellationDate;
            this.ReturnedFirstCuotaIfCancelledCourse = ReturnedFirstCuotaIfCancelledCourse;
            this.Course = Course;
            this.User = User;
            Payments = new List<Payment>();
            Absences = new List<Absence>();


        }
        public void addpayment(Payment p)
        {
            Payments.Add(p);
        }
        public void addAbsence(Absence a)
        {
            Absences.Add(a);
        }

    }
}
