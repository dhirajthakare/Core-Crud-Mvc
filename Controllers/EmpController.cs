﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Core_Crud_Mvc.Models;
using Microsoft.EntityFrameworkCore;

namespace Core_Crud_Mvc.Controllers
{
    public class EmpController : Controller
    {
        private readonly ApplicationDbContext _db;

        public EmpController(ApplicationDbContext db)
        {
            _db = db;

        }
        public IActionResult Index()
        {
            var Displaydata = _db.EmployeeTable.ToList();
            return View(Displaydata);
        }

        public IActionResult Create()
        {
            return View();
        }

            [HttpPost]
        public async Task<IActionResult> Create(NewEmpClass nec)
        {
            if (ModelState.IsValid)
            {
                _db.Add(nec);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(nec);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("index");
            }

            var getempdetails = await _db.EmployeeTable.FindAsync(id);
            return View(getempdetails);
            

        }

        [HttpPost]

        public async Task<IActionResult> Edit(NewEmpClass nc)
        {
            if (ModelState.IsValid)
            {
                _db.Update(nc);
                await _db.SaveChangesAsync();
                return RedirectToAction("index");
            }
            return View(nc);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("index");
            }

            var getempdetails = await _db.EmployeeTable.FindAsync(id);
            return View(getempdetails);


        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("index");
            }

            var getempdetails = await _db.EmployeeTable.FindAsync(id);
            return View(getempdetails);


        }

            [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            
            var getempdetails = await _db.EmployeeTable.FindAsync(id);
            _db.EmployeeTable.Remove(getempdetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("index");


        }
    }
}
