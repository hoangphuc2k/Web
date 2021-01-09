﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Areas.Admin.Data;

namespace WebApp.Areas.Admin.Validation
{
    public class LoginPasswordAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var _context = (DPContext)validationContext.GetService(typeof(DPContext));
            var entity = _context.User.SingleOrDefault(e => e.AccountPassword != value.ToString() && e.Status == true);
            if (entity != null)
            {
                return new ValidationResult(GetErrorMessage(value.ToString()));
            }
            return ValidationResult.Success;
        }
        public string GetErrorMessage(string username)
        {
            return $"Mật khẩu không đúng";
        }
    }
}
