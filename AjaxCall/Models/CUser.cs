using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCall.Models
{
    public class CUser
    {
        [Key]
        public int ID { get; set; }
        public int CONCODE { get; set; }

        [Display(Name ="English Description")]
        public string DESCRIPTION { get; set; }

        [Display(Name = "English Description")]
        public string NDESCRIPTION { get; set; }
    }
}
