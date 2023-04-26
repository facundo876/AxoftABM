using AxoftABM.Interfaces;
using AxoftABM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AxoftABM.Services
{
    public class TareaService : ITareaService
    {
        private readonly ITareaRepository _tareaRepository;

        public TareaService(ITareaRepository tareaRepository)
        {
            _tareaRepository = tareaRepository;
        }

        public List<Tarea> GetAllTareas()
        {
            return _tareaRepository.GetAllTareas();
        }

        public Tarea GetTareaById(int id)
        {
            return _tareaRepository.GetTareaById(id);
        }

        public void InsertTarea(Tarea tarea)
        {
            tarea.Id = _tareaRepository.GetAllTareas().Count;
            tarea.FechaCreacion = DateTime.Now;
            tarea.Estado = EstadoTarea.Activa;
            _tareaRepository.InsertTarea(tarea);
        }

        public void UpdateTarea(Tarea tarea)
        {
            _tareaRepository.UpdateTarea(tarea);
        }

        public void DeleteTarea(int id)
        {
            _tareaRepository.DeleteTarea(id);
        }

        public void CrearTablaTareas()
        {
            _tareaRepository.CreateTableTask();
        }

        public void MarcarTareaComoCompletada(int id)
        {
            var tarea = _tareaRepository.GetTareaById(id);
            tarea.Estado = EstadoTarea.Completada;
            _tareaRepository.UpdateTarea(tarea);


        }
    }
}
