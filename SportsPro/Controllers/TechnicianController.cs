using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SportsPro.Models;

namespace SportsPro.Controllers
{
    //Technician Controller
    public class TechnicianController : Controller
    {
        private readonly ProductList _context;

        public IActionResult List()
        {
            var technicians = _context.Technicians.ToList();
            return View(technicians);
        }
        private ProductList technicians { get; set; }



        public TechnicianController(ProductList ctx)
        {
            _context = ctx;
        }

        public IActionResult Index()
        {
            var technicianLis = technicians.Technicians.OrderBy(m => m.Name).ToList();
            return View("list", technicianLis);
        }


        //Get method for the edit view
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";

            return View("AddEdit", new Technician());
        }

        //Get method for the edit view
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            var techni = _context.Technicians.Find(id);
            return View(techni);
        }

        //Post method redirecting to the list view
        [HttpPost]
        public IActionResult Edit(Technician technician)
        {

            if (technician.Id == 0)
                _context.Technicians.Add(technician);
            else
                _context.Technicians.Update(technician);
            _context.SaveChanges();
            return RedirectToAction("List", "Technician");
        }

        //Get method for the delete view
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var technician = _context.Technicians.Find(id);
            return View(technician);
        }

        //Post method redirecting to the list view
        [HttpPost]
        public IActionResult Delete(Technician technician)
        {
            _context.Technicians.Remove(technician);
            _context.SaveChanges();
            return RedirectToAction("List", "Technician");
        }



    }
}