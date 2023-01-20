using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProject.Models;

namespace TraversalCoreProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    //ajax kullanarak yapılan işlemler için oluşturuldu
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;

        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());
            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            _destinationService.TAdd(destination);
            var value = JsonConvert.SerializeObject(destination);
            return Json(value);
        }
        public IActionResult GetById(int DestinationId)
        {
            var values = _destinationService.TGetById(DestinationId);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }

        [HttpPost]
        public IActionResult DeleteCity(int id)
        {
            var value = _destinationService.TGetById(id);
            _destinationService.TDelete(value);
            return NoContent();
        }
        [HttpPost]
        public IActionResult UpdateCity(Destination destination)
        {
         
            var values = _destinationService.TGetById(destination.DestinationId);
            destination.Status = values.Status;
            destination.Image = values.Image;
            destination.Description = values.Description;
            destination.Capactiy = values.Capactiy;
            destination.CoverImage = values.CoverImage;
            destination.Detail1 = values.Detail1;
            destination.Detail2 = values.Detail2;
            destination.Image2 = values.Image2;
            _destinationService.TUpdate(destination);
            var v = JsonConvert.SerializeObject(destination);
            return Json(v);
        }
    }
}
