using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP_NET_MVC_CRUD.Models.Home
{
    public class Page2Model
    {
        [Required(ErrorMessage ="You are a failure when it come to entering form data.")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int? Age { get; set; }
    }
}