using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestDepLib.Entities
{
    public partial class Pool
    {
        public Pool()
        {
            Lanes = new List<Lane>();
        }

        public Pool(DateTime OpeningHour, DateTime ClosingHour,
                    int ZipCode, int DiscountRetired, int DiscountLocal,
                    float freeSwimPrice)
        {
            this.OpeningHour = OpeningHour;
            this.ClosingHour = ClosingHour;
            this.ZipCode = ZipCode;
            this.DiscountRetired = DiscountRetired;
            this.DiscountLocal = DiscountLocal;
            this.FreeSwimPrice = freeSwimPrice;
            Lanes = new List<Lane>();
        }

        public void addlane(Lane l)
        {
            Lanes.Add(l);
        }

        public Lane findLane(int n)
        {
            foreach(Lane l in Lanes)
            {
                if(l.Number == n)
                {
                    return l;
                }
            }
            return null;
        }
        /*public int getFreeLanes(DateTime dt1, Days d)
        {
            int lineasLibres = 6;
            foreach (Lane l in Lanes)
            {
                foreach (Course c in l.Courses)
                {
                    if(c.CourseDays == d)
                    {
                        if(dt1.Date.CompareTo(c.StartDate) >= 0 &&
                            dt1.Date.CompareTo(c.FinishDate) <= 0)
                        {
                            if(dt1.TimeOfDay.CompareTo(c.StartHour) >= 0 && 
                                dt1.TimeOfDay.CompareTo(c.StartHour.Add(c.Duration)) <= 0)
                            {
                                lineasLibres--;
                            }
                        }
                    }
                }
            }
            return lineasLibres;


        }*/

        public int getFreeLanes(DateTime dt1, Days d)
        {
            int lineasLibres = 0;

            foreach (Lane l in Lanes)
            {
                Boolean ocupada = false;
                foreach (Course c in l.Courses)
                {
                    if (c.StartDate.CompareTo(dt1.Date) <= 0
                        || c.FinishDate.CompareTo(dt1.Date) > 0)
                    {
                        if (c.CourseDays.ToString().Contains(d.ToString()))
                        {
                            if (((c.StartHour.Hour*60 + c.StartHour.Minute) >= (dt1.Hour*60 + dt1.Minute) && (c.StartHour.Hour*60 + c.StartHour.Minute) < (dt1.Hour*60 + dt1.Minute + 45))

                                || ((c.Duration.TotalMinutes + c.StartHour.Hour*60 + c.StartHour.Minute) <= (45 + dt1.Hour*60 + dt1.Minute) && (c.Duration.TotalMinutes + c.StartHour.Hour*60 + c.StartHour.Minute) > (dt1.Hour*60 + dt1.Minute)))
                            {
                                ocupada = true;
                            }


                        }
                    }
                }
                if (ocupada == false) { lineasLibres++; }
            }
            return lineasLibres;
        }
    }
}

