﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace DevIO.App.Extensions
{
    public class MoedaAttribute: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            try
            {
                var moeda = Convert.ToDecimal(value, new CultureInfo("pt-BR"));
            }
            catch (Exception)
            {
                return new ValidationResult("Moeda em formato inválido !!!");
            }

            return ValidationResult.Success;
        }
    }
}
