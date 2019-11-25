using APIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.Services
{
    public interface IRussianHolidayService
    {
        Task<RussianHolidayResponse> GetDate(string date);

    }
}
