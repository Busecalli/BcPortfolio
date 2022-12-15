using BcPortfolio.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BcPortfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        HomeModel model = new HomeModel();
        Hakkimda_Manager _hakkimdaManager = new Hakkimda_Manager(new Hakkimda_Dal());
        private Hakkimda _hakkimda;
        Yetenek_Manager _yetenekManager = new Yetenek_Manager(new Yetenek_Dal());
        Tecrube_Manager _tecrubeManager = new Tecrube_Manager(new Tecrube_Dal());
        Servis_Manager _servisManager = new Servis_Manager(new Servis_Dal());
        Yorum_Manager _yorumManager = new Yorum_Manager(new Yorum_Dal());

        int statik = 1;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            _hakkimda = _hakkimdaManager.TGetById(statik);
            HomeModel.Hakkimda = _hakkimda;

            model.Yetenekler = _yetenekManager.TGetList();
            model.Tecrubeler = _tecrubeManager.TGetList().OrderBy(c=>c.TecrubeYil);
            model.Servisler = _servisManager.TGetList();
            model.Yorumlar = _yorumManager.TGetList();

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}