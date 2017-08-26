using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            return View();
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
        public ActionResult ceshi2()
        {
            string str = Request.RequestContext.RouteData.Values["id"].ToString();
            ViewData["tt"] = str;
            return View();
        }
        
        public ActionResult tijiao()
        {
            
            return View();
        }
        [HttpPost]
        public ActionResult tijiao2(FormCollection form)
        {
            string str = form["strname"].ToString();
            ViewData["tt"] = str;
            return Content("<script>alert('添加成功！');window.location='tijiao'</script>");
            //return View();
        }
        public ActionResult Ceshi()
        {
            ViewBag.Message = "Your contact page.";
            DataTable dt = new DataTable();
            dt.Columns.Add("t1");
            dt.Columns.Add("t2");
            DataRow dr = dt.NewRow();
            dr[0] = "我来测试的";
            dr[1] = "是测试的我来的";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = "我来测试的2";
            dr[1] = "是测试的我来的2";
            dt.Rows.Add(dr);
            dr = dt.NewRow();
            dr[0] = "我来测试的3";
            dr[1] = "是测试的我来的4";
            dt.Rows.Add(dr);

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("t1");
            dt1.Columns.Add("t2");
            DataRow dr1 = dt1.NewRow();
            dr1[0] = "3我来测试的";
            dr1[1] = "3是测试的我来的";
            dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow();
            dr1[0] = "3我来测试的2";
            dr1[1] = "3是测试的我来的2";
            dt1.Rows.Add(dr1);
            dr1 = dt1.NewRow();
            dr1[0] = "3我来测试的3";
            dr1[1] = "3是测试的我来的4";
            dt1.Rows.Add(dr1);
            ViewData["t1"] = dt;
            ViewData["t2"] = dt1;
            return View();
        }
    }
}