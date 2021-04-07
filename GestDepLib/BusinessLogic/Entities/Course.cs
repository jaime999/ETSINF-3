using System;
using System.Collections.Generic;
using GestDepLib.Entities;
using GestDepLib.BusinessLogic.Services;

namespace GestDepLib.Entities
{
    public partial class Course
    {
        

        public Course()
        {
            Enrollments = new List<Enrollment>();
            Lanes = new List<Lane>();
        }

        public Course(string Description, bool Cancelled, Days CourseDays,  TimeSpan Duration,
                     DateTime FinishDate, int MaximunEnrollments, int MinimunEnrollments,
                      double Price, DateTime StartDate, DateTime StartHour, Monitor Monitor)
        {
            this.Description = Description;
            this.Cancelled = Cancelled;
            this.CourseDays = CourseDays;
            this.Duration = Duration;
            this.FinishDate = FinishDate;
            this.MaximunEnrollments = MaximunEnrollments;
            this.MinimunEnrollments = MinimunEnrollments;
            this.Price = Price;
            this.StartDate = StartDate;
            this.StartHour = StartHour;
            Enrollments = new List<Enrollment>();
            Lanes = new List<Lane>();
            this.Monitor = Monitor;

    }

        public string toString()
        {
            return this.Id + this.Description;
        }

        public void addlane(Lane l)
        {
            Lanes.Add(l);
        }
        public void addenrollment(Enrollment e)
        {
            Enrollments.Add(e);
        }

        public Enrollment findEnrollment(String i)
        {
            Course c = this;
            foreach(Enrollment e in c.Enrollments)
            {
                if(e.User.Id.Equals(i))
                {
                    return e;
                }
            }
            Console.WriteLine("No se ha encontrado el enrollment");
            return null;
        }

        public void setMonitor(Monitor m)
        {
            if (Monitor == null)
            {
                foreach (Course course in m.Courses)
                {
                    if (course.StartDate.CompareTo(StartDate) == 0
                        || course.FinishDate.CompareTo(StartDate) > 0
                        || course.StartDate.CompareTo(FinishDate) < 0)
                    {
                        //coursedays
                        foreach (Days day in Enum.GetValues(typeof(Days)))
                        {
                            if ((course.CourseDays & CourseDays & day) == day)
                            {
                                if (course.StartHour.Equals(StartHour))
                                {
                                    throw new ServiceException("El curso empieza a la vez que otro, monitor ocupado");
                                }

                                else
                                {
                                    if (course.StartHour.Add(course.Duration).CompareTo(StartHour) > 0)
                                    {
                                        throw new ServiceException("Hay un curso impartiéndose, monitor ocupado");
                                    }
                                    else if (StartHour.Add(Duration).CompareTo(course.StartHour) > 0)
                                    {
                                        throw new ServiceException("Un monitor ya tiene un curso en ese intervalo de tiempo");
                                    }
                                }
                            }
                        }
                    }
                }

                Monitor = m;
            }
            else { throw new ServiceException("Ya hay un monitor impartiendo el curso."); }




        }
    }
}