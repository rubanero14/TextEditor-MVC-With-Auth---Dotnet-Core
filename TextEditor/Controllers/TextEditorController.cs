using Microsoft.AspNetCore.Mvc;

namespace TextEditor.Controllers
{
    public class TextEditorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
