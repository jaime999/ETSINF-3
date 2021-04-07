using GestDepLib.BusinessLogic.Services;
using GestDepLib.Entities;
using GestDepLib.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDepLib.Services
{
    public class GestDepService : IGestDepService
    {
        private readonly IDAL dal;
        public GestDepService(IDAL dal)
        {
            this.dal = dal;
        }

        public void removeAllData()
        {
            dal.Clear<Course>();
            dal.Clear<Enrollment>();
            dal.Clear<Lane>();
            dal.Clear<Person>();
            dal.Clear<Payment>();
            dal.Clear<User>();
            dal.Clear<Monitor>();
            dal.Clear<Pool>();
            dal.ClearPool<Pool>();
            dal.Commit();
        }

        public void addUser(User u)
        {
            dal.Insert(u);
            dal.Commit();
        }

        public void addPool(Pool pool)
        {
            dal.Insert(pool);
            dal.Commit();
        }
        public void addAbsence(Absence a)
        {
            
            dal.Insert(a);
            dal.Commit();
        }

        public void deleteAbsence(Absence a)
        {
            dal.Delete(a);
            dal.Commit();
        }
        public IList<Pool> AllPools()
        {
            return new List<Pool>(dal.GetAll<Pool>());
        }

        public IList<Absence> AllAbsences()
        {
            return new List<Absence>(dal.GetAll<Absence>());
        }
        public IList<Monitor> AllMonitors()
        {
            return new List<Monitor>(dal.GetAll<Monitor>());
        }
        public IList<Course> AllCourse()
        {
            return new List<Course>(dal.GetAll<Course>());
        }

        public IList<User> AllUsers()
        {
            return new List<User>(dal.GetAll<User>());
        }

        public IList<Enrollment> AllEnrollments()
        {
            return new List<Enrollment>(dal.GetAll<Enrollment>());
        }
        public IList<Absence> listarFaltasPorCurso(Course c)
        {
            IList<Absence> res = new List<Absence>();
            foreach (Course course in AllCourse())
            {
                if (course.Description == c.Description)
                {
                    foreach (Enrollment e in course.Enrollments)
                    {
                        foreach(Absence a in e.Absences)
                        res.Add( a);
                        
                    }
                }
            }
            return res;
        }

        public void addCourse(Course c)
        {

           /* foreach (Lane l in c.Lanes)
            {
                foreach (Course course in l.Courses)
                {
                    if (course.StartDate.CompareTo(c.StartDate) == 0
                        || course.FinishDate.CompareTo(c.StartDate) > 0
                        || course.StartDate.CompareTo(c.FinishDate) < 0)
                    {
                        //coursedays
                        foreach (Days day in Enum.GetValues(typeof(Days)))
                        {
                            if ((course.CourseDays & c.CourseDays & day) == day)
                            {
                                if (course.StartHour.Equals(c.StartHour))
                                {
                                    throw new ServiceException("El curso empieza a la vez que otro, hay líneas ocupadas");
                                }

                                else
                                {
                                    if (course.StartHour.Add(course.Duration).CompareTo(c.StartHour) > 0)
                                    {
                                        throw new ServiceException("Hay un curso impartiéndose, hay líneas ocupadas");
                                    }
                                    else if (c.StartHour.Add(c.Duration).CompareTo(course.StartHour) > 0)
                                    {
                                        throw new ServiceException("Un curso ya ocupa las líneas en ese intervalo de tiempo");
                                    }
                                }
                            }

                        }
                    }
                }
            }*/
            dal.Insert(c);
            dal.Commit();
        }
        public void addMonitor(Monitor m)
        {
            dal.Insert(m);
            dal.Commit();
        }

        public Course findCourseByName(string name)
        {


            foreach (Course c in AllCourse())
            {
                if (c.Description == name)
                {
                    return c;
                }
            }
            return null;
        }

        public Monitor findMonitorById(string id)
        {
            foreach (Monitor m in AllMonitors())
            {
                if (m.Id == id)
                {
                    return m;
                }
            }
            return null;
        }

        public User findUserByDni(string dni)
        {
            foreach (User u in AllUsers())
            {
                if (u.Id == dni)
                {
                    return u;
                }
            }
            return null;
        }


        public Enrollment findEnrollmentByUserDni(string UserDni)
        {
            foreach (Enrollment e in AllEnrollments())
            {
                if (e.User.Id == UserDni)
                {
                    return e;
                }
            }
            return null;
        }
        public void enrollUserToCourse(DateTime dateTime, User u, Course c)
        {
            if (c.FinishDate.CompareTo(DateTime.Today) < 0)
            {
                throw new ServiceException("El curso ya ha finalizado");
            }
            Enrollment e = new Enrollment(null, dateTime, null, c, u);
            Boolean existe = false;
            foreach (Enrollment enr in u.Enrollments)
            {
                if (enr.Equals(e))
                {
                    existe = true;
                    throw new ServiceException("El enrollment ya existe");
                }
            }
            if (existe == false)
            {
                dal.Insert<Enrollment>(e);
                //u.addenrollment(e);
                //c.addenrollment(e);
                dal.Commit();
            }

        }
        public void addFreeSwimPayment(DateTime dateTime)
        {
            Payment p = new Payment(dateTime, "Free Swim", 2);
            dal.Insert(p);
            dal.Commit();
        }
        public void addPayment(Enrollment e, DateTime dateTime)
        {
            Payment p = new Payment(dateTime, "First Monthly quota - " + e.Course.Description, e.Course.Price);
            e.addpayment(p);
            dal.Insert(p);
            dal.Commit();
        }
        public IList<Payment> AllFreeSwimPayments()
        {
            List<Payment> pagosTotales = new List<Payment>(dal.GetAll<Payment>());
            List<Payment> nadoLibre = new List<Payment>();
            foreach (Payment p in pagosTotales)
            {
                if (p.Description == "Free Swim")
                {
                    nadoLibre.Add(p);
                }
            }
            return nadoLibre;
        }
        public Pool findPoolById(int id)
        {
            return dal.GetById<Pool>(id);
        }

        public IList<Course> findCourseByDniMonitor(string dni)
        {
            IList<Course> res = new List<Course>();
            foreach (Monitor m in AllMonitors())
            {
                if (m.Id == dni)
                {
                    foreach(Course c in m.Courses)
                    {
                        res.Add(c);
                    }
                }
            }
            return res;
        }

        public ICollection<User> findUsersByCourse(Course course)
        {
            ICollection<User> res = null;
            foreach(Course c in AllCourse())
            {
                if(c.Id == course.Id)
                {
                    foreach(Enrollment e in course.Enrollments)
                    {
                        res.Add(e.User);
                    }
                }
            }
            return res;

        }

        public IList<Absence> listarFaltasDeUsuario(User user, Course c)
        {
            IList<Absence> res = new List<Absence>();
            foreach(Enrollment e in user.Enrollments)
            {
                if (e.Course.Description == c.Description)
                {
                    foreach (Absence a in e.Absences)
                    {
                        res.Add(a);
                    }
                }
            }
            return res;
            

        }

        public IList<String> listarCallesLibres(Pool p, DateTime iniday)
        {
            IList<String> calleslibres = new List<String>();
            
            IList<Days> dias = new List<Days>();
            dias.Add(Days.Monday);
            dias.Add(Days.Tuesday);
            dias.Add(Days.Wednesday);
            dias.Add(Days.Thursday);
            dias.Add(Days.Friday);
            dias.Add(Days.Saturday);

            int mincierre = p.ClosingHour.Hour * 60 + p.ClosingHour.Minute;
            int minutos = p.OpeningHour.Hour * 60 + p.OpeningHour.Minute;
            DateTime franja = new DateTime(iniday.Year, iniday.Month, iniday.Day, p.OpeningHour.Hour, p.OpeningHour.Minute, p.OpeningHour.Second);
            DateTime aux;

            while (minutos < mincierre)
            {
                DateTime franjafin = franja.AddMinutes(45);
                calleslibres.Add(franja.Hour.ToString() + ":" + franja.Minute.ToString("D2") + 
                                    " - " + franjafin.Hour.ToString() + ":" + franjafin.Minute.ToString("D2"));
                aux = franja;
                foreach (Days d in dias)
                {
                   calleslibres.Add(p.getFreeLanes(aux, d).ToString());
                   aux = aux.AddDays(1);
                }

                franja = franja.AddMinutes(45);
                minutos += 45;
            }
            return calleslibres;
        }

        public void saveChanges()
        {
            dal.Commit();
        }

    }
}
