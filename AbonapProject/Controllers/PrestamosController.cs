using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AbonapProject.Data;
using AbonapProject.Data.Entities;
using AbonapProject.Services;

namespace AbonapProject.Controllers
{
    public class PrestamosController : Controller
    {
        private readonly AbonapDbContext _context;
        private readonly PrestamosServices _prestservices;

        public PrestamosController(AbonapDbContext context, PrestamosServices prestservices)
        {
            _context = context;
            _prestservices = prestservices;
        }

        // GET: Prestamos
        public async Task<IActionResult> Index()
        {
            return View(await _prestservices.GetAll());
        }

        // GET: Prestamos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || id == 0 )
            {
                return NotFound();
            }

            var prestamos = await _prestservices.FindOneById((int)id);
            if (prestamos == null)
            {
                return NotFound();
            }
            return View(prestamos);
        }

        // GET: Prestamos/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Prestamos prestamo)
        {
            if (ModelState.IsValid)
            {
                await _prestservices.Create(prestamo);
                return RedirectToAction("Create");
            }
            return View(prestamo);
        }

        // GET: Prestamos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var prestamo = await _prestservices.FindOneById((int)id);
            if (prestamo == null)
            {
                return NotFound();
            }
            return View(prestamo);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Prestamos prestamo)
        {


            if (ModelState.IsValid)
            {
                try
                {
                    await _prestservices.Update(prestamo);
                }
                catch (DbUpdateConcurrencyException)
                {
                    return NotFound();
                   
                }
                return RedirectToAction(nameof(Index));
            }
            return View(prestamo);
        }

        // GET: Prestamos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var prestamos = await _prestservices.FindOneById((int) id);
            if (prestamos == null)
            {
                return NotFound();
            }

            return View(prestamos);
        }

        // POST: Prestamos/Delete/5
        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _prestservices.Delete(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
