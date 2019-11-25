using APIDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace APIDemo.Controllers
{
    public class DogController : Controller
    {
        private readonly IDogFacade _dogFacade;

        public DogController(IDogFacade dogFacade)
        {
            _dogFacade = dogFacade;
        }

        public async Task<IActionResult> Dog()
        {
            var result = await _dogFacade.GetDogViewModel();

            return View(result);
        }
    }
}