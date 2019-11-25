using APIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIDemo.Services
{
    public class DogFacade: IDogFacade
    {
        private readonly IDogService _dogService;

        public DogFacade(IDogService dogService)
        {
            _dogService = dogService;
        }

        public async Task<DogViewModel> GetDogViewModel()
        {
            var result = await _dogService.GetDog();

            var viewModel = new DogViewModel();
            viewModel.ImageUrl = result.Message;

            return viewModel;

        }
    }
}
