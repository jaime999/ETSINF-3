using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDepLib.Entities
{
    public partial class Lane
    {   //ATRIBUTOS
        

        //CONSTRUCTORES
        public Lane ()
        {
            Courses = new List<Course>();
        }

        public Lane (int Number)
        {
            
            this.Number = Number;
            Courses = new List<Course>();
        }
        public void addcourse(Course c)
        {
            Courses.Add(c);
        }
    }
}
