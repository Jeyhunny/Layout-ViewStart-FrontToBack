using EntityFramework_practice.Data;
using EntityFramework_practice.Models;
using EntityFramework_practice.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace EntityFramework_practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
       

        public async Task<IActionResult>  Index()
        {
           
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            
            SliderInfo sliderInfo = await _context.SliderInfos.FirstOrDefaultAsync();

            HomeVM model = new()
            {
                Sliders = sliders,
                SliderInfo = sliderInfo
            };
            return View(model);
        }


      
    }
}