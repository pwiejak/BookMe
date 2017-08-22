using System.Web.Mvc;
using AutoMapper;
using BookMe.BusinessLogic.Model;
using BookMe.BusinessLogic.Services.Interfaces;
using BookMe.Web.ViewModels.Club;

namespace BookMe.Web.Controllers
{
    public class AdminController : Controller
    {
        private readonly IClubService _clubService;

        public AdminController(IClubService clubService)
        {
            _clubService = clubService;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Clubs()
        {
            var clubs = _clubService.GetAllClubs();
            var viewModel = new ClubsVm
            {
                Clubs = clubs
            };
            return View(viewModel);
        }

        [HttpGet]
        public ActionResult AddClub()
        {
            var club = new ClubVm();
            return View(club);
        }

        [HttpPost]
        public ActionResult AddClub(ClubVm clubVm)
        {
            if(ModelState.IsValid)
            {
                var club = Mapper.Map<Club>(clubVm);
                var clubId = _clubService.SaveClub(club);
            }

            return RedirectToAction("Clubs");
        }

        [HttpGet]
        public ActionResult Club(int id)
        {
            var club = _clubService.GetClub(id);
            return View(club);
        }

        [HttpGet]
        public ActionResult EditClub(Club club)
        {
            return View(club);   
        }
    }
}