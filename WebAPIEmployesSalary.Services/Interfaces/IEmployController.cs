using Microsoft.AspNetCore.Mvc;

namespace WebAPIEmployesSalary.Services.Interfaces
{
    public interface IEmployController
    {
        Task<IActionResult> Get();
    }
}