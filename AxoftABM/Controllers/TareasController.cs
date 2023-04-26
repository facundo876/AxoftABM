using AxoftABM.Interfaces;
using AxoftABM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace AxoftABM.Controllers
{
    public class TareasController : Controller
    {
        private readonly ITareaService _tareaService;

        public TareasController(ITareaService tareaService)
        {
            _tareaService = tareaService;
        }

        public IActionResult Index()
        {
            var tareas = _tareaService.GetAllTareas();
            return View(tareas);
        }

        public IActionResult FilterByEstado(EstadoTarea? estado)
        {
            IQueryable<Tarea> tareas = _tareaService.GetAllTareas().AsQueryable();

            if (estado.HasValue)
            {
                tareas = tareas.Where(t => t.Estado == estado.Value);
            }

            return View("Index", tareas.ToList());
        }

        public IActionResult Details(int id)
        {
            var tarea = _tareaService.GetTareaById(id);

            if (tarea == null)
            {
                return NotFound();
            }

            return View(tarea);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Tarea tarea)
        {
            if (ModelState.IsValid)
            {
                _tareaService.InsertTarea(tarea);
                return RedirectToAction(nameof(Index));
            }

            return View(tarea);
        }

        public IActionResult Edit(int id)
        {
            var tarea = _tareaService.GetTareaById(id);

            if (tarea == null)
            {
                return NotFound();
            }

            return View(tarea);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Tarea tarea)
        {
            if (id != tarea.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _tareaService.UpdateTarea(tarea);
                return RedirectToAction(nameof(Index));
            }

            return View(tarea);
        }

        public IActionResult Delete(int id)
        {
            var tarea = _tareaService.GetTareaById(id);

            if (tarea == null)
            {
                return NotFound();
            }

            return View(tarea);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _tareaService.DeleteTarea(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CrearTabla()
        {
            _tareaService.CrearTablaTareas();
            return View();
        }

        public ActionResult MarcarCompletada(int id)
        {
            _tareaService.MarcarTareaComoCompletada(id);
            TempData["Mensaje"] = "La tarea ha sido marcada como completada.";
            return RedirectToAction("Index");
        }

    }
}