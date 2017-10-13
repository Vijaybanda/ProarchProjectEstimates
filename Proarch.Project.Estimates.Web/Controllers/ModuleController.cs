using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Proarch.Project.Estimates.Models;
using Dapper;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace Proarch.Project.Estimates.Controllers
{
    public class ModuleController : Controller
    {
        private SqlConnection con;
        private void SqlConnection()
        {
            string constr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            con = new SqlConnection(constr);
        }

        // GET: Module
        public ActionResult Index()
        {
            return View();
        }

        // GET: Module/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Module/Create
        [HttpPost]
        public ActionResult Create(ModuleModel moduleModel)
        {
            try
            {
                DynamicParameters parm = new DynamicParameters();
                parm.Add("Name", moduleModel.Name);
                parm.Add("Description", moduleModel.Description);
                parm.Add("Status", moduleModel.Status);

                SqlConnection();
                con.Open();
                con.Execute("StoreprocedureName", parm, commandType: CommandType.StoredProcedure);
                con.Close();
            }
            catch 
            {

                throw;
            }


            return View();
        }

        // POST: Module/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Module/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Module/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Module/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Module/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}