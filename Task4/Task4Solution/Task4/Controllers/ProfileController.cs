using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task4.Models;
using Task4.Services;

namespace Task4.Controllers
{
    public class ProfileController : Controller
    {
        private ILogger<ProfileController> _logger;
        private IProfile<Profile> _repo;
        public ProfileController(IProfile<Profile> repo, ILogger<ProfileController> logger)
        {
            _logger = logger;
            _repo = repo;
        }
        public ActionResult Index()
        {
            try
            {
                List<Profile> profiles = _repo.GetAll().ToList();
                return View(profiles);
            }
            catch (Exception)
            {
                return RedirectToAction("Error");
            }
                                    
        }
        public ActionResult Details(int id)
        {
            Profile profile = _repo.Get(id);
            return View(profile);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Profile profile)
        {
            try
            {
                _repo.Add(profile);
                return RedirectToAction("Success");
            }
            catch (Exception)
            {
                return RedirectToAction("Error");
            }
        }
        public ActionResult Success()
        {
            return View();
        }
        public ActionResult Error()
        {
            return View();
        }
    }
}
