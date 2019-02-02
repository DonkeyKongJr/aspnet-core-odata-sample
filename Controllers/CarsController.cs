using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using odata.Models;

namespace odata.Controllers
{
    public class CarsController : ODataController
    {
        [EnableQuery]
        [HttpGet]
        public ActionResult<IEnumerable<Car>> Get()
        {
            var bmw = new Car { Id = 1, Brand = "BMW", Color = "White", Model = "X5" };
            var mercedes = new Car { Id = 2, Brand = "Mercedes", Color = "Blue", Model = "C Class" };
            var audi = new Car { Id = 3, Brand = "Audi", Color = "White", Model = "A5" };

            var cars = new[] { bmw, mercedes, audi };

            return cars;
        }
    }
}
