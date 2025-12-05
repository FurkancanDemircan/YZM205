using Microsoft.AspNetCore.Mvc;

namespace Week11.Interfaces
{
    public interface IController
    {
        Task<IActionResult> GetAll();
        Task<IActionResult> GetById(int id);
    }
}
