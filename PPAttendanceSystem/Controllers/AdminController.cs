﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5051.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin Dashboard landing page
        public ActionResult AdminDashboard()
        {
            ViewBag.Message = "Admin Dashboard";

            return View();
        }
        public ActionResult AdminDashboardwkm1()
        {
            ViewBag.Message = "Admin Dashboard1";

            return View();
        }
        public ActionResult AdminDashboardwkm2()
        {
            ViewBag.Message = "Admin Dashboard2";

            return View();
        }
        public ActionResult AdminDashboardwkm3()
        {
            ViewBag.Message = "Admin Dashboard3";

            return View();
        }
        public ActionResult AdminDashboardmon()
        {
            ViewBag.Message = "Admin Dashboardm";

            return View();
        }
        public ActionResult AdminDashboardtues()
        {
            ViewBag.Message = "Admin Dashboardt";

            return View();
        }
        public ActionResult AdminDashboardwed()
        {
            ViewBag.Message = "Admin Dashboardw";

            return View();
        }
        public ActionResult AdminDashboardthurs()
        {
            ViewBag.Message = "Admin Dashboardth";

            return View();
        }
        public ActionResult AdminDashboardfri()
        {
            ViewBag.Message = "Admin Dashboardf";

            return View();
        }

        // GET: Class Roster
        public ActionResult ClassRoster()
        {
            ViewBag.Message = "Class Roster";

            return View();
        }

        // GET: Custom Report
        public ActionResult CustomReport()
        {
            ViewBag.Message = "Build Custom Report";

            return View();
        }

        // GET: Class Settings
        public ActionResult ClassSettings()
        {
            ViewBag.Message = "Class Settings";

            return View();
        }
    }
}