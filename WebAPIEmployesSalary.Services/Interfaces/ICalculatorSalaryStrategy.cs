using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPIEmployesSalary.Model;

namespace WebAPIEmployesSalary.Services.Interfaces
{
   
    public interface ICalculatorSalaryStrategy
    {
        decimal OperationCalculatorAnnualSalary(EmployeeAnnualSalary empleado);
    }

}
