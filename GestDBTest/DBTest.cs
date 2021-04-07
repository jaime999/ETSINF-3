using GestDepLib.Persistence;
using GestDepLib.Entities;
using System.Linq;
using GestDepLib;
using System;
using System.Data.Entity;
using System.Text;
using System.Collections.Generic;
using System.Collections;


namespace GestDep.testing
{
    class DBTest
    {
        static void Main(string[] args)
        {
           IDAL dal = new EntityFrameworkDAL(new GestDepDbContext());
           populateDB(dal);
           displayData(dal);
           
        }

        private static void populateDB(IDAL dal)
        {
            // Remove all data from DB
            dal.Clear<Pool>();
            dal.Clear<Lane>();
            dal.Clear<Person>();
            dal.Clear<Course>();
            dal.Clear<Enrollment>();
            dal.Clear<Payment>();
            dal.Clear<Absence>();

            
            // Populate the database with the data described in lab 4 bulletin (see Apendix)
            DateTime d1 = new DateTime(2017, 10, 20, 8, 0, 0);
            DateTime d2 = new DateTime(2017, 10, 20, 21, 0, 0);
            Pool p = new Pool(d1, d2, 46122, 20, 15, 3);

            Lane l1 = new Lane(1);
            Lane l2 = new Lane(2);
            Lane l3 = new Lane(3);
            Lane l4 = new Lane(4);
            Lane l5 = new Lane(5);
            Lane l6 = new Lane(6);
            p.addlane(l1);
            p.addlane(l2);
            p.addlane(l3);
            p.addlane(l4);
            p.addlane(l5);
            p.addlane(l6);

            DateTime du1 = new DateTime(1990, 06, 05);
            User u1 = new User("1234567890", "Ona Carbonell", "Ona Carbonell's address", 46002, "ES891234121234567890", du1, false);
            DateTime du2 = new DateTime(1977, 04, 12);
            User u2 = new User("2345678901", "Gemma Mengual", "Gemma Mengual's address", 46002, "ES891234121234567890", du2, false);
            DateTime du3 = new DateTime(1990, 11, 10);
            User u3 = new User("3456789012", "Mireia Belmonte", "Mireia Belmonte's address", 46003, "ES891234121234567890", du3, false);
            DateTime du4 = new DateTime(1995, 02, 28);
            User u4 = new User("4567890123", "Rigoberto", "Rigoberto's address", 46122, "ES891234121234567890", du4, false);
            DateTime du5 = new DateTime(1972, 01, 01);
            User u5 = new User("5678901234", "Lázaro", "Lázaro's address", 46122, "ES891234121234567890", du5, true);
            Monitor m1 = new Monitor("SSN01010101", "Michael Phelps' address", "ES891234121234567890", "Michael Phelps", 46001, "X-00000001");

            DateTime d3 = new DateTime(2017, 11, 06);
            DateTime d4 = new DateTime(2018, 06, 29);
            DateTime d5 = Convert.ToDateTime("9:30:00");
            TimeSpan t1 = new TimeSpan(0, 45, 00);
            Course c1 = new Course("Learning with M.Phelps", false, Days.Monday | Days.Wednesday | Days.Friday,  t1, d4, 20, 6, 100.0, d3, d5, m1);
            c1.addlane(l1);
            c1.addlane(l2);
            l1.addcourse(c1);
            l2.addcourse(c1);
            m1.addcourse(c1);

            DateTime d6 = new DateTime(2017, 11, 07);
            DateTime d7 = Convert.ToDateTime("19:00:00");
            TimeSpan t2 = new TimeSpan(1, 00, 00);
            Course c2 = new Course("Swimming for Dummys", true, Days.Tuesday | Days.Thursday,  t2, d4, 16, 8, 75.0, d6, d7, null);
            c2.addlane(l3);
            l3.addcourse(c2);


            DateTime dp1 = new DateTime(2017, 08, 10);
            Payment pg1 = new Payment(dp1, "Free Swim", 3);
            DateTime dp2 = new DateTime(2017, 08, 20);
            Payment pg2 = new Payment(dp2, "Free Swim", 3);
            Payment pg3 = new Payment(dp2, "Free Swim", 3);
            DateTime dp4 = new DateTime(2017, 08, 16);
            Payment pg4 = new Payment(dp4, "First monthly quota - Learning with M.Phelps", 100);
            DateTime dp5 = new DateTime(2017, 08, 26);
            Payment pg5 = new Payment(dp5, "First monthly quota - Learning with M.Phelps", 100);
            DateTime dp6 = new DateTime(2017, 08, 28);
            Payment pg6 = new Payment(dp6, "First monthly quota - Learning with M.Phelps", 100);
            Payment pg7 = new Payment(dp6, "First monthly quota - Swimming for Dummys", 75);
            DateTime dp8 = new DateTime(2017, 09, 04);
            Payment pg8 = new Payment(dp8, "First monthly quota - Swimming for Dummys", 75);

            
            Enrollment e1 = new Enrollment(null, dp4, null, c1, u1);
            DateTime dt1 = new DateTime(2017, 11, 8);
            Absence a = new Absence(dt1);
            c1.addenrollment(e1);
            u1.addenrollment(e1);
            e1.addAbsence(a);

            Enrollment e2 = new Enrollment(null,dp5, null, c1, u2);
            c1.addenrollment(e2);
            u2.addenrollment(e2);
            Enrollment e3 = new Enrollment(null, dp6, null, c1, u3);
            c1.addenrollment(e3);
            u3.addenrollment(e3);
            DateTime? dc1 = new DateTime(2017, 10, 20);
            Enrollment e4 = new Enrollment(dc1, dp6, null, c2, u4);
            c2.addenrollment(e4);
            u4.addenrollment(e4);
            Enrollment e5 = new Enrollment(dc1, dp8, null, c2, u5);
            c2.addenrollment(e5);
            u5.addenrollment(e5);

            


            dal.Insert<Pool>(p);
            dal.Insert<Enrollment>(e1);
            dal.Insert<Course>(c1);
            dal.Insert<Course>(c2);
            dal.Insert<Payment>(pg1);
            dal.Insert<Payment>(pg2);
            dal.Insert<Payment>(pg3);
            dal.Insert<Payment>(pg4);
            dal.Insert<Payment>(pg5);
            dal.Insert<Payment>(pg6);
            dal.Insert<Payment>(pg7);
            dal.Insert<Payment>(pg8);
            dal.Insert<User>(u1);
            dal.Insert<Monitor>(m1);
            dal.Insert<Absence>(a);

            dal.Commit();
        }

