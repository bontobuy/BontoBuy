using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace BontoBuyWebApplication.Models
{
    public class Status
    {
        public int StatusId{get;set;}
        public string UserStatus { get; set; }
    }

    public class StatusViewModel
    {
        private readonly List<Status> Statuses;

        [Display(Name = "Status")]
        public int SelectedStatusId { get; set; }

        public IEnumerable<System.Web.Mvc.SelectListItem> StatusItems
        {
            get { return new SelectList(Statuses, "StatusId", "UserStatus"); }
        }
       
    }
}