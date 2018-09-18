using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeAcademy.Attributes
{
    public class EntityNameAttribute:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)  
        {
            string name = (string)value;
            char firstLetter = name.ToCharArray()[0];
            if (Char.IsUpper(name[0]))
            {
                foreach (char c in name)
                {
                    if (Char.IsWhiteSpace(c) || char.IsLetter(c))
                    {
                        return ValidationResult.Success;
                    }
                }
            }
            return new ValidationResult("Name must contain only letters and begin wih upper");
        }
    }
}
