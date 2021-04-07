using GestDepLib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDepLib.Services
{
    public interface IGestDepService
    {
        IList<Enrollment> AllEnrollments();

        IList<Payment> AllFreeSwimPayments();
        IList<Pool> AllPools();

        IList<Course> AllCourse();

        IList<Monitor> AllMonitors();

        IList<User> AllUsers();

        IList<Absence> AllAbsences();


        IList<String> listarCallesLibres(Pool p, DateTime iniday);

        IList<Absence> listarFaltasDeUsuario(User user, Course c);
        IList<Absence> listarFaltasPorCurso( Course c);

        void removeAllData();

        void addCourse(Course c);
        void addPool(Pool p);

        void addAbsence(Absence a);
        void deleteAbsence(Absence e);
        void addUser(User u);
        void enrollUserToCourse(DateTime dateTime, User u, Course c);
        void addFreeSwimPayment(DateTime dateTime);
        void addMonitor(Monitor m);

        Course findCourseByName(string name);

        Monitor findMonitorById(string id);

        User findUserByDni(string dni);

        Enrollment findEnrollmentByUserDni(string UserDni);
        void addPayment(Enrollment e, DateTime dateTime);
        void saveChanges();
        Pool findPoolById(int id);

        IList<Course> findCourseByDniMonitor(string dni);
        ICollection<User> findUsersByCourse(Course course);
    }
}
    

