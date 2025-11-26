using DemoMVC.Models.PersonViewModels;

namespace DemoMVC.Models
{
    public class DemoIndexViewModel
    {
        public required List<PersonViewModel> people { get; set; }
        public required MonumentViewModel monument { get; set; }
    }
}
