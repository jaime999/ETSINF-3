﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó mediante una herramienta.
//     Los cambios del archivo se perderán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
namespace GestDepLib.Entities
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Text;

	public partial class Course
	{
		

		public DateTime StartDate
		{
			get;
			set;
		}

        public int Id
        {
            get;
            set;
        }

		public DateTime FinishDate
		{
			get;
			set;
		}

		public DateTime StartHour
		{
			get;
			set;
		}

		public TimeSpan Duration
		{
			get;
			set;
		}

		public int MinimunEnrollments
		{
			get;
			set;
		}

		public int MaximunEnrollments
		{
			get;
			set;
		}

		public bool Cancelled
		{
			get;
			set;
		}

		public double Price
		{
			get;
			set;
		}

		public string Description
		{
			get;
			set;
		}

		public Days CourseDays
		{
			get;
			set;
		}

		public virtual ICollection<Lane> Lanes
		{
			get;
			set;
		}

		public virtual Monitor Monitor
		{
			get;
			set;
		}

		public virtual ICollection<Enrollment> Enrollments
		{
			get;
			set;
		}

    }
}

