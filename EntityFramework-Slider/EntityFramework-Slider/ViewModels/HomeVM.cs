using EntityFramework_Slider.Models;

namespace EntityFramework_Slider.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Slider { get; set; }
        public SliderInfo SliderInfo { get; set; }
    }
}
