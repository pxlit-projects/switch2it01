using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Resources;
using System.Web.Mvc;

namespace FinahProject.Models
{
    public class EnquiryTitelForm
    {
        [Display(Name = "TitleEnquiry", ResourceType= typeof(Resources.form))]
        public String titleEnquiry { get; set; }

        [Display(Name = "DescriptionEnquiry", ResourceType= typeof(Resources.form))]
        public String DescriptionEnquiry { get; set; }

        public List<ExtraPerson> extraPersonList { get; set; }

        public IEnumerable<SelectListItem> extraPerson { get; set; }

        [Display(Name= "ExtraPerson", ResourceType= typeof(Resources.form))]
        public String extraPersonName { get; set; }
    }
}