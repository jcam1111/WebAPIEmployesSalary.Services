﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIEmployesSalary.Services.Interfaces;

namespace WebAPIEmployesSalary.Services
{
    public class EmployService : IEmployController
    {
        Task<IActionResult> IEmployController.Get()
        {
            throw new NotImplementedException();
        }
    }
}
