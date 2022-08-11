using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.DataVisualization.Charting;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index => View();

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Gest()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

		public ActionResult Index()
		{
			List<DataPoint> dataPoints = new List<DataPoint>();

			dataPoints.Add(new DataPoint(519960, "New Visitors", "#E7823A"));
			dataPoints.Add(new DataPoint(363040, "Returning Visitors", "#546BC1"));

			ViewBag.NewVsReturningVisitors = JsonConvert.SerializeObject(dataPoints);

			dataPoints = new List<DataPoint>();
			dataPoints.Add(new DataPoint(1420050600000, 33000));
			dataPoints.Add(new DataPoint(1422729000000, 35960));
			dataPoints.Add(new DataPoint(1425148200000, 42160));
			dataPoints.Add(new DataPoint(1427826600000, 42240));
			dataPoints.Add(new DataPoint(1430418600000, 43200));
			dataPoints.Add(new DataPoint(1433097000000, 40600));
			dataPoints.Add(new DataPoint(1435689000000, 42560));
			dataPoints.Add(new DataPoint(1438367400000, 44280));
			dataPoints.Add(new DataPoint(1441045800000, 44800));
			dataPoints.Add(new DataPoint(1443637800000, 48720));
			dataPoints.Add(new DataPoint(1446316200000, 50840));
			dataPoints.Add(new DataPoint(1448908200000, 51600));

			ViewBag.NewVisitors = JsonConvert.SerializeObject(dataPoints);

			dataPoints = new List<DataPoint>();
			dataPoints.Add(new DataPoint(1420050600000, 22000));
			dataPoints.Add(new DataPoint(1422729000000, 26040));
			dataPoints.Add(new DataPoint(1425148200000, 25840));
			dataPoints.Add(new DataPoint(1427826600000, 23760));
			dataPoints.Add(new DataPoint(1430418600000, 28800));
			dataPoints.Add(new DataPoint(1433097000000, 29400));
			dataPoints.Add(new DataPoint(1435689000000, 33440));
			dataPoints.Add(new DataPoint(1438367400000, 37720));
			dataPoints.Add(new DataPoint(1441045800000, 35200));
			dataPoints.Add(new DataPoint(1443637800000, 35280));
			dataPoints.Add(new DataPoint(1446316200000, 31160));
			dataPoints.Add(new DataPoint(1448908200000, 34400));

			ViewBag.ReturningVisitors = JsonConvert.SerializeObject(dataPoints);

			return View();
		}
	}
}