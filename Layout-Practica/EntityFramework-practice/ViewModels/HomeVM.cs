using EntityFramework_practice.Models;

namespace EntityFramework_practice.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
    }
}
