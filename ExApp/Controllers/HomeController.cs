using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Scripting;
using System.Reflection;

namespace ExApp.Controllers
{
    public class HomeController : Controller
    {
        private static readonly ScriptOptions ScriptOpts = ScriptOptions.Default.AddReferences(
                    typeof(HomeController).GetTypeInfo().Assembly,
                    typeof(HttpContext).GetTypeInfo().Assembly)
            .AddImports("ScriptingInWebAppDemo", "Microsoft.AspNetCore.Http");

        public IActionResult Index()
        {
            return View();
        }
    }
}