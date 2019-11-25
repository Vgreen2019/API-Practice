using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APIDemo.Models;

namespace APIDemo.Services
{
    public class RussianHolidayFacade : IRussianHolidayFacade
    {
        private readonly IRussianHolidayService _russianHolidayService;

        public RussianHolidayFacade(IRussianHolidayService russianHolidayService)
        {
            _russianHolidayService = russianHolidayService;
        }

        public async Task<DayResultViewModel> GetDayResultViewModel(GetDayViewModel model)     //add private method to formate date, then map
        {
            var stringDate = FormatDate(model.Date);
            var result = await _russianHolidayService.GetDate(stringDate);

            

            var viewModel = new DayResultViewModel();
            viewModel.Date = result.Date;
            viewModel.Holiday = result.Holiday;

            if (viewModel.Holiday == true)
            {
                viewModel.Message = "This is a holiday!";
            }
            else
            {
                viewModel.Message = "This is not holiday! Womp Womp";
            }

            return viewModel;
        }

        private string FormatDate(DateTime date)
        {
            var formattedDate = date.ToString("yyyy-MM-dd");
            return formattedDate;
        }
    }
}
