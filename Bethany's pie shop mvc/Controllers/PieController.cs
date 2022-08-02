using Bethany_s_pie_shop_mvc.Models;
/*using Bethany_s_pie_shop_mvc.ViewModels;*/ 
using Microsoft.AspNetCore.Mvc;

namespace Bethany_s_pie_shop_mvc.Controllers
{
    public class PieController : Controller
    {
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Cheese cakes";

                return View(_pieRepository.AllPies);

            /*PieListViewModel piesListViewModel = new PieListViewModel(_pieRepository.AllPies, "Cheese cakes");
            return View(piesListViewModel);*/
        }
    }
}
