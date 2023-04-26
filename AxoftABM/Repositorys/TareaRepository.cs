using AxoftABM.Interfaces;
using AxoftABM.Models;
using Dapper;
using System.Collections.Generic;
using System.Data;

namespace AxoftABM.Repositorys
{
    public class TareaRepository : ITareaRepository
    {
        private readonly IDbConnection _dbConnection;

        public TareaRepository(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public List<Tarea> GetAllTareas()
        {
            return _dbConnection.Query<Tarea>("SELECT * FROM Tareas").AsList();
        }

        public Tarea GetTareaById(int id)
        {
            return _dbConnection.QueryFirstOrDefault<Tarea>("SELECT * FROM Tareas WHERE Id = @Id", new { Id = id });
        }

        public void InsertTarea(Tarea tarea)
        {
            _dbConnection.Execute("INSERT INTO Tareas (Id, Descripcion, Estado, FechaVencimiento, FechaCreacion) VALUES (@Id, @Descripcion, @Estado, @FechaVencimiento, @FechaCreacion)", tarea);
        }

        public void UpdateTarea(Tarea tarea)
        {
            _dbConnection.Execute("UPDATE Tareas SET Descripcion = @Descripcion, Estado = @Estado, FechaVencimiento = @FechaVencimiento WHERE Id = @Id", tarea);
        }

        public void DeleteTarea(int id)
        {
            _dbConnection.Execute("DELETE FROM Tareas WHERE Id = @Id", new { Id = id });
        }

        public void CreateTableTask()
        {
            var createTableScript = @"
            CREATE TABLE Tareas (
                Id INT IDENTITY(1,1) PRIMARY KEY,
                Descripcion NVARCHAR(100) NOT NULL,
                Estado NVARCHAR(50) NOT NULL,
                FechaVencimiento DATE,
                FechaCreacion DATETIME NOT NULL
            )";
            _dbConnection.Execute(createTableScript);

            // Script para crear tabla Estados
            var createEstadosTableScript = @"
            CREATE TABLE Estados (
                Id INT PRIMARY KEY,
                Nombre NVARCHAR(50) NOT NULL
            )";
            _dbConnection.Execute(createEstadosTableScript);

            // Script para insertar datos en la tabla Estados
            var insertEstadosDataScript = @"
            INSERT INTO Estados (Id, Nombre)
            VALUES (1, 'Activa'), (2, 'Completada'), (3, 'Diferida')";
            _dbConnection.Execute(insertEstadosDataScript);
        }
    }
}

