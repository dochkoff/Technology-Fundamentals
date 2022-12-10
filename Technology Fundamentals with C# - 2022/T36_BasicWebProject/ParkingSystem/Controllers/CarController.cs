using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ParkingSystem.Data;
using ParkingSystem.Data.Models;
using System.Linq;
using System.Text.RegularExpressions;

namespace ParkingSystem.Controllers
{
    public class CarController : Controller
    {
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            string pattern = @"[E|T|Y|O|P|A|H|K|X|C|B|M]{2}[0-9]{4}[E|T|Y|O|P|A|H|K|X|C|B|M]{2}";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(car.PlateNumber);

            if (match.Success)
            {
                DataAccess.Cars.Add(car);
            }

            return Redirect("/");
        }

        [HttpPost]
        public IActionResult DeleteCar(string plateNumber)
        {
            var car = DataAccess.Cars.FirstOrDefault(x => x.PlateNumber == plateNumber);
            DataAccess.Cars.Remove(car);

            return Redirect("/");
        }
    }
}