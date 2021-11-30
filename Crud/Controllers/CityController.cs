using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Crud.Models;

namespace Crud.Controllers
{
    public class CityController : Controller
    {
        // GET: City
        public ActionResult Index()
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Cities.ToList());
            }
                
        }

        // GET: City/Details/5
        public ActionResult Details(int id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View( dbModel.Cities.Where(x => x.Id ==id).FirstOrDefault());

            }
                
        }

        // GET: City/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: City/Create
        [HttpPost]
        public ActionResult Create(City city)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Cities.Add(city);
                    dbModel.SaveChanges();

                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: City/Edit/5
        public ActionResult Edit(int id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Cities.Where(x => x.Id == id).FirstOrDefault());

            }
        }

        // POST: City/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, City city)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    dbModel.Entry(city).State = EntityState.Modified;
                    dbModel.SaveChanges();
                }
                    // TODO: Add update logic here

                    return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: City/Delete/5
        public ActionResult Delete(int id)
        {
            using (DbModels dbModel = new DbModels())
            {
                return View(dbModel.Cities.Where(x => x.Id == id).FirstOrDefault());

            }
        }

        // POST: City/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                using (DbModels dbModel = new DbModels())
                {
                    City city = dbModel.Cities.Where(x => x.Id == id).FirstOrDefault();
                    dbModel.Cities.Remove(city);
                    dbModel.SaveChanges();
                }
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
