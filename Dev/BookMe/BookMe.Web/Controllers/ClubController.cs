using System.Web.Mvc;
using BookMe.BusinessLogic.Services.Interfaces;
using BookMe.Web.ViewModels.Club;

namespace BookMe.Web.Controllers
{
    public class ClubController : Controller
    {
        private readonly IClubService _clubService;

        public ClubController(IClubService clubService)
        {
            _clubService = clubService;
        }

        // GET: Club
        public ActionResult Index()
        {
            var clubs = _clubService.GetAllClubs();
            var viewModel = new ClubsVm
            {
                Clubs = clubs
            };

            return View(viewModel);
        }
    }
}