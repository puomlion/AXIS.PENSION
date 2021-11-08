using System.ComponentModel.DataAnnotations;
using WebDemo.Models;

namespace WebDemo.Models
{
    public class CustomerViewModel
    {
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Title")]
        public string Title { get; set; }

        [Display(Name = "Notes")]
        public string Notes { get; set; }
    }
}