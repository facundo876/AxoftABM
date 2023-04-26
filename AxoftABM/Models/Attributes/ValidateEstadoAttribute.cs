using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AxoftABM.Models.Attributes
{
    public class ValidateEstadoAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var estado = (EstadoTarea)value;
            var fechaVencimiento = (validationContext.ObjectInstance as Tarea)?.FechaVencimiento;

            if (estado == EstadoTarea.Diferida && fechaVencimiento != null)
            {
                // Si el estado es "Diferida" y hay una fecha de vencimiento, se establece como null
                (validationContext.ObjectInstance as Tarea).FechaVencimiento = null;
            }

            return ValidationResult.Success;
        }
    }
}
