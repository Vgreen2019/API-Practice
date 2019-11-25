using APIDemo.Models;
using APIDemo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace APIDemo.Controllers
{
    public class RussianHolidayController: Controller
    {
        private readonly IRussianHolidayFacade _russianHolidayFacade;

        public RussianHolidayController(IRussianHolidayFacade russianHolidayFacade)
        {
            _russianHolidayFacade = russianHolidayFacade;
        }

        public IActionResult GetDay()       //DONT FORGET ROUTE-ID IN VIEW
        {                                      //might have to add model

            return View();
        }

        public async Task<IActionResult> DayResult(GetDayViewModel model)
        {
            var result = await _russianHolidayFacade.GetDayResultViewModel(model);
            return View(result);
        }


    }
}
