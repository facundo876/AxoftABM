using AxoftABM.Models;
using System.Collections.Generic;

namespace AxoftABM.Interfaces
{
    public interface ITareaRepository
    {
        List<Tarea> GetAllTareas();
        Tarea GetTareaById(int id);
        void InsertTarea(Tarea tarea);
        void UpdateTarea(Tarea tarea);
        void DeleteTarea(int id);
        void CreateTableTask();
    }
}
