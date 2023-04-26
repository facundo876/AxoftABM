using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AxoftABM.Models.Attributes
{
    public class FechaNoMasDe30DiasAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                DateTime fechaVencimiento = (DateTime)value;
                DateTime fechaCarga = DateTime.Now;

                if ((fechaVencimiento - fechaCarga).TotalDays > 30)
                {
                    return new ValidationResult("La fecha de vencimiento no puede ser mayor a 30 días a partir de la fecha de carga.");
                }
            }

            return ValidationResult.Success;
        }
    }
}
