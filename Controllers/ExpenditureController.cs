using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class ExpenditureController : Controller
    {
        public IActionResult Index()
        {
            var expenditures = new List<Expenditure> {
                new Expenditure { Name = "Laptop", Date =  DateTime.Now, price = 299.99M } ,
                new Expenditure { Name = "Gaming Chair", Date =  DateTime.Now, price = 150.56M },
                new Expenditure { Name = "Razer Mouse", Date =  DateTime.Now, price = 65.99M }
            };
            return View(expenditures);
        }
    }
}
