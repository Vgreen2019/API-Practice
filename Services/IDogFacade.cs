using APIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.Services
{
    public interface IDogFacade
    {
        Task<DogViewModel> GetDogViewModel();
    }
}
