using System.ComponentModel.DataAnnotations;
using AutoMapper;

namespace BookMe.Web.ViewModels.Club
{
    public class ClubVm
    {
        public ClubVm()
        {
            RegisterMappings();
        }

        [Required(ErrorMessageResourceType = typeof(Resources.Validation),
            ErrorMessageResourceName = "Required")]
        [EmailAddress(ErrorMessageResourceType = typeof(Resources.Validation),
            ErrorMessageResourceName = "InvalidEmail")]

        [Display(ResourceType = typeof(Resources.Labels), Name = "Email")]
        public string Email { get; set; }

        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Validation),
                            ErrorMessageResourceName = "Required")]
        [Display(ResourceType = typeof(Resources.Labels), Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.Validation),
            ErrorMessageResourceName = "Required")]
        [Display(ResourceType = typeof(Resources.Labels), Name = "Phone")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{3})$", ErrorMessageResourceType = typeof(Resources.Validation),
            ErrorMessageResourceName = "InvalidPhoneNumber")]
        public string Phone { get; set; }

        private void RegisterMappings()
        {
            Mapper.CreateMap<BusinessLogic.Model.Club, ClubVm>();
            Mapper.CreateMap<ClubVm, BusinessLogic.Model.Club>();
        }
    }
}