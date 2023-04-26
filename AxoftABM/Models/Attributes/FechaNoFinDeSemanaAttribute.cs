using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AxoftABM.Models.Attributes
{
    public class FechaNoFinDeSemanaAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime? fecha = value as DateTime?;
            if (fecha != null)
            {
                if (fecha.Value.DayOfWeek == DayOfWeek.Saturday || fecha.Value.DayOfWeek == DayOfWeek.Sunday)
                {
                    return false;
                }
            }
            return true;
        }
        public override string FormatErrorMessage(string name)
        {
            return "La fecha de vencimiento no puede ser un fin de semana.";
        }
    }
}
