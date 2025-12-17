using Microsoft.AspNetCore.Mvc;

namespace PairingTestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QuestionsController : Controller
    {
        public QuestionsController()
        {
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}