using BookNest.Domain.Entities;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using BookNest.Domain.Entities;

namespace BookNest.Web.ViewModels
{
    public class VillaNumberVM
    {
        public VillaNumber? VNumber { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem>? VillaList { get; set; }
    }
}