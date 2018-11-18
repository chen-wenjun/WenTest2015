using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ASP.NET.Mvc.Controllers
{
    //public class HomeController : Controller
    //{
    //    public ActionResult Index()
    //    {
    //        return View();
    //    }

    //    public ActionResult About()
    //    {
    //        ViewBag.Message = "Your application description page.";

    //        return View();
    //    }

    //    public ActionResult Contact()
    //    {
    //        ViewBag.Message = "Your contact page.";

    //        return View();
    //    }
    //}

    public class HomeController : AsyncController
    {
        public async Task<ActionResult> Index()
        {
            DataForSections sections = new DataForSections();

            Stopwatch watch = Stopwatch.StartNew();

            Task<string> t1 = Task.Factory.StartNew(() => sections.GetDataForSection1());
            Task<string> t2 = Task.Factory.StartNew(() => sections.GetDataForSection2());
            Task<string> t3 = Task.Factory.StartNew(() => sections.GetDataForSection3());
            Task<string> t4 = Task.Factory.StartNew(() => sections.GetDataForSection4());

            var results = await Task.WhenAll(t1, t2, t3, t4);

            sections.DataSection1 = results[0];
            sections.DataSection2 = results[1];
            sections.DataSection3 = results[2];
            sections.DataSection4 = results[3];


            watch.Stop();
            ViewBag.Time = watch.ElapsedMilliseconds;

            return View(sections);
        }

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
    }

    public class DataForSections
    {
        public string DataSection1 { get; set; }
        public string DataSection2 { get; set; }
        public string DataSection3 { get; set; }
        public string DataSection4 { get; set; }

        public string GetDataForSection1()
        {
            Task.Delay(10000).Wait();
            return "Hello 1";
        }

        public string GetDataForSection2()
        {
            Task.Delay(10000).Wait();
            return "Hello 2";
        }

        public string GetDataForSection3()
        {
            Task.Delay(10000).Wait();
            return "Hello 3";
        }

        public string GetDataForSection4()
        {
            Task.Delay(10000).Wait();
            return "Hello 4";
        }

    }
}