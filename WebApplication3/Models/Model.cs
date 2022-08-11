using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Models
{
    public class Model : Controller
    {
		// GET: Model
		[DataContract]
		public class DataPoint
		{
			public DataPoint(double x, double y)
			{
				this.X = x;
				this.Y = y;
			}

			public DataPoint(double y, string name, string color)
			{
				this.Y = y;
				this.Name = name;
				this.Color = color;
			}

			//Explicitly setting the name to be used while serializing to JSON.
			[DataMember(Name = "x")]
			public Nullable<double> X = null;

			//Explicitly setting the name to be used while serializing to JSON.
			[DataMember(Name = "y")]
			public Nullable<double> Y = null;

			//Explicitly setting the name to be used while serializing to JSON.
			[DataMember(Name = "name")]
			public string Name = "";

			//Explicitly setting the name to be used while serializing to JSON.
			[DataMember(Name = "color")]
			public string Color = null;
		}
	}
}