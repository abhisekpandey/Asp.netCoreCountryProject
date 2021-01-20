using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCall.Models
{
    public class FacilityModel
    {
        public int OTHERFACID { get; set; }
        [Required(ErrorMessage = "Other Facilities Name is required")]
        public string OTHERFACNAME { get; set; }
        [Required(ErrorMessage = "Other Facilities Abbreviation is required")]
        public string ABBV { get; set; }
        public string INCOMETYPE { get; set; }
        [Required(ErrorMessage = "Exempt Amount is required")]
        public Nullable<decimal> AMTEXEMPTED { get; set; }
        [Required(ErrorMessage = "Exempt Percentage is required")]
        public Nullable<decimal> AMTEXEMPTEDPER { get; set; }
        public string GENERATETYPE { get; set; }
        public Nullable<int> OCID { get; set; }
        public Nullable<int> ONMONTH { get; set; }
        public Nullable<int> OTHERFACTYPE { get; set; }
        public Nullable<decimal> SEFFECT { get; set; }
        public Nullable<int> TAXABLEFLAG { get; set; }
        public Nullable<int> AUID { get; set; }
        public Nullable<System.DateTime> ADT { get; set; }
        public Nullable<int> UUID { get; set; }
        public Nullable<System.DateTime> UDT { get; set; }
        public IEnumerable<string> IncomeTypeList { get; set; }
        public IEnumerable<SelectListItem> IncomeTypes { get; set; }
        public IEnumerable<string> MonthList { get; set; }
        public IEnumerable<SelectListItem> Months { get; set; }
        public IEnumerable<string> TaxableFlagList { get; set; }
        public IEnumerable<SelectListItem> TaxableFlags { get; set; }
        public IEnumerable<string> OtherFacilitiesCategoriesList { get; set; }
        public IEnumerable<SelectListItem> OtherFacilitiesCategories { get; set; }
        public IEnumerable<string> OtherFacilitiesList { get; set; }
        public IEnumerable<SelectListItem> OtherFacilities { get; set; }
      
    }
}
