using AxoftABM.Models.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace AxoftABM.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "La descripcion es requerida.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "El campo Descripción debe tener minimo {2} y máximo de {1} caracteres.")]
        [RegularExpression(@"^(?!^[A-Z]*$)[a-zA-Z0-9$#%&\(\)\[\];]+$", ErrorMessage = "La descripcion no debe estar escrita todo en mayúsculas, solo contener números y letras y símbolos: $ # %& ( ) [ ] ; ")]
        public string Descripcion { get; set; }
        [ValidateEstado]
        public EstadoTarea Estado { get; set; }
        public DateTime FechaCreacion { get; set; }

        [DataType(DataType.Date)]
        [FechaNoFinDeSemana]
        [FechaNoMasDe30Dias]
        public DateTime? FechaVencimiento { get; set; }
    }

    public enum EstadoTarea
    {
        Activa,
        Completada,
        Diferida
    }


}