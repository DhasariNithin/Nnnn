using Microsoft.AspNetCore.Mvc;
using PersonsDetails.Database;
using PersonsDetails.Models;

namespace PersonsDetails.Controllers
{
    public class PersonController : Controller
    {
        private ApplicationData _db;

        public PersonController(ApplicationData db)
        {
            _db = db;
        }
        public IActionResult Persondetailss()
        {
            IEnumerable<PersonData> _persondata = _db.Person;
            return View(_persondata);
        }
        //public IActionResult AddPersondetailss()
        //{
        //    return View();
        //}
        //public IActionResult AddPersondetailss(PersonData _persondata)
        //{
        //    _db.Person.Add(_persondata);
        //    _db.SaveChanges();
        //    return RedirectToAction("Persondetailss","Person");
        //}

    }
}
