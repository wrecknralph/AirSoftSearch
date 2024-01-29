using System.ComponentModel.DataAnnotations;

namespace AirsoftSearch.Models
{
    public class SearchModel
    {
        [Required(ErrorMessage = "Keyword required")]
        [Display(Name = "Airsoft Item Keyword: ")]
        public string SearchTerm { get; set; }
    }
}
