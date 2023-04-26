using AxoftABM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AxoftABM.Interfaces
{
    public interface ITareaService
    {
        List<Tarea> GetAllTareas();
        Tarea GetTareaById(int id);
        void InsertTarea(Tarea tarea);
        void UpdateTarea(Tarea tarea);
        void DeleteTarea(int id);
        void CrearTablaTareas();
        void MarcarTareaComoCompletada(int id);

    }
}
