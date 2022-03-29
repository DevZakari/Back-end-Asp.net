using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Oper_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace Oper_CRUD.Controllers
{
    public class EtudiantController : Controller
    {
        private readonly AppDbContext _db;
        public EtudiantController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var displayData = _db.Etudiant.ToList();
            return View(displayData);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Etudiant etu)
        {
            if(ModelState.IsValid)
            {
                _db.Add(etu);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(etu);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }
            var getEmpDetails = await _db.Etudiant.FindAsync(id);
            return View(getEmpDetails);
        }
        
        [HttpPost]
        public async Task<IActionResult> Edit(Etudiant etu)
        {
            if(ModelState.IsValid)
            {
                _db.Update(etu);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(etu);
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getEmpDetails = await _db.Etudiant.FindAsync(id);
            return View(getEmpDetails);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            var getEmpDetails = await _db.Etudiant.FindAsync(id);
            return View(getEmpDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getEmpDetails = await _db.Etudiant.FindAsync(id);
            _db.Remove(getEmpDetails);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }


    }
}