        private static void displayData(IDAL dal)
        {
            Pool pool = dal.GetAll<Pool>().First();
            foreach (Course course in dal.GetAll<Course>())
            {
                Console.WriteLine("===================================");
                Console.WriteLine("         Course details         ");
                Console.WriteLine("===================================");
                Console.WriteLine(CourseToString(course));
                //foreach (Days day in Enum.GetValues(typeof(Days)))
                //{
                //    if ((course.CourseDays & day) == day)
                //        Console.WriteLine("Course on " + day.ToString());
                //}
            }
            Console.WriteLine("Payments:");
            foreach (Payment pay in dal.GetAll<Payment>())
                Console.Write(PaymentToString(pay));
            Console.WriteLine("Pres Key to exit...");
            Console.ReadKey();
        }

        public static String PersonToString(Person person)
        {
            return person.Name + " (" + person.Id + ")";
        }

        public static String CourseToString(Course course)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("StartDate: " + course.StartDate);
            sb.AppendLine("FinishDate: " + course.FinishDate);
            sb.AppendLine("Days : " + course.CourseDays);
            sb.AppendLine("Price: " + course.Price);
            sb.AppendLine("Lanes assigned: ");
            foreach (Lane lane in course.Lanes)
                sb.AppendLine(" Lane " + lane.Number);
            if (course.Monitor != null)
                sb.AppendLine("\nUsers enrolled in course " + course.Description + ", with monitor " + PersonToString(course.Monitor));
            else sb.AppendLine("\nUsers enrolled in course " + course.Description + ", with no monitor yet");
            foreach (Enrollment en in course.Enrollments)
            {
                sb.Append(" " + EnrollmentToString(en));
            }
            //sb.AppendLine("");
            return sb.ToString();
        }

        public static String EnrollmentToString(Enrollment en)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(PersonToString(en.User) + " enrolled on " + en.EnrollmentDate);
            return sb.ToString();
        }

        public static String PaymentToString(Payment pay)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(" " + pay.Date + " -> " + pay.Description + ": " + pay.Quantity);
            return sb.ToString();
        }


        private static DateTime createTime(int hours, int minutes, int seconds)
        {
            DateTime now = DateTime.Now;
            return new DateTime(now.Year, now.Month, now.Day, hours, minutes, seconds);
        }

    }
}
