using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Services;

namespace SalesWebMvc.Controllers
{
    public class SalesRecordsController : Controller
    {
        private readonly SalesRecordService _service;

        public SalesRecordsController(SalesRecordService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var result = await _service.FindAllAsync();
            return View(result);
        }
    }
}